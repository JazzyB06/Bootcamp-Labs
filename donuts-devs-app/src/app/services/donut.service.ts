import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Donut} from '../../models/donut.model';

@Injectable({
  providedIn: 'root'
})
export class DonutService {
  private apiUrl = 'https://grandcircusco.github.io/demo-apis/donuts.json';
  donutService: any;
  donuts: Donut[] = [];
 
  constructor(private http: HttpClient ) { }

  ngOnInit(): void {
    this.donutService.getDonuts().subscribe({
      next: (data: Donut[]) => this.donuts = data,
      error: (error: any) => console.error('Error fetching donuts', error)
    });
  }
}
