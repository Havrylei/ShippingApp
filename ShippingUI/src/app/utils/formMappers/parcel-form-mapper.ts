import { FormGroup } from "@angular/forms";
import { Parcel } from "src/app/models/parcel";

export default class ParcelFormMapper {
    static map(form: FormGroup): Parcel {
        let ctrls = form.controls;
        let parcel = <Parcel>{
            parcelNumber: ctrls['parcelNumber'].value,
            recipientName: ctrls['recipientName'].value,
            destinationCountry: ctrls['destinationCountry'].value,
            weight: ctrls['weight'].value,
            price: ctrls['price'].value
        };

        return parcel;
    }
}