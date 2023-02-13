import { FormControl, InputGroup, Button } from 'react-bootstrap';
import TitlePage from '../../components/TitlePage';
import React, { useState } from 'react';
import { useNavigate } from 'react-router-dom';


const clientes = [
  {
    id: 1,
    nome: 'Microsoft',
    responsavel: 'Otto',
    contato: '876675544',
    situacao: 'Ativo'
  },
  {
    id: 2,
    nome: 'Apple',
    responsavel: 'Carlos',
    contato: '886675544',
    situacao: 'Ativo'
  },
  {
    id: 3,
    nome: 'Amazon',
    responsavel: 'Jean',
    contato: '406675544',
    situacao: 'Em análise'
  },
  {
    id: 4,
    nome: 'Samsung',
    responsavel: 'Xien',
    contato: '886675544',
    situacao: 'desativado'
  },
  {
    id: 5,
    nome: 'Xiaomi',
    responsavel: 'Honda',
    contato: '556675544',
    situacao: 'desativado'
  },
]
const ClienteLista =()=> {
  const navigate = useNavigate();
  const [termoBusca, setTermoBusca] = useState('');

  const handleInputChange = (e: React.ChangeEvent<HTMLInputElement>) =>{
    setTermoBusca(e.target.value);    
  }

  const clientesFiltrados = clientes.filter((cliente) => {
    
    return  (
      Object.values(cliente).join(' ').toLowerCase().includes(termoBusca.toLowerCase())
    );

  });

  const novoCliente = () => {
    navigate('/cliente/detalhe')
  }


  return (
    <>
        <TitlePage title='Lista de Clientes'>
          <Button variant="outline-secondary" onClick={novoCliente}>
            <i className="fas fa-plus me-2"></i>
            Novo Cliente
          </Button>
        </TitlePage>
        <InputGroup className='mt-3 mb-3'>
          <InputGroup.Text>Buscar:</InputGroup.Text>
          <FormControl
            onChange={handleInputChange}
            placeholder='pesquisar...'
          />
        </InputGroup>
        <table className='table table-striped table-hover'>
        <thead className='table-dark mt-3'>
          <tr>
            <th scope="col">#</th>
            <th scope="col">Nome</th>
            <th scope="col">Responsável</th>
            <th scope="col">Contato</th>
            <th scope="col">Situação</th>
            <th scope="col">Opções</th>
          </tr>
        </thead>
        <tbody>
          {clientesFiltrados.map((cliente) => (
             <tr key={cliente.id}>
               <td>{cliente.id}</td>
               <td>{cliente.nome}</td>
               <td>{cliente.responsavel}</td>
               <td>{cliente.contato}</td>
               <td>{cliente.situacao}</td>

               <td>
                <div>
                  <button className="btn btn-sm btn-outline-primary me-2" onClick={() => navigate(
                    `/cliente/detalhe/${cliente.id}`
                  )}>
                    <i className="fas fa-user-edit me-2"></i>
                    Editar
                  </button>
                  <button className="btn btn-sm btn-outline-danger me-2">
                    <i className="fas fa-user-times me-2"></i>
                    Desativar
                  </button>
                </div>
               </td>
             </tr>
          ))}
        </tbody>
      </table>
    </>
  )
}


export default ClienteLista;