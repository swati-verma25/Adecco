import { TestBed } from '@angular/core/testing';
import { RouterTestingModule } from '@angular/router/testing';
import { SearchDetailsComponent } from './search-details.component';

describe('SearchDetailsComponent', () => {
  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [
        RouterTestingModule
      ],
      declarations: [
        SearchDetailsComponent
      ],
    }).compileComponents();
  });

  it('should create the app', () => {
    const fixture = TestBed.createComponent(SearchDetailsComponent);
    const app = fixture.componentInstance;
    expect(app).toBeTruthy();
  });

  it(`should have as title 'adecco-app'`, () => {
    const fixture = TestBed.createComponent(SearchDetailsComponent);
    const app = fixture.componentInstance;
    expect(app.title).toEqual('adecco-app');
  });

  it('should render title', () => {
    const fixture = TestBed.createComponent(SearchDetailsComponent);
    fixture.detectChanges();
    const compiled = fixture.nativeElement as HTMLElement;
    expect(compiled.querySelector('.content span')?.textContent).toContain('adecco-app app is running!');
  });
});
