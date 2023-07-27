import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UsersideComponent } from './userside.component';

describe('UsersideComponent', () => {
  let component: UsersideComponent;
  let fixture: ComponentFixture<UsersideComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [UsersideComponent]
    });
    fixture = TestBed.createComponent(UsersideComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
