import { Component } from '@angular/core';

let name = 'Charts';
let src = 'https://github.com/valor-software/ng2-charts/blob/master/components/charts/charts.ts';
// webpack html imports

let chartDesc: Array<any> = [
    {
        heading: 'Line Chart',
        tag: 'line-chart-demo',
        id: 'lineChart'
    }
];

let chartContent: string = ``;
chartDesc.forEach((desc: any, index: number) => {
    chartContent += `
      <section id="${desc.id}" style="padding-top: 50px;">
        <div class="row">
          <div class="col-md-12">
            <h4>${desc.heading}</h4>
          </div>
        </div>
        <div class="card card-block panel panel-default panel-body">

         <div class="row">
          <div *ngIf="'${desc.heading}' == 'Line Chart' || '${desc.heading}' == 'Dynamic Chart'">
            <div class="col-md-12">
              <${desc.tag}></${desc.tag}>
            </div>
          </div>
          <div *ngIf="'${desc.heading}' != 'Line Chart' && '${desc.heading}' != 'Dynamic Chart'">
            <div class="col-md-12">
              <${desc.tag}></${desc.tag}>
            </div>
          </div>
        </div>
      </div>
      <div class="row">
        <div class="col-md-12">
        </div>
      </div>
    </section>
  `;
});

@Component({
    selector: 'charts-section',
    template: `
    <section id="${name.toLowerCase()}">
      <div class="row">
        ${chartContent}
      </div>
      <br>
    </section>
  `
})

export class ChartsSectionComponent {
    public chartDesc: any[] = chartDesc;
}