import { FormGroup } from "@angular/forms";
import { CreateLetterBag } from "src/app/models/create-shipment-models/create-letter_bag";

export default class LetterBagFormMapper {
    static map(form: FormGroup): CreateLetterBag {
        let ctrls = form.controls;
        let letterBag = <CreateLetterBag>{
            bagNumber: ctrls['bagNumber'].value,
            countOfLetters: ctrls['countOfLetters'].value,
            weight: ctrls['weight'].value,
            price: ctrls['price'].value,
        };

        return letterBag;
    }
}