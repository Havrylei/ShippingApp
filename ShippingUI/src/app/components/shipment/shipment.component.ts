import { Component, OnInit } from '@angular/core';
import { Parcel } from 'src/app/models/parcel';
import { Shipment } from 'src/app/models/shipment';
import { ShipmentService } from 'src/app/services/shipment.service';

@Component({
  selector: 'app-shipment',
  templateUrl: './shipment.component.html',
  styleUrls: ['./shipment.component.scss']
})
export class ShipmentComponent implements OnInit {
  shipments: Shipment[] = [];
  clickedShipmentNumber: string | undefined;
  msg: string | undefined;

  constructor(private service: ShipmentService) { }

  ngOnInit(): void {
    this.service.getShipments().subscribe(res => {
      this.shipments = res;
    });

    let msg = sessionStorage.getItem('msg');

    if (msg) {
      this.msg = msg;

      sessionStorage.removeItem('msg');

      setTimeout(() => {
        this.msg = undefined;
      }, 5000);
    }
  }

  getParcelsTotalPrice(parcels: Parcel[]): number {
    return parcels.reduce((sum, p) => sum + p.price, 0);
  }
}
