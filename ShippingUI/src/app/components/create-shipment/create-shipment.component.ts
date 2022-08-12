import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup } from '@angular/forms';
import ShipmentValidator from 'src/app/utils/validators/shipment-validator';
import ParcelBagValidator from 'src/app/utils/validators/parcel-bag-validator';
import LetterBagValidator from 'src/app/utils/validators/letter-bag-validator';
import ParcelValidator from 'src/app/utils/validators/parcel-validator';
import { Shipment } from 'src/app/models/shipment';
import { ShipmentService } from 'src/app/services/shipment.service';
import { Router } from '@angular/router';
import LetterBagFormMapper from 'src/app/utils/formMappers/letter-bag-form-mapper';
import ParcelFormMapper from 'src/app/utils/formMappers/parcel-form-mapper';
import ParcelBagFormMapper from 'src/app/utils/formMappers/parcel-bag-form-mapper';
import ShipmentFormMapper from 'src/app/utils/formMappers/shipment-form-mapper';
import { ShipmentCreationSteps } from 'src/app/utils/enums/shipment-creation-steps';

@Component({
  selector: 'app-create-shipment',
  templateUrl: './create-shipment.component.html',
  styleUrls: ['./create-shipment.component.scss']
})
export class CreateShipmentComponent implements OnInit {
  shipment: Shipment = <Shipment>{};
  shipmentForm: FormGroup;
  airports: String[] = [];
  errorMessages: String[] = [];
  bagForms: FormGroup[] = [];
  letterBagForms: FormGroup[] = [];
  parcelBagForms: Map<FormGroup, FormGroup[]> = new Map<FormGroup, FormGroup[]>;
  currentStep: ShipmentCreationSteps = ShipmentCreationSteps.ShipmentCreationStep;
  shipmentSubmitted: boolean = false;
  bagsSubmitted: boolean = false;
  parcelsSubmitted: boolean = false;
  bagNumberMatch: boolean = false;
  parcelMatch: boolean = false;

  constructor(private formBuilder: FormBuilder, private service: ShipmentService, private router: Router) {
    this.shipmentForm = this.formBuilder.group(ShipmentValidator.validator());
  }

  ngOnInit(): void {
    this.service.getAirports().subscribe(res => this.airports = res);
  }

  returnToEdit(): void {
    this.resetValidation();

    if (!this.parcelBagForms.size) {
      this.currentStep = ShipmentCreationSteps.BagCreationStep;
    } else {
      this.currentStep = ShipmentCreationSteps.ParcelCreationStep;
    }
  }

  get shipmentCreationSteps() {
    return ShipmentCreationSteps;
  }

  get shipmentFormCtrls(): { [key: string]: AbstractControl } {
    return this.shipmentForm.controls;
  }

  get isFinalizeStepDisabled(): boolean {
    return Array.from(this.parcelBagForms.values()).some(x => !x.length);
  }

  isParcelBag(form: FormGroup): boolean {
    return Array.from(this.parcelBagForms.keys()).includes(form);
  }

  onSubmitShipment(): void {
    this.resetValidation();
    this.shipmentSubmitted = true;

    if (this.shipmentForm.invalid) {
      return;
    }

    this.currentStep = ShipmentCreationSteps.BagCreationStep;
  }

  onSubmitBags(): void {
    this.resetValidation();
    this.bagsSubmitted = true;

    if (this.bagForms.some(x => x.invalid)) {
      return;
    }

    if (this.bagForms.length > 1) {
      let noDupBagNumbers = new Set(this.bagForms.map(i => i.controls['bagNumber'].value));

      this.bagNumberMatch = this.bagForms.length !== noDupBagNumbers.size;

      if (this.bagNumberMatch) {
        return;
      }
    }

    if (!this.parcelBagForms.size) {
      this.setupShipment();
      this.currentStep = ShipmentCreationSteps.FinalizeCreationStep;
    } else {
      this.currentStep = ShipmentCreationSteps.ParcelCreationStep;
    }
  }

  onSubmitParcels(): void {
    this.resetValidation();
    this.parcelsSubmitted = true;

    let parcels = Array.from(this.parcelBagForms.values()).reduce((a, b) => a.concat(b), []);

    if (parcels.some(x => x.invalid)) {
      return;
    }

    let noDupParcelNumbers = new Set(parcels.map(i => i.controls['parcelNumber'].value));

    this.parcelMatch = parcels.length !== noDupParcelNumbers.size;

    if (this.parcelMatch) {
      return;
    }

    this.setupShipment();
    this.currentStep = ShipmentCreationSteps.FinalizeCreationStep;
  }

  finalSubmit(): void {
    this.service.createShipment(this.shipment).subscribe(
      _ => {
        sessionStorage.setItem('msg', 'The shipment \'' + this.shipment.shipmentNumber.toUpperCase() + '\' has been created successfully');
        this.router.navigate(['/']);
      },
      errorResponse => {
        if (errorResponse.hasOwnProperty('error') && errorResponse.error.hasOwnProperty('errorMessages')) {
          this.errorMessages = errorResponse.error.errorMessages;
        } else {
          this.errorMessages.push('Service temporarily unavailable');
        }
      }
    );
  }

  addParcelBag() {
    let form = this.formBuilder.group(ParcelBagValidator.validator());

    this.parcelBagForms.set(form, []);
    this.bagForms.push(form);
  }

  addLetterBag() {
    let form = this.formBuilder.group(LetterBagValidator.validator());

    this.letterBagForms.push(form);
    this.bagForms.push(form);
  }

  removeParcelBag(form: FormGroup) {
    if (this.parcelBagForms.get(form)?.length && !confirm("The bag contains parcels. Are you sure to delete?")) {
      return;
    }

    let index = this.bagForms.indexOf(form);

    if (index !== -1) {
      this.bagForms.splice(index, 1);
    }

    this.parcelBagForms.delete(form);
  }

  removeLetterBag(form: FormGroup) {
    let index = this.bagForms.indexOf(form);

    if (index !== -1) {
      this.bagForms.splice(index, 1);
    }

    index = this.letterBagForms.indexOf(form);

    if (index !== -1) {
      this.letterBagForms.splice(index, 1);
    }
  }

  addParcel(bagForm: FormGroup) {
    this.parcelBagForms.get(bagForm)?.push(this.formBuilder.group(ParcelValidator.validator()));
  }

  removeParcel(bagForm: FormGroup, parcelForm: FormGroup) {
    let parcels = this.parcelBagForms.get(bagForm);
    let index = parcels?.indexOf(parcelForm) ?? -1;

    if (index !== -1) {
      parcels?.splice(index, 1);
    }
  }

  setupShipment() {
    let parcelBags = Array.from(this.parcelBagForms.keys()).map(parcelBagForm => {
      let parcels = this.parcelBagForms.get(parcelBagForm)?.map(parcelForm => ParcelFormMapper.map(parcelForm)) ?? [];
      let bag = ParcelBagFormMapper.map(parcelBagForm)

      bag.parcels = parcels;

      return bag;
    });
    let letterBags = this.letterBagForms.map(form => LetterBagFormMapper.map(form));

    this.shipment = ShipmentFormMapper.map(this.shipmentForm);
    this.shipment.parcelBags = parcelBags;
    this.shipment.letterBags = letterBags;
  }

  resetValidation() {
    this.shipmentSubmitted = false;
    this.bagsSubmitted = false;
    this.parcelsSubmitted = false;
    this.bagNumberMatch = false;
    this.parcelMatch = false;
  }
}
