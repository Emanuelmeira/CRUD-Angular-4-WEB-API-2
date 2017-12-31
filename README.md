# Angular 2/4 consumindo ASP.NET Web API 2


## Projeto Angular 2/4

* Angular CLI versão 1.2.0.
* TypeScript 2.3.3.
* Node 8.4.0
* CSS Bootstrap 3.3.7. (ngx-bootstrap)
* Visual Studio Code.

## Projeto ASP.NET Web API 2

 * .NET Framework, v4.6.1
 * ASP.NET Web API 2 (C#).
 * Code First e Migrations com Entity Framework 6.
 * Visual Studio 2017.

## Arquitetura 

O Projeto da API esta dividido em 3 camadas principais. 

1. Controllers: Responsáveis por receber as requisições  e em caminhar para as próximas camadas.

2. Services: Responsáveis por receber os dados dos Controllers e processar/aplicar regra de negocio e enviar a próxima camada.

3. Repositórios: Responsáveis por Fazer o acesso a dados do sistema.

## Executando o Projeto

* ASP.NET Web API 2.

Abra o projeto no Viusal Studio, depois inicie o console em Tools > NuGet Package Manager > 'Package Manager Console' e 
execute o comando para baixar as dependências. 

```
Update-Package -Reinstall
```

Aguardar a restauração dos pacotes e execute a aplicação.

Atenção: Se o sistema apresentar "403.14 - Forbidden", tudo correu bem, apenas não existe rota para "/".

Sua API já esta ativa e funcional ;) 

* Angular 2/4.

Abra um terminal a partir da pasta do projeto 'Frontend' e execute seguinte comando para baixar as dependências.

```
npm install
```

Ao final da instalação ira aparecer algo como .. 

![Instalação Angular](https://github.com/Emanuelmeira/Easy-teste/blob/master/img/install-scripts.PNG)

Isso pode demorar um pouco. ;)  

IMPORTANTE: 

Por padrão a API esta iniciando na porta "51694". URL já configurada no projeto FrontEnd.

Agora é só executar o seguinte comando para iniciar a aplicação.

```
ng server
```

Acessar o endereço http://localhost:4200/ para visualizar a aplicação. :)


## Teste Selenium

Com a API e o sistema Frontend já em execução, para iniciar os testes basta apenas: 

Em Test > Run > 'All Test'.

O Visual Studio irá reconhecer os testes e executa-los.

IMPORTANTE: 

1. Por padrão os testes em selenium estam executando no browser Chome.

2. Na execução dos testes o ChromeDriver costuma ficar preso nos processos. É importante sempre encerrar o processo quando existe muitas execuções.


## Imagens

![NetWork](https://github.com/Emanuelmeira/Easy-teste/blob/master/img/network.PNG)


```
Duvidas? EmanuelMeira@outlook.com 
```

