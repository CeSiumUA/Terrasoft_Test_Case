import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  public textAreaNumberOfRows = 1;
  public useServerAnalyzer = true;
  constructor() {
  }
  public autoResizeTextBox(event: any): void{
    this.textAreaNumberOfRows = Math.floor(event.target.scrollHeight / 15);
    event.target.rows = this.textAreaNumberOfRows;
  }
}
