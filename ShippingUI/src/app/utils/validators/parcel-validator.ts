import { Validators } from "@angular/forms";

export default class ParcelValidator {
    static validator() {
        return {
            parcelNumber: ['', [Validators.required, Validators.pattern('^[a-zA-z]{2}[0-9]{6}[a-zA-z]{2}$')]],
            recipientName: ['', [Validators.required, Validators.maxLength(100)]],
            destinationCountry: ['', [Validators.required, Validators.pattern('^[a-zA-z]{2}$')]],
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
        };
    }
}