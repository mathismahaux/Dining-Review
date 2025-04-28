import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DiningReviewsComponent } from './dining-reviews.component';

describe('DiningReviewsComponent', () => {
  let component: DiningReviewsComponent;
  let fixture: ComponentFixture<DiningReviewsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DiningReviewsComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DiningReviewsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
