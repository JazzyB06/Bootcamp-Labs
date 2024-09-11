import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HttpResponse } from '@angular/common/http';

interface HallofFamer {
  firstName: string;
  lastName: string;
  innovation: string;
  year: number;
}

@Injectable({
  providedIn: 'root'
})

export class HallOfFameService {
  private apiUrl = 'https://grandcircusco.github.io/demo-apis/computer-science-hall-of-fame.json'; 
  famousPeople: any;
  hallOfFameService: any;

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.hallOfFameService.getFamousPeople().subscribe({
      next: (data: any) => {
        this.famousPeople = data;
      },
      error: (error: any) => {
        console.error('Error loading famous people', error);
      }
    });
  
}
}

