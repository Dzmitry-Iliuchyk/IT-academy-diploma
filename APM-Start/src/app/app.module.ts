import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { PersonComponent} from './products/person.component';
import { FormsModule } from '@angular/forms';
import { ConvertPipe } from './shared/convert.pipe';
import { HttpClientModule } from '@angular/common/http';
import { StarComponent } from './shared/star/star.component';


@NgModule({
  declarations: [
    AppComponent,
    PersonComponent,
    ConvertPipe,
    StarComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
