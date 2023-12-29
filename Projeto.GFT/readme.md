# Projeto.GFT
Este projeto � um exemplo em C# de uma "API" com Angular e testes em XUnit.

## Requisitos

O projeto deve atender aos seguintes requisitos:

* Sistema
    O projeto prev� o uso de duas tecnologias da Microsoft: .Net Framework 4.8.1 e .NET 8.0.
    Inicialmente, est� configurado para executar na vers�o .Net Framework 4.8.1.
    Visual Studio 2022 17.8.3
    Node v20.10.0
    Npm 10.2.5
    Angular @angular/cli@17.0.8
 
* Funcional:
    * O projeto deve fornecer uma API Web para gerenciar investimentos.
    * O projeto deve calcular os rendimentos dos investimentos ap�s o usu�rio inserir os dados.
* N�o funcional:
    * O projeto deve ser desenvolvido em C#.
    * O projeto deve utilizar Angular para o front-end.
    * O projeto deve utilizar XUnit para os testes.

## Instala��o

Para instalar as depend�ncias necess�rias para executar o projeto, siga estas etapas:

1. Abra o Package Manager Console.
2. Execute o seguinte comando: dotnet restore

## Estrutura
A Solution cont�m as seguintes pastas:

doc: cont�m a documenta��o do projeto, incluindo este readme.md.
src: cont�m os projetos Angular e WebApi.
tests: cont�m os testes XUnit.

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

## Execu��o
Para executar o projeto, siga estas etapas:

Abra a Solution no Visual Studio.
A Solution j� est� pr�-configurada para executar o projeto Angular e a API.
Caso n�o execute ao mesmo tempo, clique com o bot�o direito na Solution e selecione Configure Startup Project.
Selecione Multiple Startup Project e escolha AngularWeb e ServiceApi.
Ap�s selecionar, � s� executar o projeto com F5.

O projeto web estar� dispon�vel em http://localhost:4200/.
A API Web utilizando .Net Framework estar� dispon�vel em https://localhost:44342/swagger/ui/index.
E para usar a API Web .NET, estar� dispon�vel em https://localhost:7203/swagger/index.html.
**Obs: Para a utiliza��o da API Web .NET, � necess�rio configurar no Startup Project (Bot�o direito no projeto Set as Startup Project)**

## Testes
Para executar os testes, siga estas etapas:

No Visual Studio, abra a Solution.
Na barra de menus, selecione Test > Run All Tests.

## Autor
**Charles Albert Fernandes**
