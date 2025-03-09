# Leitor de Arquivo (Console Application)

Este é um simples programa de console escrito em C# que lê e imprime o conteúdo de um arquivo linha por linha. O nome do arquivo a ser lido é fornecido como argumento de linha de comando.

## Requisitos

- .NET Framework 4.5 ou superior
- C# 8.0 ou superior (para melhor compatibilidade com o código)

## Funcionalidade

1. **Leitura de Arquivo**: O programa lê o conteúdo de um arquivo linha por linha.
2. **Exibição do Conteúdo**: Cada linha lida é exibida no console.
3. **Tratamento de Erros**: O programa implementa tratamento de exceções, exibindo uma mensagem de erro caso haja algum problema (como o arquivo não ser encontrado ou um erro de leitura).
4. **Fechamento do Arquivo**: Após a leitura completa do arquivo, ele é fechado.

## Como Usar

### Compilação e Execução

1. Compile o programa usando sua IDE ou a ferramenta de linha de comando do .NET (`dotnet build`).
2. Execute o programa a partir da linha de comando, fornecendo o caminho completo do arquivo como argumento.

```bash
dotnet run caminho/para/seu/arquivo.txt

