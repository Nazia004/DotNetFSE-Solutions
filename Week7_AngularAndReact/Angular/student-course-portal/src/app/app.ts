import { Component, signal } from '@angular/core';
import { Header } from './components/header/header';
import { Home } from './components/home/home';
import { CourseList } from './components/course-list/course-list';
import { StudentProfile } from './components/student-profile/student-profile';

@Component({
  selector: 'app-root',
  imports: [
    Header,
    Home,
    CourseList,
    StudentProfile
  ],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('student-course-portal');
}