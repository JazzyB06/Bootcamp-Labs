import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Order } from '../app/models/order';
import { OrderResponse } from '../app/models/OrderResponse';

@Injectable({
  providedIn: 'root'
})

export class RestaurantFavesService {
  hostAddress = 'https://localhost:7149/api'

  status: string = "";
  errorMessage: string = "";

  constructor(private http: HttpClient) { }

  getOrders(): Observable<Order[]> {
    return this.http.get<Order[]>(this.hostAddress + 'Orders');
  }

  getOrder(id: number): Observable<Order> {
    return this.http.get<Order>(this.hostAddress + `Orders/${id}`);
  }

  putOrder(order:Order): Observable<Order>{
    const params = {
      id: order.id, 
      description: order.description, 
      restaurant: order.restaurant, 
      rating: order.rating, 
      orderAgain: order.orderAgain
    }

    return this.http.put<Order>(this.hostAddress + `Orders/${order.id}`, {params})
  }
  postOrder(order:Order): Observable<Order> {
      const params = {
        id: order.id, 
        description: order.description, 
        restaurant: order.restaurant, 
        rating: order.rating, 
        orderAgain: order.orderAgain
      }
      return this.http.post<Order>(this.hostAddress + 'Orders', {params})
  }
deleteOrder (order:Order){
  console.log(this.hostAddress + `Orders/${order.id}`)
  const deleteResponse = this.http.delete(this.hostAddress + `Orders/${order.id}`).subscribe({
    next: data => {
      this.status = 'Deletion successful';
    },
    error: error => {
      this.errorMessage = error.message;
      console.error('An error has occurred!', error);
    }
  })
}
  }


