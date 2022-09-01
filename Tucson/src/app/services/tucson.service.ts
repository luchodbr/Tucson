import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IReserva } from '../models/ireserva';

@Injectable({
  providedIn: 'root'
})
export class TucsonService {
  url: string = "http://localhost:5128/api/Tucson";
  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json'
      // ,Authorization: 'jwt'
    })
  };
  constructor(private http: HttpClient) {

  }
  GetReservas() {
    return this.http.get(this.url);
  }
  GetEsperas() {
    return this.http.get(this.url + "/Espera");
  }
  GetClientes() {
    return this.http.get(this.url + "/Cliente");
  }
  Post(reserva: IReserva) {
    return this.http.post<IReserva>(this.url + "/CreateReserva", reserva, this.httpOptions);
  }
  Delete(reserva: number) {

    return this.http.delete<IReserva>(this.url + "/" + reserva);
  }
}
