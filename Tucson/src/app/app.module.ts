import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './pages/home/home.component';
import { HttpClientModule } from '@angular/common/http'
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DialogModule } from 'primeng/dialog';
import { ListaEsperaComponent } from './pages/lista-espera/lista-espera.component';
import { ListaReservasComponent } from './pages/lista-reservas/lista-reservas.component';
import { CreateReservaComponent } from './pages/create-reserva/create-reserva.component';
import { ButtonModule } from 'primeng/button';
import { CategoriaEnumPipe } from './categoria-enum.pipe';
import { Toast, ToastModule } from 'primeng/toast';
import { CalendarModule } from 'primeng/calendar';
import { ConfirmDialogModule } from 'primeng/confirmdialog';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    ListaEsperaComponent,
    ListaReservasComponent,
    CreateReservaComponent,
    CategoriaEnumPipe
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    BrowserAnimationsModule,
    DialogModule,
    ButtonModule,
    ReactiveFormsModule,
    ToastModule,
    CalendarModule,
    ConfirmDialogModule

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
