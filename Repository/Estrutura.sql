CREATE TABLE pessoas (
	id INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(100),
	sobrenome VARCHAR(100),
	registro_ativo BIT

);

INSERT INTO pessoas(nome, sobrenome, registro_ativo) VALUES
('Pamilla', 'Silva', 1);