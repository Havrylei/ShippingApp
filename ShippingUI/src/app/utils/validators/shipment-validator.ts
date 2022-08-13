import { AbstractControl, Validators } from "@angular/forms";

export default class ShipmentValidator {
    static validator() {
        const dateNotInPastValidator = (control: AbstractControl): { [key: string]: boolean } | null => {
            if (control?.value) {
                let todayDateTime = new Date();
                let dateTimeToCheck = new Date(control.value);

                if (dateTimeToCheck < todayDateTime) {
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