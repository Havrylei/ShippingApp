import { Component, OnInit } from '@angular/core';
import { ViewShipment } from 'src/app/models/view-shipment-models/view-shipment';
import { ShipmentService } from 'src/app/services/shipment.service';

@Component({
  selector: 'app-shipment',
  templateUrl: './shipment.component.html',
  styleUrls: ['./shipment.component.scss']
})
export class ShipmentComponent implements OnInit {
  shipments: ViewShipment[] = [];
  clickedShipmentNumber: string | undefined;
  msg: string | undefined;

  constructor(private service: ShipmentService) { }

  ngOnInit(): void {
    this.service.getShipments().subscribe(res => {
      this.shipments = res;
    });

    this.showMessage();
  }

  showMessage() {
    let msg = sessionStorage.getItem('msg');

    if (msg) {
      this.msg = msg;

      sessionStorage.removeItem('msg');

      setTimeout(() => {
        this.msg = undefined;
      }, 5000);
    }
  }

  convertUtcToLocal(date: Date): Date {
    date = new Date(date);

    let localDate = new Date(date.getTime() + date.getTimezoneOffset() * 60 * 1000);
    let offset = date.getTimezoneOffset() / 60;
    let hours = date.getHours();

    localDate.setHours(hours - offset);

    return localDate;
  }
}
