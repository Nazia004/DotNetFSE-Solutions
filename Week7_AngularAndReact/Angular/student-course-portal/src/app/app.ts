import { Component } from '@angular/core';

import { Header } from './components/header/header';
import { Home } from './components/home/home';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [
    Header,
    Home
  ],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {

}