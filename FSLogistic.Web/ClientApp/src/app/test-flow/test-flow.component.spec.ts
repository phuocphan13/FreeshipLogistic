import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TestFlowComponent } from './test-flow.component';

describe('TestFlowComponent', () => {
  let component: TestFlowComponent;
  let fixture: ComponentFixture<TestFlowComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TestFlowComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TestFlowComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
