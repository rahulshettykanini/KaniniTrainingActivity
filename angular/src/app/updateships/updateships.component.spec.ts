import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdateshipsComponent } from './updateships.component';

describe('UpdateshipsComponent', () => {
  let component: UpdateshipsComponent;
  let fixture: ComponentFixture<UpdateshipsComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [UpdateshipsComponent]
    });
    fixture = TestBed.createComponent(UpdateshipsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
