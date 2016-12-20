import { NgModule } from '@angular/core';
import { ChartsModule } from 'ng2-charts';
import { BrowserModule } from '@angular/platform-browser';

import { ChartsSectionComponent } from './charts-section.js';
import { LineChartDemoComponent } from './charts/line-chart-demo.js';
import { TabsModule, CollapseModule, DropdownModule } from 'ng2-bootstrap';

import { DemoComponent } from './app.component.js';

@NgModule({
    bootstrap: [DemoComponent],
    declarations: [
        DemoComponent,
        ChartsSectionComponent,
        LineChartDemoComponent,
    ],
    imports: [
        BrowserModule,
        ChartsModule,
        TabsModule,
        CollapseModule,
        DropdownModule
    ]
})

export class DemoModule { }
