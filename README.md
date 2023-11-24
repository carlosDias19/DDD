# Projeto DDDReportRadar

O projeto DDDReportRadar é uma aplicação implementada em C# que segue a arquitetura Domain-Driven Design (DDD), projetada para atender às necessidades específicas do domínio de DDDReportRadar.

## Estrutura do Projeto

- Application # Camada de Aplicação
- Application.Services # Application Services
- Domain # Camada de Domínio
- Domain.Services # Domain Services
- Infra # Camada de Infraestrutura

  
- **Domain**: Contém as entidades, agregados, interfaces de repositório e serviços do domínio.
- **Application**: Responsável por orquestrar o fluxo de trabalho da aplicação. Contém os serviços de aplicação, DTOs (Data Transfer Objects) e mapeamentos.
- **Application.Services**: Camada adicional para serviços de aplicação que não se encaixam diretamente nas operações de CRUD.
- **Domain.Services**: Camada para serviços de domínio adicionais que não pertencem diretamente a uma entidade ou agregado específico.
- **Infrastructure**: Implementa a infraestrutura técnica, como repositórios concretos, serviços externos, etc.

## Pré-requisitos

Antes de começar a trabalhar no projeto, certifique-se de ter as seguintes ferramentas instaladas:

- [Visual Studio](https://visualstudio.microsoft.com/pt-br/)

## Configuração Inicial

1. Clone este repositório:

   ```bash
   Abra o visual studio, e clique em **Clonar Repositorio** - coloque, https://github.com/carlosDias19/DDDReportRadar.git
   - Vá em ferramentas, GERENCIADOR DE PACOTE NUGET, e abra o console. No console altere o projeto padrão para DDD.Infra.SQLserver, e digite 'update-database'
   - Testes
    Para testar, pode-se utilizar do swager (padrão de inicialização), ou testar com as requisições do front
    USUARIO ADM: Carlos@teste.com
    SENHA: 123

