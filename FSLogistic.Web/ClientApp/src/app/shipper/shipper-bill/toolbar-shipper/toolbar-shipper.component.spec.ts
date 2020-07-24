import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ToolbarShipperComponent } from './toolbar-shipper.component';

describe('ToolbarShipperComponent', () => {
  let component: ToolbarShipperComponent;
  let fixture: ComponentFixture<ToolbarShipperComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ToolbarShipperComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ToolbarShipperComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
