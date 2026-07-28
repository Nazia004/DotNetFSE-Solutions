import { Routes } from '@angular/router';

import { HomePage } from './components/home-page/home-page';
import { About } from './components/about/about';
import { Contact } from './components/contact/contact';

export const routes: Routes = [
  {
    path: '',
    component: HomePage
  },
  {
    path: 'about',
    component: About
  },
  {
    path: 'contact',
    component: Contact
  },
  {
    path: '**',
    redirectTo: ''
  }
];