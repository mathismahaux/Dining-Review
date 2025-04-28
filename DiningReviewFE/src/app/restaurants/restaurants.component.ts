import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { ApiService } from '../api.service';

@Component({
  selector: 'app-restaurants',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './restaurants.component.html',
  styleUrls: ['./restaurants.component.css']
})
export class RestaurantsComponent {
  restaurants: any[] = [];
  newRestaurant: any = {
    name: '',
    address: '',
    zipcode: '',
    peanutScore: null,
    eggScore: null,
    dairyScore: null,
    overallScore: null
  };
  constructor(private apiService: ApiService) {}

  addRestaurant() {
    if (this.newRestaurant.name && this.newRestaurant.address && this.newRestaurant.zipcode) {
      this.apiService.createRestaurant(this.newRestaurant).subscribe(
        (response) => {
          console.log('Restaurant added:', response);
          this.restaurants.push(response);
          this.newRestaurant = {
            name: '',
            address: '',
            zipcode: '',
            peanutScore: null,
            eggScore: null,
            dairyScore: null,
            overallScore: null
          };
        },
        (error) => {
          console.error('Error adding restaurant:', error);
        }
      );
    }
  }
}