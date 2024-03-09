import { Component, OnInit } from '@angular/core';
import { movies } from '../Model/moviesModel';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Component({
  selector: 'app-movies',
  templateUrl: './movies.component.html',
  styleUrls: ['./movies.component.css']
})

export class MoviesComponent implements OnInit{
  movie?: movies;

  constructor(private Http: HttpClient) {
  }

  ngOnInit() {
    this.getRepos();
  }

  public getRepos() {
    return this.Http.get<movies>("https://moviesminidatabase.p.rapidapi.com/movie/byYear/2018/", {headers: new HttpHeaders().set("X-RapidAPI-Key","fceaf91701msh3ac4ecfd4674265p12c1adjsn80d2dab342fb").set("X-RapidAPI-Host","moviesminidatabase.p.rapidapi.com")})
    .subscribe({
      next: (response) => {
        console.log('odpowiedz otrzymana');
        this.movie = response;
        console.log(this.movie);
      },
      error: (error) => {
        console.log('blad');
        alert(error);
      },
      complete: () => {
        console.log('udalo sie!')
      }
    })
  }
}
