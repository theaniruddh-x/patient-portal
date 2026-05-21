import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PatientChart } from './patient-chart';

describe('PatientChart', () => {
  let component: PatientChart;
  let fixture: ComponentFixture<PatientChart>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [PatientChart],
    }).compileComponents();

    fixture = TestBed.createComponent(PatientChart);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
