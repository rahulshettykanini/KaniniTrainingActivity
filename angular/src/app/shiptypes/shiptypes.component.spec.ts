import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShiptypesComponent } from './shiptypes.component';

describe('ShiptypesComponent', () => {
  let component: ShiptypesComponent;
  let fixture: ComponentFixture<ShiptypesComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ShiptypesComponent]
    });
    fixture = TestBed.createComponent(ShiptypesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
