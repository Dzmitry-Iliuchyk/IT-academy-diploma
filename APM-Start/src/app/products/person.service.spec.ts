import { TestBed } from '@angular/core/testing';

import { PersonsService } from './person.service';

describe('ProductListService', () => {
  let service: PersonsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(PersonsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
