import { Validators } from "@angular/forms";

export default class LetterBagValidator {
    static validator() {
        return {
            bagNumber: [
                '', [
                    Validators.required,
                    Validators.maxLength(15),
                    Validators.pattern('^[a-zA-z0-9]+$')
                ]
            ],
            countOfLetters: ['', [Validators.required, Validators.min(1)]],
            weight: [
                '', [
                    Validators.required,
                    Validators.min(0.001),
                    Validators.pattern('^[0-9]+(\.[0-9]{1,3})?$')
                ]
            ],
            price: [
                '', [
                    Validators.required,
                    Validators.min(0.01),
                    Validators.pattern('^[0-9]+(\.[0-9]{1,2})?$')
                ]
            ]
        }
    }
}