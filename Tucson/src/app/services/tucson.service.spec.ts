import { TestBed } from '@angular/core/testing';

import { TucsonService } from './tucson.service';

describe('TucsonService', () => {
  let service: TucsonService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(TucsonService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
