import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AllshipsComponent } from './allships.component';

describe('AllshipsComponent', () => {
  let component: AllshipsComponent;
  let fixture: ComponentFixture<AllshipsComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AllshipsComponent]
    });
    fixture = TestBed.createComponent(AllshipsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
