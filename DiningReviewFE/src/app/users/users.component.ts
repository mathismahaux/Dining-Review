import { Component } from '@angular/core';
import { ApiService } from '../api.service';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-users',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './users.component.html',
  styleUrls: ['./users.component.css'],
})
export class UsersComponent {
  users: any[] = [];
  user: any = {};
  displayName = '';

  constructor(private apiService: ApiService) {}

  createUser() {
    this.apiService.createUser(this.user).subscribe((response) => {
      console.log('User created:', response);
    });
  }

  getUser() {
    this.apiService.getUser(this.displayName).subscribe((response) => {
      console.log('User fetched:', response);
    });
  }
}