import { Component, OnInit, OnDestroy } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CourseList } from '../course-list/course-list';
import { StudentProfile } from '../student-profile/student-profile';
import { CourseDashboard } from '../course-dashboard/course-dashboard';
import { CoursePipes } from '../course-pipes/course-pipes';
import { CourseService } from '../../services/course.service';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [
  FormsModule,
  CourseList,
  StudentProfile,
  CourseDashboard,
  CoursePipes
],
  templateUrl: './home.html',
  styleUrl: './home.css'
})
export class Home implements OnInit, OnDestroy {

  portalName = 'Student Course Portal';

  isPortalActive = true;

  message = '';

  searchTerm = '';

  courses: string[] = [];

  constructor(private courseService: CourseService) {
  console.log('Constructor called');
}

  ngOnInit(): void {

  this.courses = this.courseService.getCourses();

  console.log('HomeComponent Initialized');

}

  ngOnDestroy(): void {
    console.log('HomeComponent Destroyed');
  }

  onEnrollClick() {
    this.message = 'Enrollment opened!';
  }

}