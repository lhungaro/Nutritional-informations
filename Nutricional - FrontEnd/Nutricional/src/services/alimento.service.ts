import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Alimento } from "../models/alimento";

@Injectable()

export class AlimentoService{

  baseURL = 'https://localhost:5001/Alimentos';

  constructor(private http: HttpClient) {}

  public getAlimentos() : Observable<Alimento[]>{
    return this.http.get<Alimento[]>(this.baseURL);
  }

  public getAlimentoById() : Observable<Alimento>{
    return this.http.get<Alimento>(this.baseURL);
  }

  public post(alimento: Alimento) : Observable<Alimento>{
    return this.http.post<Alimento>(this.baseURL, alimento);
  }

  // public put(id: number, alimento: Alimento) : Observable<Alimento>{
  //   return this.http.put<Alimento>(`${this.baseURL}/${id}`, alimento);
  // }

  // public delete(id: number) : Observable<any>{
  //   return this.http.delete<any>(`${this.baseURL}/${id}`);
  //}


}
