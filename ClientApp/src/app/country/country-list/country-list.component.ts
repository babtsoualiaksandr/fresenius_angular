import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { ErrorHandlerService } from 'src/app/shared/error-handler.service';

@Component({
  selector: 'app-country-list',
  templateUrl: './country-list.component.html',
  styleUrls: ['./country-list.component.css']
})
export class CountryListComponent implements OnInit {
  public countries: Country[];
  public errorMessage = '';

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string,
              private router: Router,
              private errorHandler: ErrorHandlerService) {
    http.get<Country[]>(baseUrl + 'api/Country/countries').subscribe(result => {
      this.countries = result;
      console.log(this.countries);
    }, error => {console.error(error);
      this.errorHandler.handleError(error);
      this.errorMessage = this.errorHandler.errorMessage;
    });
  }

  ngOnInit() {
  }

  public getCountryDetails(id: number) {
    console.log(id);
    const detailsUrl = '/country/details/' + id;
    this.router.navigate([detailsUrl]);
  }

  public getCountryUpdate(id: number) {
    console.log(id);
    const detailsUrl = '/country/update/' + id;
    this.router.navigate([detailsUrl]);
  }

}
