import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-country',
  templateUrl: './country.component.html',
  styleUrls: ['./country.component.css']
})
export class CountryComponent implements OnInit {
  public countries: Country[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Country[]>(baseUrl + 'api/Country/countries').subscribe(result => {
      this.countries = result;
      console.log(this.countries);
    }, error => console.error(error));
  }

  ngOnInit() {
  }
}




