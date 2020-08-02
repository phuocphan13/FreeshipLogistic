import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdateCustomerModalComponent } from './update-customer-modal.component';

describe('UpdateCustomerModalComponent', () => {
  let component: UpdateCustomerModalComponent;
  let fixture: ComponentFixture<UpdateCustomerModalComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UpdateCustomerModalComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UpdateCustomerModalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
