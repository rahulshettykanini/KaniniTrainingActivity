import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DeleteshipsComponent } from './deleteships.component';

describe('DeleteshipsComponent', () => {
  let component: DeleteshipsComponent;
  let fixture: ComponentFixture<DeleteshipsComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [DeleteshipsComponent]
    });
    fixture = TestBed.createComponent(DeleteshipsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
