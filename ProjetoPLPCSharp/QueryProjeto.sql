--create table tbUser(
--	id int primary key,
--	nome varchar(100)
--);

--select * from tbUser

--insert into tbUser(id,nome) values(2,'Pitt')

--use PRODOC

--ALTER TABLE tbDocente
--  ADD Senha varchar(50) not null

--insert into tbDocente(Nome, Titulo, TempoXP, Usuario, Cargo, Senha) values ('João Pitt', 'Mestre', 3, 'pitt', 'Professor Auxiliar', '123')

--insert into tbAtividade(descricao, pontucao,status,CodProf) values('Tradução de Livro', 4, 'PEDENTE',2)

--update tbDocente set Nome = 'Wagner', Cargo = 'Professor Auxiliar III', Titulo = 'Mestre', TempoXP = 4, Usuario = 'ww', Senha = '123' where id = 1002

select * from tbAtividade --where CodProf = 2

select * from tbDocente

--delete from tbDocente where id = 2

--delete from tbAtividade where CodProf = 2



--alter table tbDocente
--add Constraint Usuario UNIQUE(Usuario)
