import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ToolbarAdminComponent } from './toolbar-admin.component';

describe('ToolbarAdminComponent', () => {
  let component: ToolbarAdminComponent;
  let fixture: ComponentFixture<ToolbarAdminComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ToolbarAdminComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ToolbarAdminComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
