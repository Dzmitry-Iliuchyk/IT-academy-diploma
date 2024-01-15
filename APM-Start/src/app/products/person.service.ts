import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from "@angular/common/http";
import { Observable, catchError, tap, throwError } from 'rxjs';
import { IPerson, IPersonsApi } from './person';


@Injectable({
  providedIn: 'root'
})
export class PersonsService {

  private API_URL = "https://localhost:7287/api/Angular";

  constructor(private http: HttpClient) { }

  getProducts(): Observable<{ persons: IPerson[] }> {

    var data = this.http.get<{ persons: IPerson[] }>(this.API_URL);

    return data;
  }

}