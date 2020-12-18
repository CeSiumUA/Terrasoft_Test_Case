import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from "rxjs";
import {Metrics} from "./metrics";
import {environment} from "../../environments/environment";

@Injectable({
  providedIn: 'root'
})
export class ServerAnalizerService{
  constructor(private httpClient: HttpClient) {
  }
  public getMetrics(Text: string): Observable<Metrics[]>{
    return this.httpClient.post<Metrics[]>(`${environment.ipAddress}/api/metrics`, {
      Text
    });
  }
}
