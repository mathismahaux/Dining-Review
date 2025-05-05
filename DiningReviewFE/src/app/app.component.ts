import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { UsersComponent } from './users/users.component';
import { RestaurantsComponent } from './restaurants/restaurants.component';
import { DiningReviewsComponent } from './dining-reviews/dining-reviews.component';
import { SidebarComponent } from './sidebar/sidebar.component';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, UsersComponent, RestaurantsComponent, DiningReviewsComponent, SidebarComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'dining-review-frontend';
}
