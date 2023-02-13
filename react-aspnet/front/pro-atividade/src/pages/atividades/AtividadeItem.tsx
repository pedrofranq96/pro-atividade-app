import React from "react";

import { Prioridade } from "../../model/IAtividade";
import { AtividadeItemProps } from './../../model/atividadeProps';




const AtividadeItem: React.FC<AtividadeItemProps> =({
  ativ,
  pegarAtividade,
  handleConfirmModal
  }: AtividadeItemProps
) => {
    function prioridadeLabel(param: string){
        switch(param){
          case Prioridade.Baixa:
          case Prioridade.Normal:
          case Prioridade.Alta:
            return param;
          default:
            return 'Nao definido';
        }
      }

      function prioridadeStyle(param: string, icone: boolean){
          switch(param){
            case Prioridade.Baixa:
              return icone ? 'smile': 'success';
            case Prioridade.Normal:
              return icone ? 'meh': 'dark';
            case Prioridade.Alta:
              return icone ? 'frown' : 'danger';
            default:
              return 'Nao definido';
          }
      }

    return (
        <div  className={"card mb-2 shadow-sm border-" + prioridadeStyle(ativ.prioridade, false)}>
                    
            <div className="card-body">
            <div className="d-flex justify-content-between">
                <h6 className="card-title">
                <span className="badge text-bg-secondary me-1">{ativ.id} </span>
                - {ativ.titulo}</h6>
                <h6>Prioridade: 
                <span className={"ms-1 text-" + prioridadeStyle(ativ.prioridade, false)}>
                    <i className={"me-1 far fa-" + prioridadeStyle(ativ.prioridade, true)}></i>
                    {prioridadeLabel(ativ.prioridade)}
                </span>                        
                </h6>
            </div>
            <p className="card-text">{ativ.descricao}</p>
            <div className="d-flex justify-content-end pt-2 m-0 border-top">
                <button 
                  className="btn btn-sm btn-outline-primary me-2 "
                  onClick={()=> pegarAtividade(ativ.id)}>
                  <i className="fas fa-pen me-2"></i>
                  Editar
                </button>
                <button 
                  className="btn btn-sm btn-outline-danger" 
                  onClick={() => handleConfirmModal(ativ.id)}>
                  <i className="fas fa-trash me-2"></i>
                  Remover</button>
            </div>
            </div>
    </div>);
}

export default AtividadeItem;