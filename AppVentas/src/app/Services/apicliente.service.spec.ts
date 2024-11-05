import { TestBed } from '@angular/core/testing';

import { ApiclienteService } from './apicliente.service';

describe('ApiclienteService', () => {
  let service: ApiclienteService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ApiclienteService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
