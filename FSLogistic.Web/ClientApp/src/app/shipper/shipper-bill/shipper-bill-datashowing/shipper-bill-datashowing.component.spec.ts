import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ShipperBillDatashowingComponent } from './shipper-bill-datashowing.component';

describe('ShipperBillDatashowingComponent', () => {
  let component: ShipperBillDatashowingComponent;
  let fixture: ComponentFixture<ShipperBillDatashowingComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ShipperBillDatashowingComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ShipperBillDatashowingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
