import { Component, Input, OnInit } from '@angular/core';
import { IEspera } from 'src/app/models/iespera';
import { TucsonService } from 'src/app/services/tucson.service';

@Component({
  selector: 'app-lista-espera',
  templateUrl: './lista-espera.component.html',
  styleUrls: ['./lista-espera.component.scss']
})
export class ListaEsperaComponent implements OnInit {

  display: boolean = false;
  @Input() listEspera!: IEspera[]
  showDialog() {
    this.display = true;
  }
  constructor(private tucsonServ: TucsonService) { }

  ngOnInit(): void {
    this.refreshList();
  }
  refreshList() {
    this.tucsonServ.GetEsperas().subscribe(c => {
      this.listEspera = c as IEspera[];
      console.info(this.listEspera);

    })
  }
}
