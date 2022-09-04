import { TestBed } from '@angular/core/testing';

import { BrandtypeService } from './brandtype.service';

describe('BrandtypeService', () => {
  let service: BrandtypeService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(BrandtypeService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
