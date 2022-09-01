import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { AbstractControl, FormBuilder, Validators } from '@angular/forms';
import { ICliente } from 'src/app/models/icliente';
import { IReserva } from 'src/app/models/ireserva';

@Component({
  selector: 'app-create-reserva',
  templateUrl: './create-reserva.component.html',
  styleUrls: ['./create-reserva.component.scss']
})
export class CreateReservaComponent implements OnInit {
  @Input() listClientes!: ICliente[];
  @Output() reservaToCreate = new EventEmitter<IReserva>();
  selectedCliente!: ICliente;
  reservaForm = this.formBuilder.group({
    cliente: [null, [Validators.required]],
    fecha: ['', [Validators.required]],
    cantidad: [0, [Validators.required]]
  });

  constructor(private formBuilder: FormBuilder) { }

  ngOnInit(): void {
    this.selectedCliente = this.listClientes[0];
  }
  onSelectClient() {
    console.log(this.reservaForm.value);

  }
  crearReserva() {
    this.reservaToCreate.emit({ "nroCliente": this.f['cliente'].value.nroCliente, "fecha": this.f['fecha'].value, "cantidad": this.f['cantidad'].value } as IReserva)
    this.reservaForm.reset();
  }
  //hacer pipe de enumerado a Categoría 
  get f(): { [key: string]: AbstractControl } {
    return this.reservaForm.controls;
  }
  clearForm() {

  }

}
