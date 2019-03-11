import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router, ActivatedRoute } from '@angular/router';
import { ErrorHandlerService } from 'src/app/shared/error-handler.service';

@Component({
  selector: 'app-country-details',
  templateUrl: './country-details.component.html',
  styleUrls: ['./country-details.component.css']
})
export class CountryDetailsComponent implements OnInit {
  public country: Country;
  public errorMessage = '';


  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string,
                private router: Router,
                private activeRoute: ActivatedRoute,
                private errorHandler: ErrorHandlerService) {
    const id: number = this.activeRoute.snapshot.params['id'];

    http.get<Country>(baseUrl + 'api/Country/' + id).subscribe(result => {
      this.country = result;
      console.log(this.country);
    }, error => {console.error(error);

      this.errorHandler.handleError(error);
      this.errorMessage = this.errorHandler.errorMessage;
    });
  }

  ngOnInit() {
  }

}
