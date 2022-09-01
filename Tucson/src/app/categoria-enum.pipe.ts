import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'categoriaEnum'
})
export class CategoriaEnumPipe implements PipeTransform {

  transform(value: number, categoria = ''): string {
    switch (value) {
      case 0:
        return "Diamond"
      case 2:
        return "Classic"
      case 3:
        return "Gold"
      case 4:
        return "Platinum"
      default:
        return ""

    };
  }

}
