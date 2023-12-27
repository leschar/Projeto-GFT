# Projeto.GFT
Este projeto � um exemplo de projeto em C# "API" com Angular e testes em XUnit.

# Requisitos

O projeto deve atender aos seguintes requisitos:

* Funcional:
    * O projeto deve fornecer uma API Web para gerenciar investimentos.
    * O projeto deve calcular os rendimentos dos investimentos ap�s o usu�rio inserir os dados.
* N�o funcional:
    * O projeto deve ser desenvolvido em C#.
    * O projeto deve usar Angular para o front-end.
    * O projeto deve usar XUnit para os testes.

# Instala��o

Para instalar as depend�ncias necess�rias para executar o projeto, siga estas etapas:

1. Abra Package Manager Console.
3. Execute o seguinte comando:

dotnet restore

# Estrutura
A Solution cont�m as seguintes pastas:

doc: cont�m a documenta��o do projeto, incluindo este readme.md.
src: cont�m os projetos Angular e WebApi.
tests: cont�m os testes XUnit.

+-- Projeto.GFT
    +-- doc
        +-- readme.md
    +-- src
        +-- AngularWeb
            +--src
                +-- app
                    +--diretivas
                        +--currency-input.directive.ts
                   +-- app.component.css
                   +-- app.component.html
                   +-- app.component.spec.css
                   +-- app.component.ts
                   +-- app.module.ts
                   +-- app-routing.module.ts
                    +--utils
                        +--currency-utils.ts               
        +-- ServerApi
            +-- Controllers
                +-- InvestimentoController.cs
            +-- Domain
                +-- Interfaces
                    +-- ICDIRepository.cs
                    +-- IImpostoRepository.cs
                    +-- IInvestimentoService.cs
                    +-- ITBRepository.cs                    
                +-- Models
                    +-- InvestimentoRequest.cs
                    +-- InvestimentoResponse.cs
                +-- Services
                    +-- InvestimentoServices.cs
            +-- Infra
                +-- Repositories
                    +-- CDIRepository.cs
                    +-- ImpostoRepository.cs
                    +-- TBRepository.cs
    +-- tests
        +-- STestXunit
            +-- Domain
                +-- InvestimentoServiceTests.cs
            +-- Integration
                +-- InvestimentoControllerTests.cs
            +-- Repository
                +-- CDIRepositoryTests.cs
                +-- ImpostoRepositoryTests.cs
                +-- TBRepositoryTests.cs


# Execu��o
Para executar o projeto, siga estas etapas:

Abra a Solution no Visual Studio.
A Solution j� est� pr� configurada para executar o projeto Angular e Api
Caso n�o execute ao mesmo tempo, clique com bot�o direito na Solution e selecione Configure Startup Project
Selecione Multiple Startup Project e selecione AngularWeb e ServiceApi
Ap�s selecionar � s� executar o projeto com F5

O projeto web estar� dispon�vel em http://localhost:4200/.
A API Web estar� dispon�vel em https://localhost:7203/swagger/index.html.

# Testes
Para executar os testes, siga estas etapas:

No Visual Studio, abra a Solution.
Na barra de menus, selecione Test >Run All Tests.

