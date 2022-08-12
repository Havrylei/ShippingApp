import { FormGroup } from "@angular/forms";
import { LetterBag } from "src/app/models/letter_bag";

export default class LetterBagFormMapper {
    static map(form: FormGroup): LetterBag {
        let ctrls = form.controls;
        let letterBag = <LetterBag>{
            bagNumber: ctrls['bagNumber'].value,
            countOfLetters: ctrls['countOfLetters'].value,
            weight: ctrls['weight'].value,
            price: ctrls['price'].value,
        };

        return letterBag;
    }
}