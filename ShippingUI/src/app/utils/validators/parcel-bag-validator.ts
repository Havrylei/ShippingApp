import { Validators } from "@angular/forms";

export default class ParcelBagValidator {
    static validator() {
        return {
            bagNumber: ['', [Validators.required, Validators.maxLength(15)]]
        }
    }
}