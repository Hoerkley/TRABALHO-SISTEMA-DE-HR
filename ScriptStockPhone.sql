CREATE DATABASE StockPhone
USE StockPhone;
CREATE TABLE Usuario
(
	Id int IDENTITY(1,1)
		CONSTRAINT PK_UsuarioId PRIMARY KEY(Id), 
	Nome varchar(50) NOT NULL,
	Email varchar(40) NOT NULL,
	"User" varchar(20) NOT NULL,
	Senha varchar(20) NOT NULL,
	"Status" BIT NOT NULL,
);
CREATE TABLE Endereco
(
	id int IDENTITY(1,1)
		CONSTRAINT PK_EnderecoId PRIMARY KEY(Id), 
	Cnpj varchar(11) NOT NULL,
	Cep varchar(8) NOT NULL,
	Logradouro varchar(10) NOT NULL,
	Complemento varchar(15) NOT NULL,
	Bairro varchar(15) NOT NULL,
	Cidade varchar(20) NOT NULL,
	Estado varchar(15) NOT NULL,
);

CREATE TABLE Produtos (
    Id INT IDENTITY(1, 1)
		CONSTRAINT PK_ProdutosId PRIMARY KEY(Id),
    Nome NVARCHAR(255) NOT NULL,
    SKU NVARCHAR(50),
    Categoria NVARCHAR(50),
    Subcategoria NVARCHAR(50),
    Preco DECIMAL(18, 2) NOT NULL,
    EstoqueInicial INT NOT NULL,
    EstoqueEntradas INT NOT NULL,
    EstoqueSaidas INT NOT NULL,
    NivelMinimo INT NOT NULL,
    "Status" BIT NOT NULL
);

CREATE TABLE Cliente
(
	id int IDENTITY(1,1)
		CONSTRAINT PK_ClienteId PRIMARY KEY(Id), 
    Nome varchar(30) NOT NULL,
	"Status" bit NOT NULL,
	Endereco int NOT NULL,
		CONSTRAINT FK_Cliente_Endereco
	FOREIGN KEY(Endereco) REFERENCES
	Endereco(Id)
);
CREATE TABLE Colaborador
(
	id int IDENTITY(1,1)
		CONSTRAINT PK_ColaboradorId PRIMARY KEY(Id), 
	Nome varchar(50) NOT NULL,
	Cpf varchar(11) NOT NULL,
	DataNascimento datetime NOT NULL,
	Email varchar(50) NOT NULL,
	Telefone varchar(12) NOT NULL,
	Endereco int NOT NULL,
		CONSTRAINT FK_Colaborador_Endereco
	FOREIGN KEY(Endereco) REFERENCES
	Endereco(Id)
);

-- Insert 1
INSERT INTO usuario (Nome, Email, "User", Senha, "Status")
VALUES ('João Silva', 'joao.silva@email.com', 'joao', '123456', 0);

-- Insert 2
INSERT INTO usuario (Nome, Email, "User", Senha, "Status")
VALUES ('Maria Souza', 'maria.souza@email.com', 'maria', '654321', 0);

-- Insert 3
INSERT INTO usuario (Nome, Email, "User", Senha, "Status")
VALUES ('Pedro Santos', 'pedro.santos@email.com', 'pedro', '123456', 1);

-- Insert 4
INSERT INTO usuario (Nome, Email, "User", Senha, "Status")
VALUES ('Ana Paula', 'ana.paula@email.com', 'ana', '654321', 1);

-- Insert 5
INSERT INTO usuario (Nome, Email, "User", Senha, "Status")
VALUES ('Carlos Alberto', 'carlos.alberto@email.com', 'carlos', '123456', 1);

-- Insert 6
INSERT INTO usuario (Nome, Email, "User", Senha, "Status")
VALUES ('Daniela Martins', 'daniela.martins@email.com', 'daniela', '654321', 1);

-- Insert 7
INSERT INTO usuario (Nome, Email, "User", Senha, "Status")
VALUES ('Francisco José', 'francisco.jose@email.com', 'francisco', '123456', 1);

-- Insert 8
INSERT INTO usuario (Nome, Email, "User", Senha, "Status")
VALUES ('Gisele Oliveira', 'gisele.oliveira@email.com', 'gisele', '654321',  0);

-- Insert 9
INSERT INTO usuario (Nome, Email, "User", Senha, "Status")
VALUES ('Heitor Barbosa', 'heitorbarbosa@gmail.com', 'heitor', '123456', 1);

-- Insert 10
INSERT INTO usuario (Nome, Email, "User", Senha, "Status")
VALUES ('Irene Cardoso', 'irene.cardoso@email.com', 'irene', '654321', 1);

-- Celulares
INSERT INTO Produtos (Nome, SKU, Categoria, Subcategoria, Preco, EstoqueInicial, EstoqueEntradas, EstoqueSaidas, NivelMinimo,"Status")
VALUES 
('Iphone 11', 'IP11-035', 'Celulares', 'Iphone', 999.99, 50, 20, 8, 15,1),
('Iphone 12', 'IP12-036', 'Celulares', 'Iphone', 1199.99, 40, 15, 5, 10,1),
('Iphone X', 'IPX-037', 'Celulares', 'Iphone', 799.99, 60, 25, 10, 20,1),
('Iphone 8', 'IP8-038', 'Celulares', 'Iphone', 699.99, 30, 10, 3, 8,1),
('Samsung Galaxy S', 'SGS-039', 'Celulares', 'Samsung Galaxy S', 899.99, 45, 18, 7, 12,1),
('Samsung Galaxy Fold', 'SGF-040', 'Celulares', 'Samsung Galaxy Fold', 1499.99, 20, 8, 3, 10,1);

-- Tablets
INSERT INTO Produtos (Nome, SKU, Categoria, Subcategoria, Preco, EstoqueInicial, EstoqueEntradas, EstoqueSaidas, NivelMinimo,"Status")
VALUES 
('Samsung Tablet', 'ST-041', 'Tablets', 'Samsung', 299.99, 70, 30, 10, 25,1),
('Apple iPad', 'AI-042', 'Tablets', 'Apple', 399.99, 50, 20, 8, 15,1),
('Multilaser Tablet', 'MT-043', 'Tablets', 'Multilaser', 149.99, 80, 35, 15, 30,1),
('Sony Tablet', 'ST-044', 'Tablets', 'Sony', 279.99, 60, 25, 12, 18,1),
('Tectoy Tablet', 'TT-045', 'Tablets', 'Tectoy', 99.99, 90, 40, 20, 35,1),
('Positivo Tablet', 'PT-046', 'Tablets', 'Positivo', 129.99, 75, 32, 10, 20,1),
('Nokia Tablet', 'NT-047', 'Tablets', 'Nokia', 189.99, 55, 22, 8, 15,1),
('Vaio Tablet', 'VT-048', 'Tablets', 'Vaio', 349.99, 35, 15, 5, 10,1),
('Motorola Tablet', 'MT-049', 'Tablets', 'Motorola', 229.99, 65, 28, 10, 20,1),
('Mirage Tablet', 'MT-050', 'Tablets', 'Mirage', 119.99, 85, 38, 15, 30,1);

-- Smartwatches
INSERT INTO Produtos (Nome, SKU, Categoria, Subcategoria, Preco, EstoqueInicial, EstoqueEntradas, EstoqueSaidas, NivelMinimo,"Status")
VALUES 
('Samsung Smartwatch', 'SSW-051', 'Smartwatches', 'Samsung', 199.99, 40, 15, 5, 10,1),
('Apple Watch', 'AW-052', 'Smartwatches', 'Apple', 299.99, 30, 10, 3, 8,1),
('Multilaser Smartwatch', 'MSW-053', 'Smartwatches', 'Multilaser', 79.99, 50, 20, 8, 15,1),
('Atrio Smartwatch', 'ASW-054', 'Smartwatches', 'Atrio', 59.99, 60, 25, 10, 20,1),
('Xiaomi Smartwatch', 'XSW-055', 'Smartwatches', 'Xiaomi', 129.99, 45, 18, 7, 12,1);

-- Acessórios
INSERT INTO Produtos (Nome, SKU, Categoria, Subcategoria, Preco, EstoqueInicial, EstoqueEntradas, EstoqueSaidas, NivelMinimo,"Status")
VALUES 
('Adaptador USB-C', 'AUC-056', 'Acessórios', 'Adaptadores', 9.99, 150, 80, 30, 50,1),
('Braçadeira Esportiva', 'BE-057', 'Acessórios', 'Braçadeiras', 14.99, 120, 60, 25, 40,1),
('Cabo USB Lightning', 'CUL-058', 'Acessórios', 'Cabos', 7.99, 200, 100, 50, 80,1),
('Capinha para Smartphone', 'CPS-059', 'Acessórios', 'Capinhas', 19.99, 100, 50, 20, 40,1),
('Carregador Portátil', 'CP-060', 'Acessórios', 'Carregadores', 29.99, 80, 40, 20, 30,1),
('Fone de Ouvido Bluetooth', 'FOB-061', 'Acessórios', 'Fones de Ouvido', 39.99, 60, 30, 15, 25,1),
('Película Protetora', 'PP-062', 'Acessórios', 'Películas', 5.99, 180, 90, 35, 60,1);

