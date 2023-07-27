import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShipstationsComponent } from './shipstations.component';

describe('ShipstationsComponent', () => {
  let component: ShipstationsComponent;
  let fixture: ComponentFixture<ShipstationsComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ShipstationsComponent]
    });
    fixture = TestBed.createComponent(ShipstationsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
