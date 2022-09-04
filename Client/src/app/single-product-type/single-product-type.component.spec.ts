import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SingleProductTypeComponent } from './single-product-type.component';

describe('SingleProductTypeComponent', () => {
  let component: SingleProductTypeComponent;
  let fixture: ComponentFixture<SingleProductTypeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SingleProductTypeComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SingleProductTypeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
