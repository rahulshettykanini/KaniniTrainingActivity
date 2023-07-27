import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DeletecustomersComponent } from './deletecustomers.component';

describe('DeletecustomersComponent', () => {
  let component: DeletecustomersComponent;
  let fixture: ComponentFixture<DeletecustomersComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [DeletecustomersComponent]
    });
    fixture = TestBed.createComponent(DeletecustomersComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
