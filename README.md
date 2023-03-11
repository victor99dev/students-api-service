# 👩‍🎓 | Student API Service.

## 💻 | Projeto: Construindo uma API de cadastro Alunos.

Seja bem vindo, esse projeto foi feito no intuito de criar uma API com SQL server.

- Colocando em prática alguns conceitos e utilizando o EF.
- Utilizando a linguagem C#.
- Utilizando banco de dados SQLServer.
## ⚙ | API.

### ✔ | Tecnologias:
- .NET 6
- AutoMapper 12.0.1
- EntityFrameworkCore 7.0.3
- EntityFrameworkCore.Design 7.0.3
- Microsoft.EntityFrameworkCore.SqlServer 7.0.3

### 📁 | Uma breve visão do projeto:
Essa aplicação em si é bem simples e com poucas entidades se relacionando, sendo elas:
- Student (Estudante).
- Classroom (Sala de Aula).
- School Subject (Matéria Escolar).
- Teacher (Professor).

### ⌨ | Comandos

| **Comandos**                                   |                                              **Descrição**|
|------------------------------------------------|------------------------------------------------------------|
|                                  `dotnet build`|                Constroi o projeto e todas suas dependências|
|                                    `dotnet run`|                                            Inicia o projeto|
|                     `dotnet ef database update`| Comando para criar ou atualizar o esquema do banco de dados|
|   `dotnet ef migrations add NomeDaMigraçãoAqui`| Crianção de suas migrations, servindo para criar, atualizar ou excluir suas tabelas ou campos de determinada tabela.|


Para acessar a API, basta clicar no [Link](https://localhost:7060/swagger/index.html) para o acesso da mesma.

Por meio de organização, fiz questão de fazer o levantando como uma sprint, no primeiro dia, me desafiei em uma arquitetura bem rudimentar, porém serviu como base para o desenvolvimentde de minha aplicação, nele pensei em como eu poderia utilizar a API, como as entidades iriam se relacionar e como eu gostaria dos paylous viria a ser retornado.

Software Architecture:
![preview1 img](/docs/img/software-architecture.png)

Aqui temos as relações entre minhas tabelas:

![preview2 img](/docs/img/studentdb-relations.png)

API em si é bem simples de se utilizando, meu passo a passo é de utilização vai ser criando um Teacher e vinculando ele em uma School Subject.
<details><summary>Cadastrando um Teacher:</summary>
<p>

/Teacher/Post
```json
{
  "name": "Jason Mamoa",
  "created_at": "2023-03-11T02:28:07.462Z",
  "is_active": true
}
```
</p>
</details>

Para verificar seu Id, eu irei em get-all, podemos utilizar o Id para verificar seu detalhar, onde será informado mais detalhes do mesmo, como data de cadastro, atualização e etc.

<details><summary>Get-all de Teacher:</summary>
<p>

/Teacher/get-all
```json
{
 "id": "c47583ec-8015-4dd4-8d4a-08db21d9077e",
    "name": "Jason Mamoa",
    "is_active": true
}
```
</p>
</details>

<details><summary>Detalhar:</summary>
<p>

/Teacher/get-all
/Teacher/get-by/{id}
```json
{
  "id": "c47583ec-8015-4dd4-8d4a-08db21d9077e",
  "name": "Jason Mamoa",
  "created_at": "2023-03-11T02:28:07.462",
  "updated_at": "0001-01-01T00:00:00",
  "is_active": true
}
```
</p>
</details>

Após saber essas informações, podemos fazer o cadastras de uma school subject vinculando o professor que irá ministrar:

<details><summary>Cadastrando uma School Subject:</summary>
<p>

/SchoolSubject/post
```json
{
  "name": "Física",
  "teacher_id": "c47583ec-8015-4dd4-8d4a-08db21d9077e",
  "created_at": "2023-03-11T02:39:00.184Z",
  "is_active": true
}
```
</p>
</details>

Aqui nesse passo podemos pular logo para o detalhar de school subject.

<details><summary>Cadastrando uma School Subject:</summary>
<p>

/SchoolSubject/post
/SchoolSubject/get-by/{id}
```json
{
  "id": "66a10413-a959-47d8-4a2d-08db21da414b",
  "name": "Física",
  "teacher": {
    "id": "c47583ec-8015-4dd4-8d4a-08db21d9077e",
    "name": "Jason Mamoa",
    "is_active": true
  },
  "created_at": "2023-03-11T02:39:00.184",
  "updated_at": "0001-01-01T00:00:00",
  "is_active": true
}
```
</p>
</details>

Após esse mini tutorial, os próximos endpoints seguem o mesmo fluxo.

### 🌐 | Endpoints:
Os endpoint esperados estão funcinando perfeitamente.

<details><summary>Endpoints de Classroom</summary>
<p>

| Verbo  | Endpoint                  | Parâmetro | Body             |
|--------|---------------------------|-----------|------------------|
| POST   | /Classroom/post/          | N/A       | Schema Classroom |
| GET    | /Classroom/get-all/       | N/A       | N/A              |
| GET    | /Classroom/get-by/{id}    | id        | N/A              |
| PUT    | /Classroom/update/{id}    | id        | Schema Classroom |
| DELETE | /Product/delete/{id}      | id        | N/A              |

</p>
</details>

<details><summary>Endpoints de SchoolSubject</summary>
<p>

| Verbo  | Endpoint                | Parâmetro | Body          |
|--------|-------------------------|-----------|---------------|
| POST   | /SchoolSubject/post/             | N/A       | Schema SchoolSubject   |
| GET    | /SchoolSubject/get-all/          | N/A       | N/A           |
| GET    | /SchoolSubject/get-by/{id}       | id        | N/A           |
| PUT    | /SchoolSubject/update/{id}       | id        | Schema SchoolSubject           |
| DELETE | /SchoolSubject/delete/{id}       | id        | N/A           |

</p>
</details>

<details><summary>Endpoints de Student</summary>
<p>

| Verbo  | Endpoint                | Parâmetro | Body          |
|--------|-------------------------|-----------|---------------|
| POST   | /Student/post/           | N/A       | Schema Student |
| GET    | /Student/get-all/        | N/A       | N/A           |
| GET    | /Student/get-by/{id}     | id        | N/A           |
| PUT    | /Student/update/{id}     | id        | Schema Student |
| DELETE | /Student/delete/{id}     | id        | N/A           |

</p>
</details>

<details><summary>Endpoints de Teacher</summary>
<p>

| Verbo  | Endpoint                | Parâmetro | Body          |
|--------|-------------------------|-----------|---------------|
| POST   | /Teacher/post/           | N/A       | Schema Teacher |
| GET    | /Teacher/get-all/        | N/A       | N/A           |
| GET    | /Teacher/get-by/{id}     | id        | N/A           |
| PUT    | /Teacher/update/{id}     | id        | Schema Teacher |
| DELETE | /Teacher/delete/{id}     | id        | N/A           |

</p>
</details>

O schema (model) dos endpoitns, são utilizado para passar os campos exigidos, como no verbo POST e PUT.

Todas solicitações como GET, POST, PUT e DELETE que correspondem como CREATE, READ, UPDATE e DELETE (CRUD) estão funcionando.

Utilizando no Swagger:

![preview3 img](/docs/img/swagger-ui.png)

<b>Segue a lista de commits para verificar o que foi implementado e alterado! Utilizo o Conventional Commits Pattern para ajudar e detalhar o contexto de cada commit efetuado.</b>

## 👩‍💻 Meus Links:

- Github: [Victor Hugo.](https://github.com/torugo99)
- LinkedIn: [Victor Hugo.](https://www.linkedin.com/in/victor-hugo99/)
- Meu Site: [Victor99dev.](http://victor99dev.site/)

### 😀 | Créditos e Agradecimentos:
- Todas as informações do .Net, sendo comandos ou qualquer outra informação foi retirada da documentação oficial.
- Documentações: 
    - [.Net](https://learn.microsoft.com/pt-br/dotnet/)
    - [Swagger](https://learn.microsoft.com/en-us/aspnet/core/tutorials/web-api-help-pages-using-swagger?view=aspnetcore-7.0)
    - [Automapper](https://automapper.org/)
    - [SQL Server](https://learn.microsoft.com/en-us/azure/azure-sql/database/free-sql-db-free-account-how-to-deploy?view=azuresql)
- Link do Figma pois foi por ele que fiz a arquitetura da API: [Link](https://www.figma.com/)
- Dbeaver é por onde acesso meus bancos de dados e gero o DER do banco: [Link](https://dbeaver.io/)
