# Documentação do Sistema "Proatividade"

Esta documentação fornece um guia passo a passo para instalar e executar o sistema "Proatividade", um aplicativo baseado no Trello que permite adicionar, verificar, alterar e adicionar atividades. O sistema é composto por um frontend desenvolvido em React com TypeScript e Bootstrap, e um backend que consiste em uma API em .NET 6 utilizando Entity Framework, AutoMapper, Swagger para testes, Routing, Authorization e Authentication.

## Requisitos

Certifique-se de ter as seguintes ferramentas instaladas em sua máquina antes de prosseguir:

### Frontend

- Node.js (versão 12 ou superior)
- npm (gerenciador de pacotes do Node.js)

### Backend

- .NET 6 SDK (versão 6.0 ou superior)
- Visual Studio Code (ou outra IDE de sua preferência)

## Passo a Passo de Instalação e Execução da API

Siga as etapas abaixo para instalar e executar a API do sistema "Proatividade":

1. Clone o repositório do projeto:
   ```
   git clone <URL do repositório>
   ```

2. Acesse o diretório do projeto:
   ```
   cd <nome do diretório>/backend
   ```

3. Abra o diretório `backend` em sua IDE de preferência (ex: Visual Studio Code).

4. Restaure as dependências do projeto executando o seguinte comando no terminal:
   ```
   dotnet restore
   ```

5. Execute o comando abaixo para iniciar a API:
   ```
   dotnet run
   ```


6. Para acessar a documentação da API (Swagger), acesse `https://localhost:5001/swagger`.

Parabéns! Você instalou e iniciou a API do sistema "Proatividade" com sucesso.

## Passo a Passo de Instalação e Execução do Frontend

Siga as etapas abaixo para instalar e executar o frontend do sistema "Proatividade":

1. Acesse o diretório do projeto:
   ```
   cd <nome do diretório>/frontend
   ```

2. Instale as dependências do projeto utilizando o npm:
   ```
   npm install
   ```

3. Execute o comando abaixo para iniciar o frontend:
   ```
   npm start
   ```

4. O aplicativo será executado em `http://localhost:3000`.

Parabéns! Você instalou e iniciou o frontend do sistema "Proatividade" com sucesso.

## Estrutura do Projeto (Frontend)

A estrutura do projeto frontend é organizada da seguinte maneira:

- `public`: Contém as imagens utilizadas no sistema.
- `src`: Pasta raiz do projeto.
  - `API`: Contém a configuração do Axios para comunicação com a API backend.
  - `components`: Contém os componentes reutilizáveis do sistema, como o menu e o título da página.
  - `model`: Contém a interface `IAtividade` e `atividadeProps` (hook personalizado).
  - `pages`: Contém os componentes separados por atividades, clientes e dashboard.
  - `notfound`: Página exibida ao usuário caso a página não exista.
  - `app.tsx`: Arquivo com as rotas de cada página.
  - `index.tsx`: Arquivo que renderiza todo o sistema.

## Conclusão

O sistema "Proatividade" é uma aplicação baseada no Trello que permite gerenciar atividades, verificar o status, alterar e adicionar novas atividades. O frontend é desenvolvido em React com TypeScript e Bootstrap, enquanto o backend consiste em uma API .NET 6 utilizando Entity Framework, AutoMapper, Swagger, Routing, Authorization e Authentication.

Você pode explorar e personalizar o sistema "Proatividade" de acordo com suas necessidades, adicionando recursos adicionais, melhorando a interface do usuário e estendendo a funcionalidade.

Divirta-se desenvolvendo e usando o sistema "Proatividade"!
