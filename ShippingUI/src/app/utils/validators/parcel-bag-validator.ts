import { Validators } from "@angular/forms";
import KeyGenerator from "../generators/key-generator";

export default class ParcelBagValidator {
    static validator() {
        return {
            bagNumber: ['', [Validators.required, Validators.maxLength(15)]],
            bindingKey: [KeyGenerator.generate(), Validators.required]
        }
    }
}