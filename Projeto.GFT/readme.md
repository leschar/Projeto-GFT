# Projeto.GFT
Este projeto é um exemplo em C# de uma "API" com Angular e testes em XUnit.

## Requisitos

O projeto deve atender aos seguintes requisitos:

* Sistema
    O projeto prevê o uso de duas tecnologias da Microsoft: .Net Framework 4.8.1 e .NET 8.0.
    Inicialmente, está configurado para executar na versão .Net Framework 4.8.1.
    Visual Studio 2022 17.8.3
    Node v20.10.0
    Npm 10.2.5
    Angular @angular/cli@17.0.8
 
* Funcional:
    * O projeto deve fornecer uma API Web para gerenciar investimentos.
    * O projeto deve calcular os rendimentos dos investimentos após o usuário inserir os dados.
* Não funcional:
    * O projeto deve ser desenvolvido em C#.
    * O projeto deve utilizar Angular para o front-end.
    * O projeto deve utilizar XUnit para os testes.

## Instalação

Para instalar as dependências necessárias para executar o projeto, siga estas etapas:

1. Abra o Package Manager Console.
2. Execute o seguinte comando: dotnet restore

## Estrutura
A Solution contém as seguintes pastas:

doc: contém a documentação do projeto, incluindo este readme.md.
src: contém os projetos Angular e WebApi.
tests: contém os testes XUnit.

- Projeto.GFT
    - doc
        - readme.md
    - src
        - AngularWeb
            - src
                - app
                    - diretivas
                        - currency-input.directive.ts
                    - app.component.css
                    - app.component.html
                    - app.component.spec.css
                    - app.component.ts
                    - app.module.ts
                    - app-routing.module.ts
                    - utils
                        - currency-utils.ts
        - ApiServer
            - Controllers
                - InvestimentoController.cs
            - Domain
                - Interfaces
                    - ICDIRepository.cs
                    - IImpostoRepository.cs
                    - IInvestimentoService.cs
                    - ITBRepository.cs
                - Models
                    - InvestimentoRequest.cs
                    - InvestimentoResponse.cs
                - Services
                    - InvestimentoServices.cs
            - Infra
                - Repositories
                    - CDIRepository.cs
                    - ImpostoRepository.cs
                    - TBRepository.cs
    - tests
        - NetFrameworkTests
            - Domain
                - InvestimentoServiceTests.cs
            - Integration
                - InvestimentoControllerTests.cs
            - Repository
                - CDIRepositoryTests.cs
                - ImpostoRepositoryTests.cs
                - TBRepositoryTests.cs

## Execução
Para executar o projeto, siga estas etapas:

Abra a Solution no Visual Studio.
A Solution já está pré-configurada para executar o projeto Angular e a API.
Caso não execute ao mesmo tempo, clique com o botão direito na Solution e selecione Configure Startup Project.
Selecione Multiple Startup Project e escolha AngularWeb e ServiceApi.
Após selecionar, é só executar o projeto com F5.

O projeto web estará disponível em http://localhost:4200/.
A API Web utilizando .Net Framework estará disponível em https://localhost:44342/swagger/ui/index.
E para usar a API Web .NET, estará disponível em https://localhost:7203/swagger/index.html.
**Obs: Para a utilização da API Web .NET, é necessário configurar no Startup Project (Botão direito no projeto Set as Startup Project)**

## Testes
Para executar os testes, siga estas etapas:

No Visual Studio, abra a Solution.
Na barra de menus, selecione Test > Run All Tests.

## Autor
**Charles Albert Fernandes**
