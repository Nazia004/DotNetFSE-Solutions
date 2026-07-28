import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class CourseService {

  constructor() { }

  getCourses(): string[] {
    return [
      'Angular',
      'React',
      '.NET Core',
      'SQL Server',
      'Azure'
    ];
  }

}