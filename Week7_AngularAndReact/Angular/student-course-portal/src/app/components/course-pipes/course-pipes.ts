import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-course-pipes',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './course-pipes.html',
  styleUrl: './course-pipes.css'
})
export class CoursePipes {

  courseName = 'Angular Full Stack Development';

  courseFee = 15000;

  today = new Date();

}