import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ShipperBillComponent } from './shipper-bill.component';

describe('ShipperBillComponent', () => {
  let component: ShipperBillComponent;
  let fixture: ComponentFixture<ShipperBillComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ShipperBillComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ShipperBillComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
