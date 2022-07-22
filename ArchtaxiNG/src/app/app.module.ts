import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavComponent } from './shared/nav/nav.component';
import { MapComponent } from './shared/map/map.component';
import { DriversComponent } from './modules/drivers/drivers.component';
import { HttpClientModule } from '@angular/common/http';
import { BrowserModule } from '@angular/platform-browser';
import { FooterComponent } from './shared/footer/footer.component';
import { AboutusComponent } from './shared/aboutus/aboutus.component';
import { HomeComponent } from './shared/home/home.component';
import { RouterModule, Routes } from '@angular/router';
import { GetquoteComponent } from './shared/getquote/getquote.component';
import { MaterialModule } from './modules/material/material.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { LOCALE_ID } from '@angular/core';
import { MAT_DATE_FORMATS } from '@angular/material/core';
import { ReactiveFormsModule } from '@angular/forms';
import { FleetComponent } from './shared/fleet/fleet.component';
import { BoxDirective } from './shared/directive/box.directive';
import { VehicleComponent } from './shared/sharedComponents/vehicle/vehicle.component';
import { InputComponent } from './shared/sharedComponents/input/input.component';

const routes: Routes = [
  {path: '', component: HomeComponent},
  {path:'aboutus', component: AboutusComponent}
]

export const MY_DATE_FORMATS = {
  parse: {
    dateInput: 'DD-MM-YYYY',
  },
  display: {
    dateInput: 'DD-MM-YYYY',
    monthYearLabel: 'MMM YYYY',
    dateA11yLabel: 'LL',
    monthYearA11yLabel: 'MMMM YYYY'
  },
};

@NgModule({
  declarations:
  [
    AppComponent,
    NavComponent,
    MapComponent,
    DriversComponent,
    FooterComponent,
    AboutusComponent,
    HomeComponent,
    GetquoteComponent,
    FleetComponent,
    BoxDirective,
    VehicleComponent,
    InputComponent],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    HttpClientModule,
    MaterialModule,
    RouterModule.forRoot(routes),
    BrowserAnimationsModule,
    ReactiveFormsModule
    ],
    providers: [
      { provide: MAT_DATE_FORMATS, useValue: MY_DATE_FORMATS }
    ],
  bootstrap: [AppComponent],
})


export class AppModule {}
