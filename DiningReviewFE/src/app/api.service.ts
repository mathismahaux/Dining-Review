import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class ApiService {
  private baseUrl = 'http://localhost:5279';

  constructor(private http: HttpClient) {}

  // Users
  createUser(user: any): Observable<any> {
    return this.http.post(`${this.baseUrl}/users`, user);
  }

  getUser(displayName: string): Observable<any> {
    return this.http.get(`${this.baseUrl}/users/${displayName}`);
  }

  updateUser(displayName: string, user: any): Observable<any> {
    return this.http.put(`${this.baseUrl}/users/${displayName}`, user);
  }

  // Restaurants
  createRestaurant(restaurant: any): Observable<any> {
    return this.http.post(`${this.baseUrl}/restaurants`, restaurant);
  }

  getRestaurant(id: number): Observable<any> {
    return this.http.get(`${this.baseUrl}/restaurants/${id}`);
  }

  searchRestaurants(zipcode: string, allergy?: string): Observable<any> {
    return this.http.get(`${this.baseUrl}/restaurants/search`, {
      params: { zipcode, ...(allergy ? { allergy } : {}) },
    });
  }

  // Dining Reviews
  submitDiningReview(review: any): Observable<any> {
    return this.http.post(`${this.baseUrl}/dining-reviews`, review);
  }

  getPendingReviews(): Observable<any> {
    return this.http.get(`${this.baseUrl}/dining-reviews/pending`);
  }

  updateReviewStatus(id: number, status: string): Observable<any> {
    return this.http.put(`${this.baseUrl}/dining-reviews/${id}/status`, { status });
  }
}