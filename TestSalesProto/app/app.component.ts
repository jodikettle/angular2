import { Component } from '@angular/core';

@Component({
    selector: 'sales-app',
    template: `
      <main class="bd-pageheader">
        <div class="container">
            <h1>This is the header</h1>
        </div>
      </main>
      <div class="container">
        <charts-section class="col-md-12"></charts-section>
      </div>
      <footer class="footer">
        <div class="container">
          <p>This is the footer</p>
        </div>
      </footer>
      `
})
export class DemoComponent {
}