import { Component, OnInit } from '@angular/core';
import { ProjectService } from '../../services/project-service.service';
import { Project } from '../../shared/classes/project';

@Component({
  selector: 'app-project-list',
  templateUrl: './project-list.component.html',
  styleUrls: ['./project-list.component.css']
})
export class ProjectListComponent implements OnInit {

  projects: Project[];

  constructor(private service: ProjectService) { }

  ngOnInit() {
  }

  public onClick() {
    this.service.getProjects().subscribe(data => this.projects = data);
  }
}
