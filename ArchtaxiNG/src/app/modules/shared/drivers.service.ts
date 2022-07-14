import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class DriversService {
  baseUrl: string;

  constructor(private http: HttpClient) {
    this.baseUrl = 'https://localhost:5001/api/jobs';
  }

  getDrivers(): Observable<any[]> {
    return this.http.get<any[]>(`${this.baseUrl}/jobs`);
  }
}
