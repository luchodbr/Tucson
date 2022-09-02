import { Component, OnInit } from '@angular/core';
import { MessageService } from 'primeng/api';
import { ICliente } from 'src/app/models/icliente';
import { IEspera } from 'src/app/models/iespera';
import { IReserva } from 'src/app/models/ireserva';
import { TucsonService } from 'src/app/services/tucson.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss'],
  providers: [MessageService]
})
export class HomeComponent implements OnInit {
  listReservas!: IReserva[];
  listEspera!: IEspera[];
  listClientes!: ICliente[];
  display: boolean = false;

  showDialog() {
    this.display = true;
  }
  constructor(private tucsonServ: TucsonService, private messageService: MessageService) { }

  ngOnInit(): void {
    this.refreshList();
    this.refreshListEspera();
    this.refreshListClientes();
  }
  refreshList() {
    this.tucsonServ.GetReservas().subscribe(c => {
      this.listReservas = c as IReserva[];
      console.info(this.listReservas);

    })
  }
  refreshListEspera() {
    this.tucsonServ.GetEsperas().subscribe(c => {
      this.listEspera = c as IEspera[];
      console.info(this.listEspera);

    })
  }
  refreshListClientes() {
    this.tucsonServ.GetClientes().subscribe(c => {
      this.listClientes = c as ICliente[];
      console.info(this.listEspera);

    })
  }
  createReserva(reserva: IReserva) {
    this.tucsonServ.Post(reserva).subscribe(c => {
      this.showToast("success", "Successfull", "Se creó con exito");
      this.refreshList();
      this.refreshListEspera();
      this.display = false;
    });

  }
  deleteReserva(id: number) {
    this.tucsonServ.Delete(id).subscribe(c => {
      this.showToast("success", "Successfull", "Se borró con exito");
      this.refreshList();
      this.refreshListEspera();
    });
  }
  showToast(severity: string, summary: string, detail: string) {
    this.messageService.add({ severity: severity, key: 'tr', summary: summary, detail: detail });
  }
}
