import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { ratings } from '../Model/ratingsModel';

@Component({
  selector: 'app-movie-ratings',
  templateUrl: './movie-ratings.component.html',
  styleUrls: ['./movie-ratings.component.css']
})

export class MovieRatingsComponent implements OnInit{
  rating?: ratings;

  constructor(private Http: HttpClient) {
  }

  ngOnInit() {
    this.getRepos();
  }

  public getRepos() {
    return this.Http.get<ratings>('https://moviesminidatabase.p.rapidapi.com/movie/order/byRating/', { headers: new HttpHeaders().set("X-RapidAPI-Key","fceaf91701msh3ac4ecfd4674265p12c1adjsn80d2dab342fb").set("X-RapidAPI-Host","moviesminidatabase.p.rapidapi.com")})
    .subscribe({
      next:(response) => {
        console.log('odpowiedz otrzymana');
        this.rating = response;
        console.log(this.rating);
      },
      error: (error) => {
        console.log('blad');
        alert(error)
      },
      complete: () => {
        console.log('udalo sie!');
      }
    })
  }
}
