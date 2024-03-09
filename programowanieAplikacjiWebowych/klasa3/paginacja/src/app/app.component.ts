import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent{
  title = 'Projekt1_II';
  home = true;

  ListChange()
  {
    this.home = false;
  }

  HomeChange()
  {
    this.home = true;
  }
}
