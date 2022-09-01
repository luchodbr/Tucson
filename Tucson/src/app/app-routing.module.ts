import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './pages/home/home.component';
import { ListaEsperaComponent } from './pages/lista-espera/lista-espera.component';
import { ListaReservasComponent } from './pages/lista-reservas/lista-reservas.component';

const routes: Routes = [
  { path: "", component: HomeComponent },
  { path: "listaReserva", component: ListaReservasComponent },
  { path: "listaEspera", component: ListaEsperaComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
