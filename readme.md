## Objetivo
Avaliação para Desenvolvedor Pleno C#

## Funcionalidades
- Controle de clientes
- Controle de produtos
- Controle de estoque
- Controle de vendas
- Criar novos usuários
- Acesso somente logado

## Scripts - Banco de dados
Este projeto faz uso do Postgresql na versão 16.

```sql
CREATE TABLE users (
    id SERIAL PRIMARY KEY,
    username VARCHAR(50) NOT NULL,
    password VARCHAR(50) NOT NULL
);

create table products (
	id serial primary key,
	description varchar(200) not null,
	brand varchar(100),
	price decimal(10, 2) not null,
	stock integer not null
);

create table clients (
	id serial primary key,
	name varchar(200) not null,
	phone varchar(14),
	address varchar(200),
	email varchar(100)
);

create table sale (
	id serial primary key,
	client_id integer not null,
	amount decimal(10, 2) not null,
	created_at timestamp default current_timestamp
);

create table saleItem (
	id serial primary key,
	sale_id integer not null,
	product_id integer not null,
	quantity integer not null,
	price decimal(10, 2) not null	
);