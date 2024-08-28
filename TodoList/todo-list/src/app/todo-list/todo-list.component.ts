import { Component } from '@angular/core';
import { Todo } from '../models/todo';
import { CommonModule, DecimalPipe } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-todo-list',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './todo-list.component.html',
  styleUrl: './todo-list.component.css',
})
export class TodoListComponent {
  todos: Todo[] = [
    {task: 'Go grocery shopping', completed: false, duration: 30, priority: 'HIGH'},
    {task: 'Take the dog for a walk', completed: true, duration: 20, priority: 'LOW'},
    {task: 'Cook dinner', completed: true, duration: 60, priority: 'HIGH'},
    {task: 'Create a new painting', completed: false, duration: 90, priority: 'LOW'}
  ];  


  newTask: string = '';
  newDuration: number | null = null;
  newPriority: 'NORMAL' | 'HIGH' | 'LOW' = 'NORMAL';
  filteredText: string = '';
  editingIndex: number | null = null;
  editedTask: string = '';
  editedDuration: number | null = null;
  editedPriority: 'NORMAL' | 'HIGH' | 'LOW' = 'NORMAL';
filterTodos: string ='';
isListEmpty: string = '';
saveEditing: any;
cancelEditing: any;
removeTodo: any;
startEditing: any;
 


  markAsComplete(todo: Todo): void {
    todo.completed = true;
  }

  deleteTask(todo: Todo): void {
    this.todos = this.todos.filter(t => t !== todo);
  }
  getTodoClass(todo: Todo): string {
    return todo.completed ? 'completed' : '';
  }
  addTodo(): void {
    if (this.newTask && this.newDuration !== null) {
      this.todos.push({
        task: this.newTask,
        completed: false,
        duration: this.newDuration,
        priority: this.newPriority
      });
      this.newTask = '';
      this.newDuration = null;
      this.newPriority = 'NORMAL';
    }
  }
  
   filteredTodos(): Todo[] {
    return this.todos.filter(todo =>
      todo.task.toLowerCase().includes(this.filterTodos.toLowerCase())
    );
  }

  allCompleted(): boolean {
    return this.todos.every(todo => todo.completed);
  }

}


