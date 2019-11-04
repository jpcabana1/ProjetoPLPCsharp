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

--delete from tbDocente where id = 2

--delete from tbAtividade where CodProf = 3

--alter table tbDocente
--add Constraint Usuario UNIQUE(Usuario)
--update tbDocente set UserStatus = 'ADM' where Id = 1004

--Select * From tbAtividade where CodProf = '1' 

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

--select * from tbDocente where Id = 1002

--Select * From tbDocente where Usuario =  'admin'  and Senha = 'a' 

--update tbDocente set Titulo = 'Mestre' , Cargo = 'Professor Auxiliar' where Id = 1007


--create table tbCargo(
--	Cargo varchar(50),
--	pontuacao int,
--	tempo int,
--	Vagas int
--);



--update tbCargo set Vagas = 300

select * from tbCargo

--drop table tbCargo

--Professor Assistente I - 20
--Professor Assistente II - 30
--Professor Assistente III - 50
--Professor Assistente IV - 60
--Professor Adjunto I - 150 - 4 anos
--Professor Adjunto II - 150
--Professor Adjunto III - 150
--Professor Adjunto IV - 150
--Professor Titular - 300 - 6 anos

--insert into tbCargo(Cargo, pontuacao, tempo ,vagas) values ('Professor Assistente I', 20, 3, 70)
--insert into tbCargo(Cargo, pontuacao, tempo ,vagas) values ('Professor Assistente II', 30, 3, 60)
--insert into tbCargo(Cargo, pontuacao, tempo ,vagas) values ('Professor Assistente II', 50, 3, 50)
--insert into tbCargo(Cargo, pontuacao, tempo ,vagas) values ('Professor Assistente IV', 60, 3, 40)
--insert into tbCargo(Cargo, pontuacao, tempo ,vagas) values ('Professor Adjunto I', 150, 4, 30)
--insert into tbCargo(Cargo, pontuacao, tempo ,vagas) values ('Professor Adjunto II', 150, 3, 20)
--insert into tbCargo(Cargo, pontuacao, tempo ,vagas) values ('Professor Adjunto III', 150, 3, 10)
--insert into tbCargo(Cargo, pontuacao, tempo ,vagas) values ('Professor Adjunto IV', 150, 3, 5)
--insert into tbCargo(Cargo, pontuacao, tempo ,vagas) values ('Professor Titular I', 300, 6, 1)




select * from tbCargo



