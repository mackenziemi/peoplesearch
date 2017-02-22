import { Injectable } from "@angular/core"
import { Http, Response, Headers, RequestOptions } from "@angular/http"
import { Observable } from "rxjs/Observable";
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/toPromise';
import { Person } from "../people/person";

@Injectable()
export class PeopleService {

    constructor(private http: Http){ }

    private baseUrl = "http://localhost:35767/api/people/"; //web api URL

    get(filter: string) {

        if (filter == null) {
            url = this.baseUrl;
            return this.http.get(url)
                .map(response => response.json());
        } else {

            var url = this.baseUrl + "?filter=" + filter;
            return this.http.get(url)
                .map(response => response.json());
        }
       
    }

    private handleError(error: Response) {

        // output error to the console
        console.error(error);
        return Observable.throw(error.json().error || "Server error");
    }

}