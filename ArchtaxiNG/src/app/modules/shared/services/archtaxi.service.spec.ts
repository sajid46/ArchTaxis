import { TestBed } from '@angular/core/testing';

import { ArchtaxiService } from './archtaxi.service';

describe('ArchtaxiService', () => {
  let service: ArchtaxiService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ArchtaxiService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
