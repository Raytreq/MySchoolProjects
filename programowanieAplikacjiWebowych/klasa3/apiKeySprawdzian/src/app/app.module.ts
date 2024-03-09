import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AllGenresComponent } from './all-genres/all-genres.component';
import { MoviesComponent } from './movies/movies.component';
import { MovieRatingsComponent } from './movie-ratings/movie-ratings.component';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    AllGenresComponent,
    MoviesComponent,
    MovieRatingsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
