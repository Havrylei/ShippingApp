import { FormGroup } from "@angular/forms";
import { ParcelBag } from "src/app/models/parcel_bag";

export default class ParcelBagFormMapper {
    static map(form: FormGroup): ParcelBag {
        let ctrls = form.controls;
        let parcelBag = <ParcelBag>{
            bagNumber: ctrls['bagNumber'].value
        }

        return parcelBag;
    }
}