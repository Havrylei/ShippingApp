import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { environment } from "src/environments/environment";
import { Country } from "../models/country";

@Injectable()
export class CountryService {
    constructor(private http: HttpClient) { }

    getCountries(): Observable<Country[]> {
        const url = environment.apiAddress + '/Countries';

        return this.http.get<Country[]>(url);
    }
}