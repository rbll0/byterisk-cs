# ByteRisk - Redução de Sinistros Odontológicos

## Visão Geral do Projeto

O projeto **ByteRisk** visa reduzir o número de sinistros odontológicos para a **OdontoPrev** utilizando machine learning e uma estrutura robusta de gestão de beneficiários e sinistros. A aplicação categoriza beneficiários em rankings de risco com base em seu histórico e outros fatores, ajudando a prever e evitar sinistros de alto custo. Nesta Sprint 2, a interface da aplicação foi expandida para oferecer uma camada web intuitiva, layouts personalizáveis e uma navegação facilitada com **Bootstrap**. Além disso, funcionalidades principais foram adicionadas com **Views**, **Controllers** e **ViewModels** que integram a lógica de negócio e validações da aplicação.

## Escopo do Projeto

O projeto envolve o desenvolvimento de um sistema de gestão para a OdontoPrev, integrando as seguintes funcionalidades:

- **Cadastro e Gerenciamento de Beneficiários**: Inclusão, atualização e exclusão de dados de beneficiários.
- **Gestão de Consultas**: Agendamento, atualização e consulta de histórico de consultas de beneficiários.
- **Gestão de Exames**: Cadastramento de exames e seus resultados.
- **Gestão de Sinistros**: Registro e análise de sinistros para identificar padrões de risco.
- **Integração com Modelos de Machine Learning**: Implementação de um sistema de predição de risco para classificar beneficiários.
- **Interface Web com ASP.NET Core MVC**: Uma aplicação web com layouts, navegação, validações e gerenciamento de dados por meio de Views e Controllers.
- **API RESTful**: API para integração com sistemas externos e comunicação via endpoints documentados com Swagger.

## Requisitos Funcionais

- O sistema deve permitir a criação, atualização, consulta e exclusão de beneficiários.
- O sistema deve registrar e gerenciar consultas e exames dos beneficiários.
- O sistema deve permitir a integração com algoritmos de machine learning para predição de risco.
- A aplicação deve ser acessada via interface web e API REST, com rotas bem definidas e documentadas via Swagger.

## Requisitos Não Funcionais

- A aplicação deve seguir princípios de **Clean Architecture**, garantindo fácil manutenção e evolução.
- A aplicação web deve usar um layout responsivo e amigável com **Bootstrap**.
- A API deve ter uma documentação clara e completa via **Swagger**.
- A aplicação deve ser escalável e de alta disponibilidade.
- A persistência dos dados deve ser garantida por meio de transações ACID em um banco de dados **Oracle**.
- A comunicação entre sistemas deve ser segura e eficiente.

## Desenho da Arquitetura

O projeto foi estruturado com base nos princípios da **Clean Architecture**, garantindo o desacoplamento entre as camadas e facilitando a manutenção.

### Camadas da Aplicação

1. **Apresentação**
    - Camada responsável por expor as funcionalidades da aplicação via API REST e Views com ASP.NET Core MVC.
    - **Pasta**: `Presentation/Controller`

2. **Aplicação**
    - Implementa regras de aplicação e orquestra o fluxo de dados entre as camadas de apresentação e domínio.
    - **Pasta**: `Application/Services`, `Application/Dtos`, `Application/ViewModels`

3. **Domínio**
    - Contém os modelos e regras de negócio, independente de tecnologias externas.
    - **Pasta**: `Domain/Entities`, `Domain/Interfaces`

4. **Infraestrutura**
    - Responsável pela persistência dos dados, implementação de repositórios e integração com APIs externas e o banco de dados Oracle.
    - **Pasta**: `Infrastructure/Data`, `Infrastructure/Repository`

## Tecnologias Utilizadas

- **C#** e **.NET Core** para o backend.
- **Entity Framework Core** para mapeamento de objetos para o banco de dados.
- **Oracle Database** para armazenamento de dados.
- **Swagger** para documentação da API.
- **Bootstrap** para o layout responsivo da interface web.
- **Postman** para testes manuais dos endpoints.

## Estrutura de Pastas

```bash
ByteRisk
├── Application
│   ├── Dtos         # Transferência de dados entre camadas
│   ├── Interfaces   # Interfaces para serviços de aplicação
│   ├── Services     # Implementação dos serviços
│   └── ViewModels   # ViewModels para a camada de apresentação
├── Domain
│   ├── Entities     # Entidades de domínio
│   └── Interfaces   # Interfaces do domínio
├── Infrastructure
│   ├── Data         # Contexto de banco de dados e mapeamento
│   └── Repository   # Repositórios de acesso aos dados
├── Presentation
│   ├── Controllers  # Controladores REST e MVC da API e Views
│   ├── Views        # Views para as funcionalidades principais com validações
│   └── Layouts      # Layout principal com cabeçalho, rodapé e navegação
└── README.md
```
## Equipe do Projeto

- **Gustavo Rabelo Frere** - RM 553326
- **Marcelo Vieira Juniro** - RM 553640
- **Felipe Arcanjo Matos dos Santos** - RM 554018

## Link do YouTube

[Apresentação do Projeto ByteRisk](https://teams.microsoft.com/l/message/48:notes/1728275411912?context=%7B%22contextType%22%3A%22chat%22%7D)

## Instruções de Instalação e Configuração

### Clonar o repositório:
```bash
git clone https://github.com/rbll0/byterisk-cs.git
cd byterisk-cs
```
### Configurar a string de conexão:
```bash
"ConnectionStrings": {
    "DefaultConnection": "User Id=rm553326;Password=091003;Data Source=oracle.fiap.com.br:1521/orcl"
}
```
### Rodar as migrações:
```bash
dotnet ef database update
```
### Compilar e rodar o projeto:
```bash
dotnet run
```
### Acessar a aplicação:
```bash
A aplicação estará disponível em http://localhost:5000.
```

## Documentação Swagger: 
```bash
A documentação da API pode ser acessada em http://localhost:5000/swagger.
```
