import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AllGenresComponent } from './all-genres/all-genres.component';
import { MoviesComponent } from './movies/movies.component';
import { MovieRatingsComponent } from './movie-ratings/movie-ratings.component';

const routes: Routes = [
  {path: 'all-genres', component: AllGenresComponent},
  {path: 'movie-rating', component: MovieRatingsComponent},
  {path: 'movies', component: MoviesComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
