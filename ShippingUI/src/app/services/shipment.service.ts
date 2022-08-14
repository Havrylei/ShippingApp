import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { CreateShipment } from '../models/create-shipment-models/create-shipment';
import { ViewShipment } from '../models/view-shipment-models/view-shipment';
import { environment } from 'src/environments/environment';

@Injectable()
export class ShipmentService {
    constructor(private http: HttpClient) { }

    getShipments(): Observable<ViewShipment[]> {
        const url = environment.apiAddress + '/Shipment';

        return this.http.get<ViewShipment[]>(url);
    }

    createShipment(shipment: CreateShipment) {
        const url = environment.apiAddress + '/Shipment/Create';

        return this.http.post(url, shipment);
    }

    getAirports() {
        const url = environment.apiAddress + '/Shipment/GetAirports';

        return this.http.get<string[]>(url);
    }
}