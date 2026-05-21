import { Routes } from '@angular/router';

import { Login } from './components/login/login';
import { Dashboard } from './components/dashboard/dashboard';
import { PatientChart } from './components/patient-chart/patient-chart';
import { LabResults } from './components/lab-results/lab-results';
import { Prescription } from './components/prescription/prescription';

export const routes: Routes = [
  { path: '', component: Login },
  { path: 'dashboard', component: Dashboard },
  { path: 'patient-chart', component: PatientChart },
  { path: 'lab-results', component: LabResults },
  { path: 'prescription', component: Prescription }
];