import { Routes } from '@angular/router';
import { HomeComponent } from '../Component/home/home.component';
import { ClienteComponent } from '../Component/cliente/cliente.component';
export const routes: Routes = [
    { path: "home", component: HomeComponent },
    { path: "", redirectTo: 'home', pathMatch: "full" },
    { path: "cliente", component: ClienteComponent }
];
