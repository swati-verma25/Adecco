import { TestBed } from '@angular/core/testing';
import { RouterTestingModule } from '@angular/router/testing';
import { DetailModalComponent } from './detail-modal.component';

describe('DetailModalComponent', () => {
  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [
        RouterTestingModule
      ],
      declarations: [
        DetailModalComponent
      ],
    }).compileComponents();
  });

  it('should create the app', () => {
    const fixture = TestBed.createComponent(DetailModalComponent);
    const app = fixture.componentInstance;
    expect(app).toBeTruthy();
  });

  it(`should have as title 'adecco-app'`, () => {
    const fixture = TestBed.createComponent(DetailModalComponent);
    const app = fixture.componentInstance;
    expect(app.title).toEqual('adecco-app');
  });

  it('should render title', () => {
    const fixture = TestBed.createComponent(DetailModalComponent);
    fixture.detectChanges();
    const compiled = fixture.nativeElement as HTMLElement;
    expect(compiled.querySelector('.content span')?.textContent).toContain('adecco-app app is running!');
  });
});
