import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { DonutsComponent } from "./donuts/donuts.component";
import { FamousPeopleComponent } from "./famous-people/famous-people.component";

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, DonutsComponent, FamousPeopleComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'donuts-devs-app';
}
