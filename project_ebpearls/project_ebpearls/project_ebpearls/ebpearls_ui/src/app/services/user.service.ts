import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UserService {

   api= 'https://localhost:7275/api'; 
  constructor(private readonly _httpClient: HttpClient) { }

    getUser(): Observable<Array<any>> {
        return this._httpClient.get<Array<any>>(`${this.api}/user`);
    }

    addUser(payload:any): Observable<boolean> {
        payload.status = +payload.status
        return this._httpClient.post<boolean>(`${this.api}/user`, payload);
    }
}