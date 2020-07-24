import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CustomerManagementDatashowingComponent } from './customer-management-datashowing.component';

describe('CustomerManagementDatashowingComponent', () => {
  let component: CustomerManagementDatashowingComponent;
  let fixture: ComponentFixture<CustomerManagementDatashowingComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CustomerManagementDatashowingComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CustomerManagementDatashowingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
