 export enum Prioridade{
    NaoDefinido = 'NaoDefinido',
    Baixa = 'Baixa',
    Normal = 'Normal',
    Alta = 'Alta'
 }
 
 
 
 export interface IAtividade {
    id: number;
    titulo: string;
    prioridade:string;
    descricao: string;
  }

  

