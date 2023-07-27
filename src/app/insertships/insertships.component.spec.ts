import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InsertshipsComponent } from './insertships.component';

describe('InsertshipsComponent', () => {
  let component: InsertshipsComponent;
  let fixture: ComponentFixture<InsertshipsComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [InsertshipsComponent]
    });
    fixture = TestBed.createComponent(InsertshipsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
