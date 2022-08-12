import { LetterBag } from "./letter_bag";
import { ParcelBag } from "./parcel_bag";

export interface Shipment {
    shipmentNumber: string,
    airport: string,
    flightNumber: string,
    flightDate: Date,
    letterBags: LetterBag[],
    parcelBags: ParcelBag[]
}