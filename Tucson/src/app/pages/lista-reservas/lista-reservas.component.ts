import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { IReserva } from 'src/app/models/ireserva';
@Component({
  selector: 'app-lista-reservas',
  templateUrl: './lista-reservas.component.html',
  styleUrls: ['./lista-reservas.component.scss']
})
export class ListaReservasComponent implements OnInit {
  display: boolean = false;
  @Input() listReservas!: IReserva[]
  @Output() reservaToDelete = new EventEmitter<any>();
  @Output() openDialog = new EventEmitter<any>();


  constructor() { }

  ngOnInit(): void {

  }

  onCancelReserva(reserva: number) {
    this.reservaToDelete.emit(reserva);
  }

  onClickAdd() {
    this.openDialog.emit();
  }


}
