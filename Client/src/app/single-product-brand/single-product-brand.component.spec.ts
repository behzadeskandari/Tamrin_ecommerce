import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SingleProductBrandComponent } from './single-product-brand.component';

describe('SingleProductBrandComponent', () => {
  let component: SingleProductBrandComponent;
  let fixture: ComponentFixture<SingleProductBrandComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SingleProductBrandComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SingleProductBrandComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
