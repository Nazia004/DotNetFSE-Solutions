import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-course-dashboard',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './course-dashboard.html',
  styleUrl: './course-dashboard.css'
})
export class CourseDashboard {

  showCourses = true;

  courses = [
    { id: 1, name: 'Angular', duration: '6 Weeks' },
    { id: 2, name: 'React', duration: '5 Weeks' },
    { id: 3, name: '.NET Core', duration: '8 Weeks' },
    { id: 4, name: 'SQL Server', duration: '4 Weeks' }
  ];

}