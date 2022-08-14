import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { CreateShipment } from '../models/create-shipment-models/create-shipment';
import { ViewShipment } from '../models/view-shipment-models/view-shipment';

const BASE_URL: string = 'https://localhost:7174/api';

@Injectable()
export class ShipmentService {
    constructor(private http: HttpClient) { }

    getShipments(): Observable<ViewShipment[]> {
        const url = BASE_URL + '/Shipment';

        return this.http.get<ViewShipment[]>(url);
    }

    createShipment(shipment: CreateShipment) {
        const url = BASE_URL + '/Shipment/Create';

        return this.http.post(url, shipment);
    }

    getAirports() {
        const url = BASE_URL + '/Shipment/GetAirports';

        return this.http.get<string[]>(url);
    }
}