import { Component, OnInit } from '@angular/core';
import { Alimento } from 'src/models/alimento';
import { AlimentoService } from 'src/services/alimento.service';

@Component({
  selector: 'app-alimentos',
  templateUrl: './alimentos.component.html',
  styleUrls: ['./alimentos.component.css']
})
export class AlimentosComponent implements OnInit {


  public alimentos:Alimento[] = [];

  constructor(
    private alimentoService: AlimentoService,
  ) { }

  ngOnInit(): void {
    this.getEventos();
  }

  public getEventos(): void{
    this.alimentoService.getAlimentos().subscribe({
      next: (alimentos:Alimento[]) => {
       this.alimentos = alimentos
       console.log( this.alimentos);

      //  this.eventosFiltrados = this.eventos
     },
      error: (error:any) => {
      //  this.spinner.hide();
      //  this.toastr.error('Erro ao carregar os eventos','Erro!')
      },
      // complete: () => this.spinner.hide()
   });

 }

}
