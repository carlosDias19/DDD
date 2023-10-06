# DDD

Introdução
Este documento serve como uma referência para o projeto de contabilidade desenvolvido utilizando o padrão Domain-Driven Design (DDD) e um contexto específico para o setor contábil.

Visão Geral do Projeto
O projeto visa oferecer soluções eficientes para o setor de contabilidade, focando na divisão do sistema em camadas bem definidas, facilitando a manutenção e escalabilidade do código.

Estrutura do DDD
O projeto segue o padrão DDD, que é dividido nas seguintes camadas:

Domain: Contém as entidades, agregados, value objects e eventos de domínio.
Application: Define os casos de uso e comandos. Esta camada é responsável pela orquestração das regras de negócio.
Infrastructure: Lida com aspectos externos ao domínio, como persistência, mensageria e integrações externas.
Presentation: Camada responsável pela interface do usuário.
