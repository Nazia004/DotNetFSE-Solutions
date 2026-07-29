import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-student-form',
  standalone: true,
  imports: [
    CommonModule,
    FormsModule
  ],
  templateUrl: './student-form.html',
  styleUrl: './student-form.css'
})
export class StudentForm {

  student = {
    name: '',
    email: '',
    course: ''
  };

  onSubmit() {
    alert('Registration Successful!');
    console.log(this.student);
  }

}