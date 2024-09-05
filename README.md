# <img src="favicon.ico" alt="Modo inicial, sem filtro" width="28" height="auto"> Lista de Ramais

**Lista de Ramais** é um aplicativo para gerenciamento e busca de ramais de telefone, com suporte para conexão com bancos de dados SQLite, OracleDB e MySQL. Sendo usado em produção por duas empresas até o último Release deste projeto. Atentando a funcionalidade simples de estar presente na **Bandeja do Sistema** e poder ser evocado quando o usuário necessitar de uma rápida consulta aos ramais, podendo buscar por nome do funcionário, departamento, UF e ramal.

## Capturas de Tela

Aplicativo com a tela inicial exibindo todos os registros permitindo ao usuário buscar com a barra de rolagem:

![Modo inicial, sem filtro](images/captura1.png)

Aplicativo com o usuário filtrando por departamento e nome:

![Modo inicial, filtrando departamento](images/captura2.png)
![Modo inicial, filtrando nome](images/captura3.png)

## Criando a estrutura do Banco de Dados

Acesse o arquivo `BancoDemonstrativo.db` por meio de qualquer SGBD de SQLite3 e execute os scripts abaixo:

1. **Crie a tabela**:

    ```
    CREATE TABLE funcionarios (
        USERNAME VARCHAR(50),
        NOME VARCHAR(100),
        SETOR VARCHAR(50),
        RAMAL INT,
        FILIAL VARCHAR(10)
    )
    ```

2. **Insira registros**:

    ```
    INSERT INTO funcionarios (USERNAME, NOME, SETOR, RAMAL, FILIAL) VALUES
    ("lucas.freitas", "LUCAS FREITAS", "ENGENHARIA", 1234, "SP")
    ```


## Transferindo o projeto

1. **Clone o Repositório**: `git clone https://github.com/FlaipyTheHost/ListaRamais.git`
2. **Navegue até o Diretório**: `cd ListaRamais`
3. **Abra o `.sln` no Visual Studio, Rider ou MonoDevelop**: `ListaRamais.sln`
