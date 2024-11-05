import { HttpClient, HttpHeaders } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { respuesta } from '../Models/respuesta';

const httpOption = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json'
  })
};

@Injectable({
  providedIn: 'root'
})
export class ApiclienteService {
  private url: string = "https://localhost:7094/api/cliente";
  //para usar httpClient necesitas hacer cambios en APP.CONFIG.TS
  private _http = inject(HttpClient);

  constructor(
    //private _http: HttpClient //devuelve respuesta HTTP
  ) { 

  }
  getCliente(): Observable<respuesta> {
    //return this._http.get<respuesta>(this.url, httpOption);
    try {
      return this._http.get<respuesta>(this.url, httpOption);
    } catch (error) {
      console.error('Error al obtener cliente:', error);
      throw error; // Re-lanzamos el error para que pueda ser manejado por el suscriptor
    }
  }
}
