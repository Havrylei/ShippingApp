import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CreateShipmentComponent } from './components/create-shipment/create-shipment.component';
import { ShipmentComponent } from './components/shipment/shipment.component';

const routes: Routes = [
  {
    path: '',
    component: ShipmentComponent
  },
  {
    path: 'create',
    component: CreateShipmentComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
