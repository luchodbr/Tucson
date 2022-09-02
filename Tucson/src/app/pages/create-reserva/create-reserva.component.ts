import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { AbstractControl, FormBuilder, Validators } from '@angular/forms';
import { max } from 'rxjs';
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
  reservaForm = this.formBuilder.group({
    cliente: [null, [Validators.required]],
    fecha: ['', [Validators.required]],
    cantidad: [0, [Validators.required]]
  });
  minDateValue: Date;
  maxDateValue: Date;

  constructor(private formBuilder: FormBuilder) {
    this.minDateValue = new Date(Date.now());
    this.maxDateValue = new Date(Date.now());
  }

  ngOnInit(): void {

  }
  onSelectClient() {
    this.maxDateValue.setFullYear(this.minDateValue.getFullYear());
    this.maxDateValue.setMonth(this.minDateValue.getMonth());
    if (this.f['cliente'].value.categoria == 0) {
      this.maxDateValue.setDate(this.minDateValue.getDate() + 365)
    }
    else {
      this.maxDateValue.setDate(this.minDateValue.getDate() + this.f['cliente'].value.categoria - 1);
    }
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
