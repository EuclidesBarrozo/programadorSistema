--
-- Arquivo gerado com SQLiteStudio v3.4.4 em seg abr 29 09:05:36 2024
--
-- Codificação de texto usada: System
--
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

-- Tabela: t_curriculos
CREATE TABLE IF NOT EXISTS t_curriculos (id INTEGER PRIMARY KEY, nome TEXT NOT NULL UNIQUE, telefone TEXT NOT NULL, dataNascimento TEXT NOT NULL, escolaridade TEXT NOT NULL, profissao1 TEXT NOT NULL, profissao2 TEXT, curso1 TEXT NOT NULL, curso2 TEXT);
INSERT INTO t_curriculos (id, nome, telefone, dataNascimento, escolaridade, profissao1, profissao2, curso1, curso2) VALUES (1, 'Areovaldo', '8899998888', '20-01-2000', 'Ensino Técnico', 'manutenção de computadores', 'design gráfico', 'montagem e manutenção de computadores', 'webdesigner');
INSERT INTO t_curriculos (id, nome, telefone, dataNascimento, escolaridade, profissao1, profissao2, curso1, curso2) VALUES (2, 'Pedro', '8899998888', '20-01-2000', 'Ensino Técnico', 'manutenção de computadores', NULL, 'montagem e manutenção de computadores', NULL);

-- Tabela: t_usuarios
CREATE TABLE IF NOT EXISTS t_usuarios (id INTEGER PRIMARY KEY AUTOINCREMENT, usuario TEXT (50) NOT NULL, senha TEXT (20) NOT NULL);
INSERT INTO t_usuarios (id, usuario, senha) VALUES (1, 'Ana', '123');
INSERT INTO t_usuarios (id, usuario, senha) VALUES (2, 'Euclides', '321');
INSERT INTO t_usuarios (id, usuario, senha) VALUES (3, 'Jonicleide', '852');

COMMIT TRANSACTION;
PRAGMA foreign_keys = on;
