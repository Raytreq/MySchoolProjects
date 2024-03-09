import { Component, OnInit } from '@angular/core';
import { genres } from '../Model/genresModel';
import { HttpClient, HttpHeaders} from '@angular/common/http';

@Component({
  selector: 'app-all-genres',
  templateUrl: './all-genres.component.html',
  styleUrls: ['./all-genres.component.css']
})

export class AllGenresComponent implements OnInit{
  genre?: genres;

  constructor(private Http: HttpClient) {
  }

  ngOnInit() {
    this.getRepos();
  }

  public getRepos() {
    return this.Http.get<genres>('https://moviesminidatabase.p.rapidapi.com/genres/', {headers: new HttpHeaders().set("X-RapidAPI-Key","fceaf91701msh3ac4ecfd4674265p12c1adjsn80d2dab342fb").set("X-RapidAPI-Host","moviesminidatabase.p.rapidapi.com")} )
      .subscribe({
        next: (response) => {
          console.log('odpowiedz otrzymana');
          this.genre = response;
          console.log(this.genre);
        },
        error: (error) => {
          console.log('blad');
          alert(error)
        },
        complete: () => {
          console.log('Udalo sie!')
        }
      })
  }
}
