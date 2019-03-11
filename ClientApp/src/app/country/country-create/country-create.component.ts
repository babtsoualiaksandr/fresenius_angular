import { Component, OnInit, Inject } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { ErrorHandlerService } from 'src/app/shared/error-handler.service';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-country-create',
  templateUrl: './country-create.component.html',
  styleUrls: ['./country-create.component.css']
})
export class CountryCreateComponent implements OnInit {
  public errorMessage = '';
  public countryForm: FormGroup;
  public country: Country;
  public Http:  HttpClient;
  public BaseUrl: string;

  constructor(private errorHandler: ErrorHandlerService, private router: Router,
    http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
      this.Http = http;
      this.BaseUrl = baseUrl;
     }

  ngOnInit() {
    this.countryForm = new FormGroup({
      name: new FormControl('', [Validators.required, Validators.maxLength(60)])
    });
  }

  public validateControl(controlName: string) {
    if (this.countryForm.controls[controlName].invalid && this.countryForm.controls[controlName].touched) {
      return true;
    }

    return false;
  }

  public createCountry(countryFormValue) {
    if (this.countryForm.valid) {
      this.executeCountryCreation(countryFormValue);
    }
  }

  private executeCountryCreation(countryFormValue) {
    const country: CountryForCreation = {
      name: countryFormValue.name
    };
    this.Http.post<Country>(this.BaseUrl + 'api/Country', country).subscribe(result => {
      this.country = result;
      console.log(result);
      }, error => {console.error(error);
      this.errorHandler.handleError(error);
      this.errorMessage = this.errorHandler.errorMessage;
    });

  }

  public hasError(controlName: string, errorName: string) {
    if (this.countryForm.controls[controlName].hasError(errorName)) {
      return true;
    }

    return false;
  }

  public redirectToCountryList() {
    this.router.navigate(['/country/list']);
  }

}
