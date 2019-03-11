import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { CountryListComponent } from './country-list/country-list.component';
import { CountryDetailsComponent } from './country-details/country-details.component';
import { CountryUpdateComponent } from './country-update/country-update.component';
import { CountryCreateComponent } from './country-create/country-create.component';
import { SharedModule } from '../shared/shared.module';
import { ReactiveFormsModule } from '@angular/forms';

@NgModule({
  imports: [
    CommonModule,
    SharedModule,
    ReactiveFormsModule,
    RouterModule.forChild([
      { path: 'list', component: CountryListComponent},
      { path: 'details/:id', component: CountryDetailsComponent },
      { path: 'update/:id', component: CountryUpdateComponent },
      { path: 'create', component: CountryCreateComponent }
    ])
  ],
  declarations: [CountryListComponent, CountryDetailsComponent, CountryUpdateComponent, CountryCreateComponent]
})
export class CountryModule { }
