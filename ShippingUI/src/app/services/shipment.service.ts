import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Shipment } from '../models/shipment';

const BASE_URL:string = 'http://localhost:7174/api';

@Injectable()
export class ShipmentService {
    constructor(private http: HttpClient) { }

    getShipments(): Observable<Shipment[]> {
        const url = BASE_URL + '/Shipment';

        return this.http.get<Shipment[]>(url);
    }

    createShipment(shipment: Shipment) {
        const url = BASE_URL + '/Shipment/Create';

        return this.http.post(url, shipment);
    }

    getAirports() {
        const url = BASE_URL + '/Shipment/GetAirports';

        return this.http.get<string[]>(url);
    }
}