Use ZurrapaSede

if not exists (select * from dbo.sysobjects
	where id = object_id(N'[dbo.[Filial]'))
begin
	CREATE TABLE Filial (
		id_filial INT NOT NULL IDENTITY(1,1)
		CHECK (id_filial >=1),
		endereco nvarchar(80) NOT NULL,
		designacao nvarchar(80) NOT NULL,
		email nvarchar(80) NOT NULL,
		telefone nvarchar(10) NOT NULL,
		gerente nvarchar(80) NOT NULL,
		CONSTRAINT PK_Filial PRIMARY KEY (id_filial),
);
end

if not exists (select * from dbo.sysobjects
	where id = object_id(N'[dbo.[Filial_Dia]'))
begin
	CREATE TABLE Filial_Dia (
		id_dia INT NOT NULL IDENTITY(1,1)
		CHECK (id_dia >=1),
		total_gasto FLOAT NOT NULL,
		total_recebido FLOAT NOT NULL,
		dia nvarchar(80) NOT NULL,
		lucro FLOAT NOT NULL,
		id_filial INT NOT NULL,
		CONSTRAINT PK_Filial_Dia PRIMARY KEY (id_dia),
		FOREIGN KEY (id_filial)
			REFERENCES Filial(id_filial)
			ON UPDATE CASCADE,
);
end


if not exists (select * from dbo.sysobjects
	where id = object_id(N'[dbo.[Filial_Dia_Bar]'))
begin
	CREATE TABLE Filial_Dia_Bar (
		id_bar INT NOT NULL IDENTITY (1,1)
		CHECK (id_bar >=1),
		total_gasto_bar FLOAT NOT NULL,
		total_recebido_bar FLOAT NOT NULL,
		lucro FLOAT NOT NULL,
		id_filial INT NOT NULL,
		id_dia INT NOT NULL,
		CONSTRAINT PK_Filial_Dia_Bar PRIMARY KEY (id_bar),
		FOREIGN KEY (id_filial)
			REFERENCES Filial(id_filial)
			ON UPDATE CASCADE,
		FOREIGN KEY (id_dia)
			REFERENCES Filial_Dia(id_dia),
);
end
