import { CreateLetterBag } from "./create-letter_bag";
import { CreateParcelBag } from "./create-parcel_bag";

export interface CreateShipment {
    shipmentNumber: string,
    airport: string,
    flightNumber: string,
    flightDate: Date,
    letterBags: CreateLetterBag[],
    parcelBags: CreateParcelBag[]
}