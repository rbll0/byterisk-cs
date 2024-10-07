# ByteRisk - Redução de Sinistros Odontológicos

## Objetivo do Projeto
O projeto **ByteRisk** tem como objetivo principal reduzir o número de sinistros odontológicos para a **OdontoPrev** utilizando machine learning. O sistema categoriza beneficiários em rankings de risco com base em seu histórico de consultas, exames, sinistros e outros fatores, ajudando a prever e evitar sinistros de alto custo. Além disso, o sistema automatiza o agendamento de consultas preventivas e a comunicação com os pacientes.

## Escopo do Projeto
O projeto envolve o desenvolvimento de um sistema de gestão para a OdontoPrev, integrando as seguintes funcionalidades:

- **Cadastro e Gerenciamento de Beneficiários**: Inclusão, atualização e exclusão de dados de beneficiários.
- **Gestão de Consultas**: Agendamento, atualização e consulta de histórico de consultas de beneficiários.
- **Gestão de Exames**: Cadastramento de exames e seus resultados.
- **Gestão de Sinistros**: Registro e análise de sinistros para identificar padrões de risco.
- **Integração com Modelos de Machine Learning**: Implementação de um sistema de predição de risco para classificar beneficiários.
- **Interface RESTful**: API completa para integração com sistemas externos e comunicação via API.

## Requisitos Funcionais
- O sistema deve permitir a criação, atualização, consulta e exclusão de beneficiários.
- O sistema deve registrar e gerenciar consultas e exames dos beneficiários.
- O sistema deve permitir a integração com algoritmos de machine learning para predição de risco.
- A aplicação deve ser acessada via API REST, com endpoints bem definidos e documentados via Swagger.

## Requisitos Não Funcionais
- A aplicação deve seguir princípios de **Clean Architecture**, garantindo fácil manutenção e evolução.
- A API deve ter uma documentação clara e completa via **Swagger**.
- A aplicação deve ser escalável e de alta disponibilidade.
- A persistência dos dados deve ser garantida por meio de transações ACID em um banco de dados **Oracle**.
- A comunicação entre sistemas deve ser segura e eficiente.

## Desenho da Arquitetura

O projeto foi estruturado com base nos princípios da **Clean Architecture**, garantindo o desacoplamento entre as camadas e facilitando a manutenção.

### Camadas da Aplicação

1. **Apresentação**
    - Camada responsável por expor as funcionalidades da aplicação via API REST. Documentada via Swagger.
    - **Pasta**: `Presentation/Controller`

2. **Aplicação**
    - Implementa regras de aplicação e orquestra o fluxo de dados entre as camadas de apresentação e domínio.
    - **Pasta**: `Application/Services`, `Application/Dtos`

3. **Domínio**
    - Contém os modelos e regras de negócio. Independente de tecnologias externas.
    - **Pasta**: `Domain/Entities`, `Domain/Interfaces`

4. **Infraestrutura**
    - Responsável pela persistência dos dados, implementação de repositórios e integração com APIs externas e o banco de dados Oracle.
    - **Pasta**: `Infrastructure/Data`, `Infrastructure/Repository`

## Tecnologias Utilizadas
- **C#** e **.NET Core** para o backend.
- **Entity Framework Core** para mapeamento de objetos para o banco de dados.
- **Oracle Database** para armazenamento de dados.
- **Swagger** para documentação da API.
- **Postman** para testes manuais dos endpoints.

## Estrutura de Pastas

```bash
ByteRisk
├── Application
│   ├── Dtos         # Transferência de dados entre camadas
│   ├── Interfaces   # Interfaces para serviços de aplicação
│   └── Services     # Implementação dos serviços
├── Domain
│   ├── Entities     # Entidades de domínio
│   └── Interfaces   # Interfaces do domínio
├── Infrastructure
│   ├── Data         # Contexto de banco de dados e mapeamento
│   └── Repository   # Repositórios de acesso aos dados
├── Presentation
│   └── Controllers  # Controladores REST da API
└── README.md
```

## Equipe do Projeto

- **Gustavo Rabelo Frere** - RM 553326
- **Marcelo Vieira Juniro** - RM 553640
- **Felipe Arcanjo Matos dos Santos** - RM 554018

## Link do YouTube

[Apresentação do Projeto ByteRisk](https://teams.microsoft.com/l/message/48:notes/1728275411912?context=%7B%22contextType%22%3A%22chat%22%7D)

## String de Conexão

```json
"ConnectionStrings": {
    "DefaultConnection": "User Id=rm553326;Password=091003;Data Source=oracle.fiap.com.br:1521/orcl"
  }
```

