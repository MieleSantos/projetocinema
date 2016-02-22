create table cliente(
IdCliente number(5),
NomeCliente varchar2(20),
Email varchar2(20),
constraint IdCliente_pk primary key(IdCliente)
);

create table diretor(
IdDiretor number(5) not null,
NomeDiretor varchar2(40),
constraint IdDiretor_pk primary key(IdDiretor)
);

create table artista(
CodArtista number(5),
NomeArtista varchar2(50),
constraint CodArtista_pk primary key(CodArtista)
);

create table filme(
CodFilme number(5),
NomeFilme varchar2(50),
Categoria varchar2(20),
Classificacao varchar2(50),
Duracao number(6),
PaisOrigem varchar2(20),
CodigoDiretor number(5),
AnoDirecao number(4),
constraint CodFilme_pk primary key(CodFilme),
constraint CodDiretor_fk foreign key (CodigoDiretor)references diretor(IdDiretor)
);

create table atuaEm(
Codigo_Filme number(5),
IdArtista number(5),
constraint CodigoFilme_IdArtista_pk primary key(Codigo_Filme, IdArtista),
constraint CodFilme_fk foreign key(Codigo_Filme)references filme(CodFilme),
constraint IdArtista_fk foreign key(IdArtista)references artista(CodArtista)
);

Create table sessao(
NumeroSala number(5),
EmCartaz varchar2(50),
DataExibicao date,
Horario timestamp,
CodigoFilme number(5),
CodigoCinema number(5),
constraint NumeroSala_pk primary key(NumeroSala),
constraint NumeroSala_fk foreign key(CodigoCinema) references  cinema(CodCinema),
constraint CodigoFilme_fk foreign key(CodigoFilme) references filme(CodFilme)
);     

create table cinema(
CodCinema number(5) ,
NomeCinema varchar2(50),
Logradouro varchar2(50),
Bairro varchar2(50),
Numero number(4),
Cidade varchar2(30),
Estado varchar2(2),
constraint CodCinema_pk primary key(CodCinema),
constraint estado_ck check (Estado in ('AC','AL','AP', 'AM','BA','CE','DF','ES','GO','MA','MT','MS','MG','PA','PB','PR','PE','PI','RJ','RN','RS','RO','RR','SC','SP','SE','TO'))
);

create sequence se_clienteS increment by 1 start with 1 maxvalue 99999 nocycle nocache;
create sequence se_cinemaS increment by 1 start with 1 maxvalue 99999 nocycle nocache;
create sequence se_filmeS increment by 1 start with 1 maxvalue 99999 nocycle nocache;
create sequence se_sessaoS increment by 1 start with 1 maxvalue 99999 nocycle nocache;
create sequence se_atuacaoS increment by 1 start with 1 maxvalue 99999 nocycle nocache;
create sequence se_artistaS increment by 1 start with 1 maxvalue 99999 nocycle nocache;
create sequence se_diretorS increment by 1 start with 1 maxvalue 99999 nocycle nocache;

/*
drop sequence se_clienteS;
drop sequence se_cinemaS;
drop sequence se_filmeS;
drop sequence se_sessaoS;
drop sequence se_atuacaoS;
drop sequence se_artistaS;
drop sequence se_diretorS;


select * from cinema;
select * from cliente;
select * from sessao;
select * from filme;
select * from atuaEm;
select * from artista;

drop table cinema;
drop table cliente;
drop table sessao;
drop table atuaEm;
drop table filme;
drop table artista;
drop table diretor;
*/


/*

/*ARTISTA*/
Insert into ARTISTA (CODARTISTA,NOMEARTISTA) values ('1','Dwayne Johnson');
Insert into ARTISTA (CODARTISTA,NOMEARTISTA) values ('2','George Clooney');
Insert into ARTISTA (CODARTISTA,NOMEARTISTA) values ('3','Tom Hardy');
Insert into ARTISTA (CODARTISTA,NOMEARTISTA) values ('4','Cléo Pires');
Insert into ARTISTA (CODARTISTA,NOMEARTISTA) values ('5','Sam Rockwell');
Insert into ARTISTA (CODARTISTA,NOMEARTISTA) values ('6','Robert Downey');
Insert into ARTISTA (CODARTISTA,NOMEARTISTA) values ('7','Melissa McCarthy');
Insert into ARTISTA (CODARTISTA,NOMEARTISTA) values ('8','Adam Sandler');
Insert into ARTISTA (CODARTISTA,NOMEARTISTA) values ('9','Rihanna');
Insert into ARTISTA (CODARTISTA,NOMEARTISTA) values ('10','Junko takeuchi');
Insert into ARTISTA (CODARTISTA,NOMEARTISTA) values ('11','Owen Wilson');
Insert into ARTISTA (CODARTISTA,NOMEARTISTA) values ('12','Blake Lively');
Insert into ARTISTA (CODARTISTA,NOMEARTISTA) values ('13','Vin Diesel');
Insert into ARTISTA (CODARTISTA,NOMEARTISTA) values ('14','Guillaume Canet');
Insert into ARTISTA (CODARTISTA,NOMEARTISTA) values ('15','Olga Kurylenko');
Insert into ARTISTA (CODARTISTA,NOMEARTISTA) values ('16','Lily James');
Insert into ARTISTA (CODARTISTA,NOMEARTISTA) values ('17','Nikolaj Coster-Waldau');
Insert into ARTISTA (CODARTISTA,NOMEARTISTA) values ('18','Irandhir Santos');
Insert into ARTISTA (CODARTISTA,NOMEARTISTA) values ('19','Daniel de oliveira');
Insert into ARTISTA (CODARTISTA,NOMEARTISTA) values ('20','Ayane Ohmori');
Insert into ARTISTA (CODARTISTA,NOMEARTISTA) values ('21','Julia Hummer');
Insert into ARTISTA (CODARTISTA,NOMEARTISTA) values ('22','Holger Andersson');
Insert into ARTISTA (CODARTISTA,NOMEARTISTA) values ('23','Maria Alexandra');
Insert into ARTISTA (CODARTISTA,NOMEARTISTA) values ('24','Sharlto Copley');
Insert into ARTISTA (CODARTISTA,NOMEARTISTA) values ('25','Agnes Kittelsen');
Insert into ARTISTA (CODARTISTA,NOMEARTISTA) values ('26','Liam Neeson');
Insert into ARTISTA (CODARTISTA,NOMEARTISTA) values ('27','Patricio Guzmán');
Insert into ARTISTA (CODARTISTA,NOMEARTISTA) values ('28','Chris Pratt');
Insert into ARTISTA (CODARTISTA,NOMEARTISTA) values ('29','Masako Nozawa');
Insert into ARTISTA (CODARTISTA,NOMEARTISTA) values ('30','Sandra Bullock');
Insert into ARTISTA (CODARTISTA,NOMEARTISTA) values ('31','Tom silva');
Insert into ARTISTA (CODARTISTA,NOMEARTISTA) values ('32','Mariana xexer');
Insert into ARTISTA (CODARTISTA,NOMEARTISTA) values ('33','Carlos silva');
Insert into ARTISTA (CODARTISTA,NOMEARTISTA) values ('34','Toni santos');
Insert into ARTISTA (CODARTISTA,NOMEARTISTA) values ('35','Pedro souza');
Insert into ARTISTA (CODARTISTA,NOMEARTISTA) values ('37','Paulinha silva');

/*DIRETOR*/
Insert into DIRETOR (IDDIRETOR,NOMEDIRETOR) values ('1','Brad Peyton');
Insert into DIRETOR (IDDIRETOR,NOMEDIRETOR) values ('2','Brad Bird');
Insert into DIRETOR (IDDIRETOR,NOMEDIRETOR) values ('3','George Miller');
Insert into DIRETOR (IDDIRETOR,NOMEDIRETOR) values ('4','Roberto Santucci');
Insert into DIRETOR (IDDIRETOR,NOMEDIRETOR) values ('5','Gil Kenan');
Insert into DIRETOR (IDDIRETOR,NOMEDIRETOR) values ('6','Joss Whedon');
Insert into DIRETOR (IDDIRETOR,NOMEDIRETOR) values ('7','Paul Feig');
Insert into DIRETOR (IDDIRETOR,NOMEDIRETOR) values ('8','Thomas McCarthy');
Insert into DIRETOR (IDDIRETOR,NOMEDIRETOR) values ('9','Tim Johnson');
Insert into DIRETOR (IDDIRETOR,NOMEDIRETOR) values ('10','tsuneo Kobayashi');
Insert into DIRETOR (IDDIRETOR,NOMEDIRETOR) values ('11','Brad Lewis');
Insert into DIRETOR (IDDIRETOR,NOMEDIRETOR) values ('12','Lee toland Krieger');
Insert into DIRETOR (IDDIRETOR,NOMEDIRETOR) values ('13','James Wan');
Insert into DIRETOR (IDDIRETOR,NOMEDIRETOR) values ('14','André techiné');
Insert into DIRETOR (IDDIRETOR,NOMEDIRETOR) values ('15','Russell Crowe');
Insert into DIRETOR (IDDIRETOR,NOMEDIRETOR) values ('16','Kenneth Branagh');
Insert into DIRETOR (IDDIRETOR,NOMEDIRETOR) values ('17','Susanne Bier');
Insert into DIRETOR (IDDIRETOR,NOMEDIRETOR) values ('18','Leonardo Lacca');
Insert into DIRETOR (IDDIRETOR,NOMEDIRETOR) values ('19','Vicente Ferraz');
Insert into DIRETOR (IDDIRETOR,NOMEDIRETOR) values ('20','Masakasu Sugita');
Insert into DIRETOR (IDDIRETOR,NOMEDIRETOR) values ('21','Tatjana Turanskyj');
Insert into DIRETOR (IDDIRETOR,NOMEDIRETOR) values ('22','Roy a Andersson');
Insert into DIRETOR (IDDIRETOR,NOMEDIRETOR) values ('23','Alice Rohrwacher');
Insert into DIRETOR (IDDIRETOR,NOMEDIRETOR) values ('24','Neill Blomkamp');
Insert into DIRETOR (IDDIRETOR,NOMEDIRETOR) values ('25','Daniel Espinosa');
Insert into DIRETOR (IDDIRETOR,NOMEDIRETOR) values ('26','Anne Sewitsky');
Insert into DIRETOR (IDDIRETOR,NOMEDIRETOR) values ('27','Jaume Collet-Serra');
Insert into DIRETOR (IDDIRETOR,NOMEDIRETOR) values ('28','Patricio Guzmán');
Insert into DIRETOR (IDDIRETOR,NOMEDIRETOR) values ('29','Colin Trevorrow');
Insert into DIRETOR (IDDIRETOR,NOMEDIRETOR) values ('30','Tadayoshi Yamamuro');
Insert into DIRETOR (IDDIRETOR,NOMEDIRETOR) values ('31','Pierre Coffin');
Insert into DIRETOR (IDDIRETOR,NOMEDIRETOR) values ('32','Fernando');
Insert into DIRETOR (IDDIRETOR,NOMEDIRETOR) values ('33','Raimundo');
Insert into DIRETOR (IDDIRETOR,NOMEDIRETOR) values ('34','Regina ');
Insert into DIRETOR (IDDIRETOR,NOMEDIRETOR) values ('35','Paula souza');
Insert into DIRETOR (IDDIRETOR,NOMEDIRETOR) values ('36','Darlan');

/*FILMES*/
Insert into FILME (CODFILME,NOMEFILME,CATEGORIA,CLASSIFICACAO,DURACAO,PAISORIGEM,CODIGODIRETOR,ANODIRECAO) values ('1','Terremoto: a falha de san andreas','Ação','Acima de 12 anos','114','EUA','1','2015');
Insert into FILME (CODFILME,NOMEFILME,CATEGORIA,CLASSIFICACAO,DURACAO,PAISORIGEM,CODIGODIRETOR,ANODIRECAO) values ('2','Tomorrowland: Um lugar onde nada é impossível','Ficção Cientifica','Acima  de 10 anos','130','EUA','2','2015');
Insert into FILME (CODFILME,NOMEFILME,CATEGORIA,CLASSIFICACAO,DURACAO,PAISORIGEM,CODIGODIRETOR,ANODIRECAO) values ('3','Mad Max: Estrada da Fúria','Ação','Acima  de  16 anos','120','Austrália','3','2015');
Insert into FILME (CODFILME,NOMEFILME,CATEGORIA,CLASSIFICACAO,DURACAO,PAISORIGEM,CODIGODIRETOR,ANODIRECAO) values ('4','Qualquer Gato vira-Lata 2','Comedia Romantica','Acima de 12 anos','104','Brasil','4','2015');
Insert into FILME (CODFILME,NOMEFILME,CATEGORIA,CLASSIFICACAO,DURACAO,PAISORIGEM,CODIGODIRETOR,ANODIRECAO) values ('5','Poltergeist - O fenômeno','Terror','Acima de 12 anos','134','EUA','5','2015');
Insert into FILME (CODFILME,NOMEFILME,CATEGORIA,CLASSIFICACAO,DURACAO,PAISORIGEM,CODIGODIRETOR,ANODIRECAO) values ('6','Vingadores: Era de Ultron','Ficção Cientifica','Acima de 12 anos','144','EUA','6','2015');
Insert into FILME (CODFILME,NOMEFILME,CATEGORIA,CLASSIFICACAO,DURACAO,PAISORIGEM,CODIGODIRETOR,ANODIRECAO) values ('7','A Espiã que sabia de menos','Comedia','Acima  de 14 anos','120','EUA','7','2015');
Insert into FILME (CODFILME,NOMEFILME,CATEGORIA,CLASSIFICACAO,DURACAO,PAISORIGEM,CODIGODIRETOR,ANODIRECAO) values ('8','Trocando os pés','Drama','Acima  de 14 anos','102','EUA','8','2015');
Insert into FILME (CODFILME,NOMEFILME,CATEGORIA,CLASSIFICACAO,DURACAO,PAISORIGEM,CODIGODIRETOR,ANODIRECAO) values ('9','Cada um na sua casa','Animação','Livre ','94','EUA','9','2015');
Insert into FILME (CODFILME,NOMEFILME,CATEGORIA,CLASSIFICACAO,DURACAO,PAISORIGEM,CODIGODIRETOR,ANODIRECAO) values ('10','The last: naruto o filme','Animação','Acima  de 10 anos','113','Japão','10','2015');
Insert into FILME (CODFILME,NOMEFILME,CATEGORIA,CLASSIFICACAO,DURACAO,PAISORIGEM,CODIGODIRETOR,ANODIRECAO) values ('11','Carros 2','Animação','Livre ','102','EUA','11','2011');
Insert into FILME (CODFILME,NOMEFILME,CATEGORIA,CLASSIFICACAO,DURACAO,PAISORIGEM,CODIGODIRETOR,ANODIRECAO) values ('12','A incrível história de Adeline','Drama','Acima de 12 anos','113','EUA','1','2015');
Insert into FILME (CODFILME,NOMEFILME,CATEGORIA,CLASSIFICACAO,DURACAO,PAISORIGEM,CODIGODIRETOR,ANODIRECAO) values ('13','Velozes & Furiosos 7','Ação','Acima  de 14 anos','137','EUA','13','2015');
Insert into FILME (CODFILME,NOMEFILME,CATEGORIA,CLASSIFICACAO,DURACAO,PAISORIGEM,CODIGODIRETOR,ANODIRECAO) values ('14','O homem que elas amavam demais','Drama','Acima  de  16 anos','106','França','14','2015');
Insert into FILME (CODFILME,NOMEFILME,CATEGORIA,CLASSIFICACAO,DURACAO,PAISORIGEM,CODIGODIRETOR,ANODIRECAO) values ('15','Promessas de guerra','Guerra','Acima de 12 anos','111','Turquia','1','2015');
Insert into FILME (CODFILME,NOMEFILME,CATEGORIA,CLASSIFICACAO,DURACAO,PAISORIGEM,CODIGODIRETOR,ANODIRECAO) values ('16','Cinderela','Romance','Livre ','104','EUA','16','2015');
Insert into FILME (CODFILME,NOMEFILME,CATEGORIA,CLASSIFICACAO,DURACAO,PAISORIGEM,CODIGODIRETOR,ANODIRECAO) values ('17','Segunda Chance','Suspense','Acima  de 14 anos','104','Dinamarca','17','2014');
Insert into FILME (CODFILME,NOMEFILME,CATEGORIA,CLASSIFICACAO,DURACAO,PAISORIGEM,CODIGODIRETOR,ANODIRECAO) values ('18','Permanência','Drama','Acima  de 14 anos','85','Brasil','18','2014');
Insert into FILME (CODFILME,NOMEFILME,CATEGORIA,CLASSIFICACAO,DURACAO,PAISORIGEM,CODIGODIRETOR,ANODIRECAO) values ('19','A estrada 47','Guerra','Acima de 12 anos','107','Brasil','19','2013');
Insert into FILME (CODFILME,NOMEFILME,CATEGORIA,CLASSIFICACAO,DURACAO,PAISORIGEM,CODIGODIRETOR,ANODIRECAO) values ('20','O desejo da minha alma','Drama','Acima de 12 anos','85','Japão','20','2014');
Insert into FILME (CODFILME,NOMEFILME,CATEGORIA,CLASSIFICACAO,DURACAO,PAISORIGEM,CODIGODIRETOR,ANODIRECAO) values ('21','Top Girl ou a Deformação profissional','Drama','Acima  de  18 anos','99','Alemanha','21','2014');
Insert into FILME (CODFILME,NOMEFILME,CATEGORIA,CLASSIFICACAO,DURACAO,PAISORIGEM,CODIGODIRETOR,ANODIRECAO) values ('22','Um pombo pousou num galho reflitinndo sobre a exis','Comedia Romantica','Acima  de 14 anos','100','Suécia','22','2014');
Insert into FILME (CODFILME,NOMEFILME,CATEGORIA,CLASSIFICACAO,DURACAO,PAISORIGEM,CODIGODIRETOR,ANODIRECAO) values ('23','As Maravilhas','Drama','Acima de 12 anos','111','Itália','23','2014');
Insert into FILME (CODFILME,NOMEFILME,CATEGORIA,CLASSIFICACAO,DURACAO,PAISORIGEM,CODIGODIRETOR,ANODIRECAO) values ('24','Chappie','Ficção Cientifica','Acima  de  16 anos','114','EUA','24','2015');
Insert into FILME (CODFILME,NOMEFILME,CATEGORIA,CLASSIFICACAO,DURACAO,PAISORIGEM,CODIGODIRETOR,ANODIRECAO) values ('25','Crimes Ocultos','Suspense','Acima  de  16 anos','138','EUA','25','2015');
Insert into FILME (CODFILME,NOMEFILME,CATEGORIA,CLASSIFICACAO,DURACAO,PAISORIGEM,CODIGODIRETOR,ANODIRECAO) values ('26','Happy,Happy','Comedia Romantica','Acima  de 14 anos','88','Noruega','26','2011');
Insert into FILME (CODFILME,NOMEFILME,CATEGORIA,CLASSIFICACAO,DURACAO,PAISORIGEM,CODIGODIRETOR,ANODIRECAO) values ('27','Noite sem fim','Crime','Acima  de  16 anos','114','Eua','27','2015');
Insert into FILME (CODFILME,NOMEFILME,CATEGORIA,CLASSIFICACAO,DURACAO,PAISORIGEM,CODIGODIRETOR,ANODIRECAO) values ('28','Nostalgia da luz','Drama','Acima de 12 anos','90','França','28','2010');
Insert into FILME (CODFILME,NOMEFILME,CATEGORIA,CLASSIFICACAO,DURACAO,PAISORIGEM,CODIGODIRETOR,ANODIRECAO) values ('29','Jurassic World: O mundo dos dinossauros','Aventura','Acima  de 14 anos','125','EUA','29','2015');
Insert into FILME (CODFILME,NOMEFILME,CATEGORIA,CLASSIFICACAO,DURACAO,PAISORIGEM,CODIGODIRETOR,ANODIRECAO) values ('30','Dragon ball z - O renascimento de freeza','Animação','Acima de 12 anos','93','Japão','30','2015');
Insert into FILME (CODFILME,NOMEFILME,CATEGORIA,CLASSIFICACAO,DURACAO,PAISORIGEM,CODIGODIRETOR,ANODIRECAO) values ('31','Minions','Animação','Livre ','90','EUA','31','2015');
Insert into FILME (CODFILME,NOMEFILME,CATEGORIA,CLASSIFICACAO,DURACAO,PAISORIGEM,CODIGODIRETOR,ANODIRECAO) values ('32','AS branquelas','Comedia','Acima de 10 anos','105','EUA','1','2014');
Insert into FILME (CODFILME,NOMEFILME,CATEGORIA,CLASSIFICACAO,DURACAO,PAISORIGEM,CODIGODIRETOR,ANODIRECAO) values ('33','Goku o filme','Ação','Acima de 16 anos','100','EUA','2','2010');
Insert into FILME (CODFILME,NOMEFILME,CATEGORIA,CLASSIFICACAO,DURACAO,PAISORIGEM,CODIGODIRETOR,ANODIRECAO) values ('34','O exocista','Terror','Acima de 18 anos','85','EUA','3','2009');
Insert into FILME (CODFILME,NOMEFILME,CATEGORIA,CLASSIFICACAO,DURACAO,PAISORIGEM,CODIGODIRETOR,ANODIRECAO) values ('35','velozes e furiozos','Corrida','Acima de 10 anos','96','EUA','4','2008');
Insert into FILME (CODFILME,NOMEFILME,CATEGORIA,CLASSIFICACAO,DURACAO,PAISORIGEM,CODIGODIRETOR,ANODIRECAO) values ('36','O senhor dos Aneis','Aventura','Acima de 10 anos','189','Brasil','5','2010');
Insert into FILME (CODFILME,NOMEFILME,CATEGORIA,CLASSIFICACAO,DURACAO,PAISORIGEM,CODIGODIRETOR,ANODIRECAO) values ('38','O viajante','Terror','Acima de 18 anos','85','EUA','3','2009');
/*CINEMAS*/
Insert into CINEMA (CODCINEMA,NOMECINEMA,LOGRADOURO,BAIRRO,NUMERO,CIDADE,ESTADO) values ('1','UCI Cinemas(Shopping Anália Franco)','Reg. Freijó','Jardim  Analia Franco','1739','São Paulo','SP');
Insert into CINEMA (CODCINEMA,NOMECINEMA,LOGRADOURO,BAIRRO,NUMERO,CIDADE,ESTADO) values ('2','Cinemark','Piracema','Tamboré','669','Barueri','SP');
Insert into CINEMA (CODCINEMA,NOMECINEMA,LOGRADOURO,BAIRRO,NUMERO,CIDADE,ESTADO) values ('3','CineSystem Cinemas','Av. Maestro Paulo e Silva','Ilha do Governador','400','Rio de Janeiro','RJ');
Insert into CINEMA (CODCINEMA,NOMECINEMA,LOGRADOURO,BAIRRO,NUMERO,CIDADE,ESTADO) values ('4','Cinemas','Av. Dom Hélder Câmara,','Cachambi','5474','Rio de Janeiro','RJ');
Insert into CINEMA (CODCINEMA,NOMECINEMA,LOGRADOURO,BAIRRO,NUMERO,CIDADE,ESTADO) values ('5','Cinemark','Rua Quinze de Novembro','Centro','8','Niterói','RJ');
Insert into CINEMA (CODCINEMA,NOMECINEMA,LOGRADOURO,BAIRRO,NUMERO,CIDADE,ESTADO) values ('6','Playarte-Abc','Pereira barreto','Santo Andre','45','São Paulo','SP');
Insert into CINEMA (CODCINEMA,NOMECINEMA,LOGRADOURO,BAIRRO,NUMERO,CIDADE,ESTADO) values ('7','Cine São Carlos','Maj. José Inácio','Centro','2154','São Carlos','SP');
Insert into CINEMA (CODCINEMA,NOMECINEMA,LOGRADOURO,BAIRRO,NUMERO,CIDADE,ESTADO) values ('8','Cinema Iguateni','Passeio  dos Flamboyants','Centro','0','São Carlos','SP');
Insert into CINEMA (CODCINEMA,NOMECINEMA,LOGRADOURO,BAIRRO,NUMERO,CIDADE,ESTADO) values ('9','Centerplex Cinemas','Av. Carlos Kuntz Busch,','Parque Egisto Ragazzo','800','Limeira','SP');
Insert into CINEMA (CODCINEMA,NOMECINEMA,LOGRADOURO,BAIRRO,NUMERO,CIDADE,ESTADO) values ('10','Arcoplex','R. Carlos Gomes','Centro','1321','Limeira','SP');
Insert into CINEMA (CODCINEMA,NOMECINEMA,LOGRADOURO,BAIRRO,NUMERO,CIDADE,ESTADO) values ('11','Arcoplex Cinemas','Av. Conde Francisco Matarazzo','Vila Paulista','205','Rio Claro','SP');
Insert into CINEMA (CODCINEMA,NOMECINEMA,LOGRADOURO,BAIRRO,NUMERO,CIDADE,ESTADO) values ('12','Kinoplex','Av. Guilherme Campos','Jardim Santa Genebra','500','Campinas','SP');
Insert into CINEMA (CODCINEMA,NOMECINEMA,LOGRADOURO,BAIRRO,NUMERO,CIDADE,ESTADO) values ('13','Box Cinemas','R. Jacy Teixeira de Camargo','Jardim do Lago','940','Campinas','SP');
Insert into CINEMA (CODCINEMA,NOMECINEMA,LOGRADOURO,BAIRRO,NUMERO,CIDADE,ESTADO) values ('14','Movieplex Cinemas','Av. John Boyd Dunlop','Cambuí','350','Campinas ','SP');
Insert into CINEMA (CODCINEMA,NOMECINEMA,LOGRADOURO,BAIRRO,NUMERO,CIDADE,ESTADO) values ('15','UCI Oriente Ltda',' Av.Tancredo Neves','Caminhos das Arvores','148','Salvador','BA');
Insert into CINEMA (CODCINEMA,NOMECINEMA,LOGRADOURO,BAIRRO,NUMERO,CIDADE,ESTADO) values ('16','Orient Cineplace','Av. João Durval Carneiro','São João','3665','Feira de  Santana','BA');
Insert into CINEMA (CODCINEMA,NOMECINEMA,LOGRADOURO,BAIRRO,NUMERO,CIDADE,ESTADO) values ('17','CinéPolis','Alameda Euvaldo','Horto de Bela Vista','92','Salvador','BA');
Insert into CINEMA (CODCINEMA,NOMECINEMA,LOGRADOURO,BAIRRO,NUMERO,CIDADE,ESTADO) values ('18','Cine Sytsem','Brg. Franco','Centro','2300','Curitiba','PR');
Insert into CINEMA (CODCINEMA,NOMECINEMA,LOGRADOURO,BAIRRO,NUMERO,CIDADE,ESTADO) values ('19','Cineplus','Av.Nossa senhora de Lourdes','Jardim das Américas','63','Curitiba','PR');
Insert into CINEMA (CODCINEMA,NOMECINEMA,LOGRADOURO,BAIRRO,NUMERO,CIDADE,ESTADO) values ('20','Cine São João','rua Des Westphalen','Centro','165','Curitiba','PR');
Insert into CINEMA (CODCINEMA,NOMECINEMA,LOGRADOURO,BAIRRO,NUMERO,CIDADE,ESTADO) values ('21','Cinema Severiano Ribeiro','Comendador araújo','Centro','731','Curitiba','PR');
Insert into CINEMA (CODCINEMA,NOMECINEMA,LOGRADOURO,BAIRRO,NUMERO,CIDADE,ESTADO) values ('22','Cinemark','rua professor Pedro Viriato Parigot de souza','mossunguê','600','Curitiba','PR');
Insert into CINEMA (CODCINEMA,NOMECINEMA,LOGRADOURO,BAIRRO,NUMERO,CIDADE,ESTADO) values ('23','Cinemark Brasil Sa','Av.General rodrigo otavio','Distr Industrial','555','Manaus','AM');
Insert into CINEMA (CODCINEMA,NOMECINEMA,LOGRADOURO,BAIRRO,NUMERO,CIDADE,ESTADO) values ('24','CineP','rua das tres rosas','copacabana','1740','Rio de Janeiro','RJ');
Insert into CINEMA (CODCINEMA,NOMECINEMA,LOGRADOURO,BAIRRO,NUMERO,CIDADE,ESTADO) values ('25','CineManaus','rua do teatro','Maracaizinho','504','Manaus','AM');
Insert into CINEMA (CODCINEMA,NOMECINEMA,LOGRADOURO,BAIRRO,NUMERO,CIDADE,ESTADO) values ('26','CineMax','rua das rosas','Pacaembu','2365','São paulo','SP');
Insert into CINEMA (CODCINEMA,NOMECINEMA,LOGRADOURO,BAIRRO,NUMERO,CIDADE,ESTADO) values ('27','CineBahia','rua da cine','Barra','1045','Salvador','BA');
Insert into CINEMA (CODCINEMA,NOMECINEMA,LOGRADOURO,BAIRRO,NUMERO,CIDADE,ESTADO) values ('28','Cine','rua da cine','paulistano','254','sao carlos','SP');


/*SESSAO*/
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('1',to_date('05/06/15','DD/MM/RR'),to_timestamp('05/06/15 18:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'1','1');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('2',to_date('05/06/15','DD/MM/RR'),to_timestamp('05/06/15 20:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'2','1');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('3',to_date('05/06/15','DD/MM/RR'),to_timestamp('05/06/15 22:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'3','1');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('4',to_date('06/06/15','DD/MM/RR'),to_timestamp('06/06/15 15:30:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'1','2');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('5',to_date('07/06/15','DD/MM/RR'),to_timestamp('07/06/15 18:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'3','2');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('6',to_date('06/06/15','DD/MM/RR'),to_timestamp('06/06/15 20:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'4','2');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('7',to_date('07/06/15','DD/MM/RR'),to_timestamp('07/06/15 15:30:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'1','17');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('8',to_date('07/06/15','DD/MM/RR'),to_timestamp('07/06/15 18:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'2','17');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('9',to_date('07/06/15','DD/MM/RR'),to_timestamp('07/06/15 20:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'3','17');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('10',to_date('07/06/15','DD/MM/RR'),to_timestamp('07/06/15 22:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'4','17');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('11',to_date('08/06/15','DD/MM/RR'),to_timestamp('08/06/15 20:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'5','17');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('12',to_date('07/06/15','DD/MM/RR'),to_timestamp('07/06/15 18:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'14','17');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('13',to_date('07/06/15','DD/MM/RR'),to_timestamp('07/06/15 18:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'1','12');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('14',to_date('07/06/15','DD/MM/RR'),to_timestamp('07/06/15 20:30:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'1','12');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('15',to_date('07/06/15','DD/MM/RR'),to_timestamp('07/06/15 22:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'20','12');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('16',to_date('15/07/15','DD/MM/RR'),to_timestamp('15/07/15 20:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'31','12');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('17',to_date('07/06/15','DD/MM/RR'),to_timestamp('07/06/15 15:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'31','12');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('18',to_date('07/06/15','DD/MM/RR'),to_timestamp('07/06/15 18:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'31','12');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('19',to_date('14/06/15','DD/MM/RR'),to_timestamp('14/06/15 15:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'30','12');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('20',to_date('14/06/15','DD/MM/RR'),to_timestamp('14/06/15 18:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'30','12');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('21',to_date('14/06/15','DD/MM/RR'),to_timestamp('14/06/15 20:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'30','12');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('22',to_date('14/06/15','DD/MM/RR'),to_timestamp('14/06/15 22:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'12','12');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('23',to_date('07/06/15','DD/MM/RR'),to_timestamp('07/06/15 15:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'1','3');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('24',to_date('07/06/15','DD/MM/RR'),to_timestamp('07/06/15 16:30:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'2','3');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('25',to_date('07/06/15','DD/MM/RR'),to_timestamp('07/06/15 18:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'4','3');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('26',to_date('07/06/15','DD/MM/RR'),to_timestamp('07/06/15 19:45:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'6','3');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('27',to_date('07/06/15','DD/MM/RR'),to_timestamp('07/06/15 20:50:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'6','3');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('28',to_date('07/06/15','DD/MM/RR'),to_timestamp('07/06/15 22:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'6','3');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('29',to_date('08/06/15','DD/MM/RR'),to_timestamp('08/06/15 18:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'7','3');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('30',to_date('07/06/15','DD/MM/RR'),to_timestamp('07/06/15 20:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'8','3');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('31',to_date('09/06/15','DD/MM/RR'),to_timestamp('09/06/15 15:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'9','3');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('32',to_date('09/06/15','DD/MM/RR'),to_timestamp('09/06/15 15:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'10','3');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('33',to_date('09/06/15','DD/MM/RR'),to_timestamp('09/06/15 16:45:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'10','3');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('34',to_date('09/06/15','DD/MM/RR'),to_timestamp('09/06/15 18:10:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'10','3');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('35',to_date('07/06/15','DD/MM/RR'),to_timestamp('07/06/15 18:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'24','4');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('36',to_date('07/06/15','DD/MM/RR'),to_timestamp('07/06/15 20:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'3','4');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('37',to_date('08/06/15','DD/MM/RR'),to_timestamp('08/06/15 15:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'11','4');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('38',to_date('09/06/15','DD/MM/RR'),to_timestamp('09/06/15 15:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'16','4');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('39',to_date('09/06/15','DD/MM/RR'),to_timestamp('09/06/15 20:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'19','4');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('40',to_date('10/06/15','DD/MM/RR'),to_timestamp('10/06/15 18:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'13','4');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('41',to_date('10/06/15','DD/MM/RR'),to_timestamp('10/06/15 20:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'13','4');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('42',to_date('10/06/15','DD/MM/RR'),to_timestamp('10/06/15 22:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'13','4');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('43',to_date('18/06/15','DD/MM/RR'),to_timestamp('18/06/15 20:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'29','4');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('44',to_date('18/06/15','DD/MM/RR'),to_timestamp('18/06/15 22:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'29','4');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('45',to_date('11/06/15','DD/MM/RR'),to_timestamp('11/06/15 18:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'30','4');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('46',to_date('11/06/15','DD/MM/RR'),to_timestamp('11/06/15 20:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'30','4');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('47',to_date('07/06/15','DD/MM/RR'),to_timestamp('07/06/15 18:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'6','23');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('48',to_date('07/06/15','DD/MM/RR'),to_timestamp('07/06/15 20:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'6','23');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('49',to_date('07/06/15','DD/MM/RR'),to_timestamp('07/06/15 22:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'6','23');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('50',to_date('08/06/15','DD/MM/RR'),to_timestamp('08/06/15 18:30:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'3','23');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('51',to_date('08/06/15','DD/MM/RR'),to_timestamp('08/06/15 20:30:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'3','23');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('52',to_date('08/06/15','DD/MM/RR'),to_timestamp('08/06/15 20:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'5','23');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('53',to_date('07/06/15','DD/MM/RR'),to_timestamp('07/06/15 18:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'1','7');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('54',to_date('07/06/15','DD/MM/RR'),to_timestamp('07/06/15 20:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'1','7');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('55',to_date('07/06/15','DD/MM/RR'),to_timestamp('07/06/15 22:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'1','7');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('56',to_date('08/06/15','DD/MM/RR'),to_timestamp('08/06/15 15:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'11','7');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('57',to_date('08/06/15','DD/MM/RR'),to_timestamp('08/06/15 16:30:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'16','7');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('58',to_date('08/06/15','DD/MM/RR'),to_timestamp('08/06/15 18:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'25','7');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('59',to_date('08/06/15','DD/MM/RR'),to_timestamp('08/06/15 20:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'27','7');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('60',to_date('17/07/15','DD/MM/RR'),to_timestamp('17/07/15 18:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'29','7');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('61',to_date('17/07/15','DD/MM/RR'),to_timestamp('17/07/15 20:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'29','7');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('62',to_date('17/07/15','DD/MM/RR'),to_timestamp('17/07/15 22:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'29','7');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('63',to_date('17/07/15','DD/MM/RR'),to_timestamp('17/07/15 18:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'29','8');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('64',to_date('17/07/15','DD/MM/RR'),to_timestamp('17/07/15 20:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'29','8');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('65',to_date('17/07/15','DD/MM/RR'),to_timestamp('17/07/15 22:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'29','8');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('66',to_date('07/06/15','DD/MM/RR'),to_timestamp('07/06/15 18:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'10','8');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('67',to_date('08/06/15','DD/MM/RR'),to_timestamp('08/06/15 20:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'7','8');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('68',to_date('07/06/15','DD/MM/RR'),to_timestamp('07/06/15 15:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'11','8');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('69',to_date('08/06/15','DD/MM/RR'),to_timestamp('08/06/15 15:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'16','8');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('70',to_date('08/06/15','DD/MM/RR'),to_timestamp('08/06/15 13:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'1','11');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('71',to_date('08/06/15','DD/MM/RR'),to_timestamp('08/06/15 15:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'1','11');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('72',to_date('09/06/15','DD/MM/RR'),to_timestamp('09/06/15 19:30:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'2','11');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('73',to_date('10/06/15','DD/MM/RR'),to_timestamp('10/06/15 18:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'6','11');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('74',to_date('08/06/15','DD/MM/RR'),to_timestamp('08/06/15 20:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'6','11');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('75',to_date('12/06/15','DD/MM/RR'),to_timestamp('12/06/15 19:30:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'13','11');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('76',to_date('08/06/15','DD/MM/RR'),to_timestamp('08/06/15 22:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'21','10');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('77',to_date('09/06/15','DD/MM/RR'),to_timestamp('09/06/15 19:30:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'24','10');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('78',to_date('10/06/15','DD/MM/RR'),to_timestamp('10/06/15 19:30:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'13','10');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('79',to_date('17/07/15','DD/MM/RR'),to_timestamp('17/07/15 19:30:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'29','10');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('80',to_date('17/07/15','DD/MM/RR'),to_timestamp('17/07/15 15:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'30','9');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('81',to_date('08/06/15','DD/MM/RR'),to_timestamp('08/06/15 19:30:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'20','9');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('82',to_date('09/06/15','DD/MM/RR'),to_timestamp('09/06/15 20:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'13','9');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('83',to_date('10/02/18','DD/MM/RR'),to_timestamp('10/02/15 20:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'1','1');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('84',to_date('10/02/18','DD/MM/RR'),to_timestamp('11/02/15 19:02:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'2','2');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('85',to_date('10/02/18','DD/MM/RR'),to_timestamp('15/02/18 18:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'1','3');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('86',to_date('10/02/18','DD/MM/RR'),to_timestamp('10/02/18 18:30:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'2','4');
Insert into SESSAO (NUMEROSALA,DATAEXIBICAO,HORARIO,CODIGOFILME,CODIGOCINEMA) values ('87',to_date('10/02/18','DD/MM/RR'),to_timestamp('25/12/15 20:00:00,000000000','DD/MM/RR HH24:MI:SSXFF'),'1','5');

COMMIT;
*/
