Formação ASPNET 💻
Projeto DevFreela Web API
Bem-vindo ao Meu Projeto Incrível! Este é um projeto que estou desenvolvendo usando os padrões de arquitetura limpa, princípios de Domain-Driven Design (DDD), CQRS (Command Query Responsibility Segregation) e boas práticas de desenvolvimento.

Tecnologias Utilizadas 🛠️
Plataforma: .NET Core 8
Banco de Dados: Microsoft SQL Server
ORM: Entity Framework Core
Sobre o Projeto ℹ️
Este projeto tem como objetivo demonstrar a aplicação dos princípios de arquitetura limpa e DDD em uma aplicação .NET Core. A arquitetura foi organizada em camadas para garantir uma separação clara de responsabilidades e facilitar a manutenção e escalabilidade do sistema.

Padrões e Práticas 📚
Arquitetura Limpa
A arquitetura do projeto segue os princípios da Arquitetura Limpa (Clean Architecture), onde a separação de preocupações é alcançada através de camadas bem definidas, como Domínio, Aplicação, Infraestrutura e Interfaces de Usuário.

Domain-Driven Design (DDD)
Utilizei conceitos e práticas de Domain-Driven Design para modelar o domínio da aplicação de forma a representar fielmente as regras de negócio e comportamentos do sistema.

CQRS (Command Query Responsibility Segregation)
Implementei o padrão CQRS para separar as operações de leitura (queries) das operações de escrita (commands), proporcionando uma melhor separação de responsabilidades e otimizando o desempenho da aplicação.

Como Contribuir 🤝
Se você gostaria de contribuir para este projeto, sinta-se à vontade para fazer um fork e enviar pull requests. Todas as contribuições são bem-vindas!

Como Rodar o Projeto ▶️
Clone o repositório para o seu ambiente local.
Certifique-se de ter o .NET Core 8 instalado em sua máquina.
Configure a conexão com o banco de dados SQL Server no arquivo de configuração appsettings.json.
Execute as migrações do Entity Framework Core para criar o banco de dados: dotnet ef database update.
Execute o projeto utilizando o comando dotnet run.