import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { AddOrderFormComponent } from "./components/add-order-form/add-order-form.component";

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, AddOrderFormComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'restaurant-faves-frontend';
}
