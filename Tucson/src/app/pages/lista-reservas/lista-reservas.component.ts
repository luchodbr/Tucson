import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { IReserva } from 'src/app/models/ireserva';
import { ConfirmationService } from 'primeng/api';

@Component({
  selector: 'app-lista-reservas',
  templateUrl: './lista-reservas.component.html',
  styleUrls: ['./lista-reservas.component.scss'],
  providers: [ConfirmationService]
})
export class ListaReservasComponent implements OnInit {
  display: boolean = false;
  @Input() listReservas!: IReserva[]
  @Output() reservaToDelete = new EventEmitter<any>();
  @Output() openDialog = new EventEmitter<any>();


  constructor(private confirmationService: ConfirmationService) { }

  ngOnInit(): void {

  }


  onCancelReserva(reserva: number) {
    this.confirmationService.confirm({
      message: 'Si alguna reserva esta en espera, tomará su lugar ',
      accept: () => {
        this.reservaToDelete.emit(reserva);
      }
    });

  }

  onClickAdd() {
    this.openDialog.emit();
  }


}
