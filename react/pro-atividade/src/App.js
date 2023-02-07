import {useState} from 'react';
import AtividadeForm from './components/AtividadeForm';
import AtividadesLista  from './components/AtividadesLista';
import './App.css';

let initialState = [
    {
       id: 1,
       prioridade: '1',
       titulo: 'teste',
       descricao: 'Primeira atividade',
    },
    {
      id: 2,
      prioridade: '2',
      titulo: 'teste',
      descricao: 'Segunda atividade',
   },
   {
    id: 3,
    prioridade: '3',
    titulo: 'teste',
    descricao: 'Terceira atividade',
    }
  ];



function App() {
  const [atividades, setAtividades] = useState(initialState)


  function addAtividade(e){
    e.preventDefault();


    const atividade = {      
        id: document.getElementById('id').value,
        prioridade: document.getElementById('prioridade').value,
        titulo: document.getElementById('titulo').value,
        descricao: document.getElementById('descricao').value,
    }
   
     setAtividades([...atividades, {...atividade}]);
  }
    
  function deletarAtividade(id){
    const atividadesFiltradas = atividades.filter(atividade => atividade.id !== id);
    setAtividades([...atividadesFiltradas]);
  }
  
 

  return (
    <>
      <AtividadeForm 
        addAtividade={addAtividade}
        atividades={atividades}
      />
       <AtividadesLista
          atividades={atividades}
          deletarAtividade = {deletarAtividade}
       />  
    </>     
  );
}

export default App;
