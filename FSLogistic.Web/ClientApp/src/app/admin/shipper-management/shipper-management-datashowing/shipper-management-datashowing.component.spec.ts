import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ShipperManagementDatashowingComponent } from './shipper-management-datashowing.component';

describe('ShipperManagementDatashowingComponent', () => {
  let component: ShipperManagementDatashowingComponent;
  let fixture: ComponentFixture<ShipperManagementDatashowingComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ShipperManagementDatashowingComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ShipperManagementDatashowingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
