import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SearchDetailsComponent } from './components/search-details/search-details.component';

const routes: Routes = [
{ path: '', component: SearchDetailsComponent },
{ path: 'hero/:id', redirectTo: '/superhero/:id' }
// { path: 'superheroes',  component: SearchDetailsComponent, data: { animation: 'heroes' } },
// { path: 'superhero/:id', component: HeroDetailComponent, data: { animation: 'hero' } }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class NasaImageRoutingModule { }
