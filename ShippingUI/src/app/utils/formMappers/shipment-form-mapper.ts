import { FormGroup } from "@angular/forms";
import { Shipment } from "src/app/models/shipment";

export default class ShipmentFormMapper {
    static map(form: FormGroup): Shipment {
        let ctrls = form.controls;
        let shipment = <Shipment>{
            shipmentNumber: ctrls['shipmentNumber'].value,
            airport: ctrls['airport'].value,
            flightNumber: ctrls['flightNumber'].value,
            flightDate: new Date(ctrls['flightDate'].value)
        };

        return shipment;
    }
}