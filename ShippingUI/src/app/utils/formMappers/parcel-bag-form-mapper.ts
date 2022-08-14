import { FormGroup } from "@angular/forms";
import { CreateParcelBag } from "src/app/models/create-shipment-models/create-parcel_bag";

export default class ParcelBagFormMapper {
    static map(form: FormGroup): CreateParcelBag {
        let ctrls = form.controls;
        let parcelBag = <CreateParcelBag>{
            bagNumber: ctrls['bagNumber'].value
        }

        return parcelBag;
    }
}