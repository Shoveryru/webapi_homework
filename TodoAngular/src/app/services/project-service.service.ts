import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Project } from '../shared/classes/project';

@Injectable({
  providedIn: 'root'
})
export class ProjectService {

  url = 'http://localhost:55495/api/values';

  constructor(private http: HttpClient) { }

  public getProjects(): Observable<Project[]> {
    return this.http.get<Project[]>(this.url);
  }
}
