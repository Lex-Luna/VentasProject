import { Component } from '@angular/core';
import { ApiclienteService } from '../../Services/apicliente.service';
import { respuesta } from '../../Models/respuesta';

@Component({
  selector: 'app-cliente',
  standalone: true,
  imports: [],
  templateUrl: './cliente.component.html',
  styleUrl: './cliente.component.scss'
})
export class ClienteComponent {
  constructor(
    private apiCliente: ApiclienteService
  ){
      apiCliente.getCliente().subscribe( respuesta =>{
        console.log(respuesta);
      })
  }

}
