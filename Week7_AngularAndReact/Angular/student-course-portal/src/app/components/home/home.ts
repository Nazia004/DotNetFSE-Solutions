import { Component, OnInit, OnDestroy } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CourseList } from '../course-list/course-list';
import { StudentProfile } from '../student-profile/student-profile';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [
    FormsModule,
    CourseList,
    StudentProfile
  ],
  templateUrl: './home.html',
  styleUrl: './home.css'
})
export class Home implements OnInit, OnDestroy {

  portalName = 'Student Course Portal';

  isPortalActive = true;

  message = '';

  searchTerm = '';

  courses = [
  'Angular',
  'React',
  '.NET Core',
  'SQL Server'
];

  constructor() {
    console.log('Constructor called');
  }

  ngOnInit(): void {
    console.log('HomeComponent Initialized');
  }

  ngOnDestroy(): void {
    console.log('HomeComponent Destroyed');
  }

  onEnrollClick() {
    this.message = 'Enrollment opened!';
  }

}