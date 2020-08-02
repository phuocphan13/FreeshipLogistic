import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminBillDatashowingComponent } from './admin-bill-datashowing.component';

describe('AdminBillDatashowingComponent', () => {
  let component: AdminBillDatashowingComponent;
  let fixture: ComponentFixture<AdminBillDatashowingComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AdminBillDatashowingComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AdminBillDatashowingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
