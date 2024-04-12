Use ZurrapaFilial

if not exists (select * from dbo.sysobjects
	where id = object_id(N'[dbo.[Produto]'))
begin
	CREATE TABLE  Produto (
		id_produto int NOT NULL IDENTITY(1,1)
		CHECK (id_produto >= 1),
		designacao nvarchar(80),
		preco_venda_unidade int NOT NULL,
		preco_custo int NOT NULL,
		CONSTRAINT  PK_Produto PRIMARY KEY (id_produto),
);
end

if not exists (select * from dbo.sysobjects
	where id = object_id(N'[dbo.[Empregado]'))
begin
	CREATE TABLE  Empregado (
		id_emp int NOT NULL IDENTITY(1,1)
		CHECK (id_emp >=1),
		nome nvarchar(80),
		idade int NOT NULL,
		cargo nvarchar(20),
		CONSTRAINT  PK_Empregado PRIMARY KEY (id_emp),
);
end

if not exists (select * from dbo.sysobjects
	where id = object_id(N'[dbo.[Unidade]'))
begin
	CREATE TABLE  Unidade (
		id_prod_U int NOT NULL IDENTITY(1,1)
		CHECK (id_prod_U >=1),
		unidade_medida int NOT NULL,
		id_produto int NOT NULL,
		CONSTRAINT  PK_Unidade PRIMARY KEY (id_prod_U),
		FOREIGN KEY (id_produto)
			REFERENCES Produto(id_produto)
			ON DELETE NO ACTION,
);
end

if not exists (select * from dbo.sysobjects
	where id = object_id(N'[dbo.[Local]'))
begin
	CREATE TABLE Local (
		id_local int NOT NULL IDENTITY(1,1)
		CHECK (id_local >=1),
		tipo_de_local nvarchar(80) NOT NULL,
		localizacao nvarchar(80) NOT NULL,
		tempo_repor int,
		id_emp int NOT NULL,
		CONSTRAINT  PK_Local PRIMARY KEY (id_local),
		FOREIGN KEY (id_emp)
			REFERENCES Empregado(id_emp)
			ON UPDATE CASCADE
			ON DELETE CASCADE,
);
end

if not exists (select * from dbo.sysobjects
	where id = object_id(N'[dbo.[Trabalha]'))
begin
	CREATE TABLE Trabalha (
		 hora_Entrada nvarchar(10) NOT NULL,
		 hora_Saida nvarchar(10) NOT NULL,
		 id_emp INT NOT NULL,
		 id_local INT NOT NULL,
		 FOREIGN KEY (id_emp)
			REFERENCES Empregado(id_emp)
			ON UPDATE CASCADE
			ON DELETE CASCADE,
		FOREIGN KEY (id_local)
			REFERENCES Local(id_local)
			,
);
end

if not exists (select * from dbo.sysobjects
	where id = object_id(N'[dbo.[Pedido]'))
begin
	CREATE TABLE Pedido (
		id_pedido INT NOT NULL IDENTITY(1,1)
		CHECK (id_pedido >= 1),
		hora nvarchar(10) NOT NULL,
		estado nvarchar(80) NOT NULL,
		total_preco INT NOT NULL,
		id_local INT NOT NULL,
		id_emp INT NOT NULL,
		CONSTRAINT  PK_Pedido PRIMARY KEY (id_pedido),
		FOREIGN KEY (id_emp)
			REFERENCES Empregado(id_emp)
			ON UPDATE CASCADE
			ON DELETE CASCADE,
		FOREIGN KEY (id_local)
			REFERENCES Local(id_local)
			,
);
end

if not exists (select * from dbo.sysobjects
	where id = object_id(N'[dbo.[Prod_Pedido]'))
begin
	CREATE TABLE Prod_Pedido (
		quantidade_servida INT NOT NULL,
		quantidade_paga INT NOT NULL,
		id_pedido INT NOT NULL,
		id_produto INT NOT NULL,
		FOREIGN KEY (id_pedido)
			REFERENCES Pedido(id_pedido)
			ON UPDATE CASCADE,
		FOREIGN KEY (id_produto)
			REFERENCES  Produto(id_produto),
);
end

if not exists (select * from dbo.sysobjects
	where id = object_id(N'[dbo.[Prod_Local]'))
begin
	CREATE TABLE Prod_Local (
		Qtd INT NOT NULL,
		id_local INT NOT NULL,
		id_produto INT NOT NULL,
		id_prod_U INT NOT NULL,
		FOREIGN KEY (id_local)
			REFERENCES Local(id_local)
			ON UPDATE CASCADE
			ON DELETE NO ACTION,
		FOREIGN KEY (id_produto)
			REFERENCES Produto(id_produto),
		FOREIGN KEY (id_prod_U)
			REFERENCES Unidade(id_prod_U),
);
end