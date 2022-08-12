import { AbstractControl, Validators } from "@angular/forms";

export default class ShipmentValidator {
    static validator() {
        const dateNotInPastValidator = (control: AbstractControl): { [key: string]: boolean } | null => {
            if (control?.value) {
                let today = new Date();
                let dateToCheck = new Date(control.value);

                today.setHours(0, 0, 0, 0);
                dateToCheck.setHours(0, 0, 0, 0);

                if (dateToCheck < today) {
                    return { 'invalidDate': true }
                }
            }

            return null;
        }

        return {
            shipmentNumber:
                ['',
                    [
                        Validators.required,
                        Validators.pattern('^[a-zA-z0-9]{3}-[a-zA-z0-9]{6}$')
                    ]
                ],
            airport: ['', Validators.required],
            flightDate: ['', [Validators.required, dateNotInPastValidator]],
            flightNumber:
                ['',
                    [
                        Validators.required,
                        Validators.pattern('^[a-zA-z]{2}[0-9]{4}$')
                    ]
                ]
        }
    }
}