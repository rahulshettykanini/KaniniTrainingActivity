import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SeecustomersComponent } from './seecustomers.component';

describe('SeecustomersComponent', () => {
  let component: SeecustomersComponent;
  let fixture: ComponentFixture<SeecustomersComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [SeecustomersComponent]
    });
    fixture = TestBed.createComponent(SeecustomersComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
