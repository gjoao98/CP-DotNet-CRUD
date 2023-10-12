2TDST

| RM | Nome |
|--|--|
| 94170 | Felipe Breno Sugisawa Altran|
| 93187 | Gabriel João da Silva|
| 94266 | Vinicius Alves Torres|
| 92895 | Vinicius Yuji Nishioka|

### Como Implantar projeto na nuvem
1. Criar recurso de banco de dados sql server 
2. Pegar string de conexão do banco e colocar no projeto .net
3. Testar localmente se a aplicação está fazendo registro na nuvem
4. Subir projeto atualizado no github
5. Criar recurso de web app conectando com o github actions
6. Realizar deploy



### DDL Tabelas
```sql
-- DDL for Tb_Developer table
CREATE TABLE Tb_Developer (
    Id INT PRIMARY KEY,
    Name NVARCHAR(MAX)
);

-- DDL for Tb_Games table
CREATE TABLE Tb_Games (
    Id INT PRIMARY KEY,
    Title NVARCHAR(MAX) NOT NULL,
    DeveloperId INT NOT NULL,
    Publisher NVARCHAR(MAX),
    Category NVARCHAR(MAX) NOT NULL,
    ReleaseDate DATE,
    Genre INT NOT NULL,
    Review INT,
    FreeToPlay BIT,
    FOREIGN KEY (DeveloperId) REFERENCES Tb_Developer(Id)
);

```

link do vídeo: 
