CREATE DATABASE CadastrarPacientes;
USE CadastrarPacientes;

CREATE TABLE IF NOT EXISTS Pacientes(
	IdPaciente INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(150) NOT NULL,
    Cpf VARCHAR(15),
    Email VARCHAR(100),
    Telefone VARCHAR(10),
    DataNascimento DATE
 );  
