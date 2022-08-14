import { CreateParcel } from "./create-parcel";

export interface CreateParcelBag {
    bagNumber: string,
    parcels: CreateParcel[]
}