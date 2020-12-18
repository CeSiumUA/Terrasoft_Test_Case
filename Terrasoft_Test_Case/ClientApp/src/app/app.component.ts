import { Component } from '@angular/core';
import {Metrics} from './analyzer/metrics';
import {ServerAnalizerService} from "./analyzer/server-analizer.service";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  public textAreaNumberOfRows = 1;
  public useServerAnalyzer = true;
  public results: Metrics[] = [];
  public Text = '';
  public displayedColumns = ['metricsName', 'metricsResult'];
  constructor(private analyzerService: ServerAnalizerService) {}
  public onInput(event: any): void{
    this.analyzerService.getMetrics(this.Text).subscribe(x => {
      this.results = x;
    });
    this.autoResizeTextBox(event);
  }
  private autoResizeTextBox(event: any): void{
    this.textAreaNumberOfRows = Math.floor(event.target.scrollHeight / 15);
    event.target.rows = this.textAreaNumberOfRows;
  }
}
