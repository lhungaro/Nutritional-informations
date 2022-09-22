import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { AlimentosComponent } from './alimentos/alimentos.component';
import { AlimentoService } from 'src/services/alimento.service';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    AlimentosComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
  ],
  providers: [AlimentoService],
  bootstrap: [AppComponent]
})
export class AppModule { }
