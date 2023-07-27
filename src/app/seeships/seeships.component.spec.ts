import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SeeshipsComponent } from './seeships.component';

describe('SeeshipsComponent', () => {
  let component: SeeshipsComponent;
  let fixture: ComponentFixture<SeeshipsComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [SeeshipsComponent]
    });
    fixture = TestBed.createComponent(SeeshipsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
