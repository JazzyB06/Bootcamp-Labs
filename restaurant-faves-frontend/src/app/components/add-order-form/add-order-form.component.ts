import { Component, EventEmitter, Output } from '@angular/core';
import { Order } from '../../models/order';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-add-order-form',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './add-order-form.component.html',
  styleUrl: './add-order-form.component.css'
})
export class AddOrderFormComponent {
    newOrder: Order = {
    description: '',
    restaurant: '',
    rating: 1,
    orderAgain: false,
    id: 0
  };
  @Output() orderSave = new EventEmitter<Order>();
  order: Order | undefined;
  orderForm: any;

  onSubmit(): void {
    if (this.orderForm.valid) {
      const newOrder: Order = this.orderForm.value;
      this.orderSave.emit(newOrder);
      this.orderForm.reset({ rating: 1, orderAgain: false });
    } else {
      console.log('Form is invalid');
    }
  }
}
