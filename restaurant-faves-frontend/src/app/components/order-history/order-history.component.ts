import { Component, OnInit } from '@angular/core';
import { RestaurantFavesService } from '../../../service/restaurant-faves.service';
import { Order } from '../../models/order';
import { AddOrderFormComponent } from "../add-order-form/add-order-form.component";
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-order-history',
  standalone: true,
  imports: [AddOrderFormComponent, CommonModule],
  templateUrl: './order-history.component.html',
  styleUrl: './order-history.component.css'
})
export class OrderHistoryComponent  {
orders: Order[] = [];
onOrderSave: any;
deleteOrder: any;
showError: any;


  constructor(
    private restaurantFavesService: RestaurantFavesService
  ) {}

  ngOnInit(): void {
    this.loadOrders();
  }
  loadOrders(): void {
    this.restaurantFavesService.getOrders().subscribe({
      next: (orders: Order[]) => this.orders = orders,
      error: (err) => this.showError('Error fetching orders', err)
    });
  }
}
