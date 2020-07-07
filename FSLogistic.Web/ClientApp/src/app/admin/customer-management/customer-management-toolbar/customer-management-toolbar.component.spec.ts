import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CustomerManagementToolbarComponent } from './customer-management-toolbar.component';

describe('CustomerManagementToolbarComponent', () => {
  let component: CustomerManagementToolbarComponent;
  let fixture: ComponentFixture<CustomerManagementToolbarComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CustomerManagementToolbarComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CustomerManagementToolbarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
