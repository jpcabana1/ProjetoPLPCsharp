
--create table tbUser(
--	id int primary key,
--	nome varchar(100)
--);

--select * from tbUser

--insert into tbUser(id,nome) values(2,'Pitt')

--use PRODOC

--ALTER TABLE tbDocente
--  ADD UserStatus varchar(50)

--insert into tbDocente(Nome, Titulo, TempoXP, Usuario, Cargo, Senha) values ('ADM', 'Administrador', 100, 'admin', 'Administrador', 'a')

--insert into tbAtividade(descricao, pontucao,status,CodProf) values('Tradução de Livro', 4, 'PEDENTE',2)

--update tbDocente set Nome = 'Wagner', Cargo = 'Professor Auxiliar III', Titulo = 'Mestre', TempoXP = 4, Usuario = 'ww', Senha = '123' where id = 1002

select * from tbAtividade --where CodProf = 2

select * from tbDocente

--delete from tbDocente where id = 1005

--delete from tbAtividade where CodProf = 1005

--alter table tbDocente
--add Constraint Usuario UNIQUE(Usuario)
--update tbDocente set UserStatus = 'ADM' where Id = 1004

--Select * From tbAtividade where CodProf = '1006' 

--update tbAtividade set status = 'PENDENTE'

--Select * From tbAtividade where Status = '1' 

--create table tbdocumento(
--	int CodAtiv not null,
--	Photo varbinary(max) not null
--	FOREIGN KEY (CodAtiv) REFERENCES tbAtividade(CodAtiv)
--)

--update tbDocente  set  
--Nome = 'Wagner',  
--Titulo = 'Mestre',  
--TempoXP = 4,  
--Usuario = 'wg',  
--Cargo = 'Professor Auxiliar I',  
--Senha = '123',  
--UserStatus = 'DOC'  
--where id = 1002

--update tbAtividade set Descricao = 'Tradução de Livro', Pontuacao = 4, Status = AVALIANDO where CodAtiv = 1

