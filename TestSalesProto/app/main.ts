import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { DemoModule } from './app.module.js';

import '../node_modules/chart.js/dist/Chart.bundle.min.js';

platformBrowserDynamic().bootstrapModule(DemoModule);
