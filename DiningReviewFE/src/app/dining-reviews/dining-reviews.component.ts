import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-dining-reviews',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './dining-reviews.component.html',
  styleUrls: ['./dining-reviews.component.css']
})
export class DiningReviewsComponent {
  reviews: any[] = [];
  newReview: any = { restaurant: '', rating: 0, comment: '' };

  addReview() {
    if (this.newReview.restaurant && this.newReview.rating) {
      this.reviews.push({ ...this.newReview });
      this.newReview = { restaurant: '', rating: 0, comment: '' };
    }
  }
}