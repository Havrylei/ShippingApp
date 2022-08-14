import { ViewBag } from "./view-bag";

export interface ViewShipment {
    shipmentNumber: string,
    airport: string,
    flightNumber: string,
    flightDate: Date,
    bags: ViewBag[]
}