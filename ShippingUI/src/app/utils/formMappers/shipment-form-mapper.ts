import { FormGroup } from "@angular/forms";
import { CreateShipment } from "src/app/models/create-shipment-models/create-shipment";

export default class ShipmentFormMapper {
    static map(form: FormGroup): CreateShipment {
        let ctrls = form.controls;
        let shipment = <CreateShipment>{
            shipmentNumber: ctrls['shipmentNumber'].value,
            airport: ctrls['airport'].value,
            flightNumber: ctrls['flightNumber'].value,
            flightDate: new Date(ctrls['flightDate'].value)
        };

        return shipment;
    }
}