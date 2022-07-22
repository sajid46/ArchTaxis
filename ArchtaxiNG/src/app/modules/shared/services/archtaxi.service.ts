import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class ArchtaxiService {
  baseUrl = 'https://localhost:5001/api/jobs';
  constructor(private http: HttpClient) {}

  getDriver(): Observable<any[]> {
    return this.http.get<any[]>(`${this.baseUrl}/drivers`);
  }

  getJobs(): Observable<any[]> {
    return this.http.get<any[]>(`${this.baseUrl}/jobs`);
  }
}
