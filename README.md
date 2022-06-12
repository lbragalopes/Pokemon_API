# programa-bolsa-compasso-sprint4
Exercicio API REST

API de Informações de Pokemon usando asp net core 2.1 Exercício para aprender os verbos http GET, POST, DELETE

Desafio API REST p/ cadastrar:

 -Pokemon
 - Considere o cadastro com dados básicos:
   - Pokemon: codigo, nome, tipo(Poison, Fire, Flying, Water)

### 📋 Requisitos da entrega

Construa o código que contemple as seguintes operações expostas como endpoints REST para:

- Inserir pokemon
- Consultar todos pokemons
- Remover pokemon

- Abaixo a Descrição detalhada da coleção de exemplos  JSON POSTMAN PokemonAPI
   1. GET Pokemon 
      - Consulta todss pokemons que estão gravados no BD
      - Headers: Accept application/json
	  - URL: https://localhost:44302/api/pokemon

   2. POST Pokemon
       - Cadastra um pokemon
       - Headers:
	     - KEY: Content-Type VALUE: application/json
		 - KEY: Accept VALUE: application/json
		 - Body
           ```json
		   {
			 "Nome" : "Venusaur",
			 "Tipo" : "Grass"
	       }
           ```
	   - URL: https://localhost:44302/api/pokemon

   3. DELETE Pokemon
       - Excluir Pokemon
       - Headers:
		 - Body
	   - URL: https://localhost:44302/api/pokemon/123

### 📋 Pré-requisitos
 - Visual Studio 2019
 - Carga de trabalho do Visual Studio 2019 Web application ASP NET Core
 - .NET Core 3.1
 - POSTMAN (para testar)

## ✒️ Autores

* **Rafael Vieira Suarez** - *Trabalho Inicial* - [suarezrafael](https://github.com/suarezrafael)

