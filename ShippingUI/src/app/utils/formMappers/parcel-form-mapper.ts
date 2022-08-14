import { FormGroup } from "@angular/forms";
import { CreateParcel } from "src/app/models/create-shipment-models/create-parcel";

export default class ParcelFormMapper {
    static map(form: FormGroup): CreateParcel {
        let ctrls = form.controls;
        let parcel = <CreateParcel>{
            parcelNumber: ctrls['parcelNumber'].value,
            recipientName: ctrls['recipientName'].value,
            destinationCountry: ctrls['destinationCountry'].value,
            weight: ctrls['weight'].value,
            price: ctrls['price'].value
        };

        return parcel;
    }
}