import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CustomerDataViewComponent } from './customer-data-view.component';

describe('CustomerDataViewComponent', () => {
  let component: CustomerDataViewComponent;
  let fixture: ComponentFixture<CustomerDataViewComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CustomerDataViewComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CustomerDataViewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
