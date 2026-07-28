import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-student-form',
  standalone: true,
  imports: [FormsModule],
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