import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ShipmentComponent } from './components/shipment/shipment.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { ShipmentService } from './services/shipment.service';
import { CreateShipmentComponent } from './components/create-shipment/create-shipment.component';
import { CountryService } from './services/country.service';

@NgModule({
  declarations: [
    AppComponent,
    ShipmentComponent,
    CreateShipmentComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    AppRoutingModule,
    NgbModule,
    ReactiveFormsModule
  ],
  providers: [
    CountryService,
    ShipmentService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
