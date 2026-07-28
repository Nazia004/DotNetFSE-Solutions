import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CoursePipes } from './course-pipes';

describe('CoursePipes', () => {
  let component: CoursePipes;
  let fixture: ComponentFixture<CoursePipes>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CoursePipes],
    }).compileComponents();

    fixture = TestBed.createComponent(CoursePipes);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
