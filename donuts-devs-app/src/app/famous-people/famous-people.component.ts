import { Component, OnInit } from '@angular/core';
import { HallOfFameService } from '../services/hall-of-fame.service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-famous-people',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './famous-people.component.html',
  styleUrl: './famous-people.component.css'
})
export class FamousPeopleComponent {
  famousPeople: any[] = [];

  constructor(private hallOfFameService: HallOfFameService) { }

  ngOnInit(): void {
    this.hallOfFameService.famousPeople().subscribe((data: any[]) => {
      this.famousPeople = data;
    });
}
}
