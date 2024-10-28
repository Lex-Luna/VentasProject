import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { MatSidenavModule } from "@angular/material/sidenav";
import { MatTableModule } from '@angular/material/table';
import { MatSnackBarModule } from '@angular/material/snack-bar';
import { MatCardModule } from "@angular/material/card";
import { RouterModule } from '@angular/router';

import { MatButtonModule } from '@angular/material/button'; // Cambiar MatButton por MatButtonModule
import { MatListModule } from '@angular/material/list';



@Component({
  selector: 'app-root',
  standalone: true,
  imports: [
    RouterOutlet,
    MatSidenavModule,
    RouterModule,
    MatButtonModule,
    MatListModule
    
  ],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
[x: string]: any;
  title = 'AppVentas';
}
