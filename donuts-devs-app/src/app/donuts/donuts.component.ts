import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Donut } from '../../models/donut.model';
import { DonutService } from '../services/donut.service';
@Component({
  selector: 'app-donuts',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './donuts.component.html',
  styleUrl: './donuts.component.css'
  
})
export class DonutsComponent {
  donuts: any[] = [];
  donutService: any;

  ngOnInit(): void {
    this.donutService.getDonuts().subscribe((data: any[]) => {
      this.donuts = data;
    });
}
}
