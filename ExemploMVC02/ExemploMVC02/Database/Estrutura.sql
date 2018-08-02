CREATE TABLE recrutadoras(
	id INT IDENTITY(1,1) PRIMARY KEY,
	nome VARCHAR(100) NOT NULL,
	cpf CHAR(11) NOT NULL,
	tempo_empresa SMALLINT,
	salario DECIMAL(12,2)
)

INSERT INTO recrutadoras
(nome, cpf, tempo_empresa, salario) VALUES
('Doufim', '07611034901', 2, 10000.00),
('Joafim', '00154778452', 3, 20000.00),
('Cafim', '88774114447', 4, 1500.00);