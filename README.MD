# 💻 Exercícios de C# Básico — Bootcamp .NET | WoMakersCode

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![WoMakersCode](https://img.shields.io/badge/WoMakersCode-Bootcamp%20.NET-E5007D?style=for-the-badge)
![Exercícios](https://img.shields.io/badge/exerc%C3%ADcios-12%2F19%20conclu%C3%ADdos-yellow?style=for-the-badge)
![Nível](https://img.shields.io/badge/n%C3%ADvel-b%C3%A1sico-blue?style=for-the-badge)

Repositório único com as resoluções de **todos os exercícios** da **Lista de Exercícios de C#** (atividade individual) do bootcamp **.NET** da [WoMakersCode](https://womakerscode.org), focada nos fundamentos da linguagem.

## 📚 O que foi praticado

- Entrada e saída de dados no console (`Console.ReadLine` / `Console.WriteLine`)
- Conversão e validação de entrada (`int.TryParse`, `double.TryParse`, `decimal.TryParse`)
- Operadores aritméticos e relacionais
- Estruturas condicionais (`if` / `else`)
- Estruturas de repetição (`for`, `while`)
- `List<T>` e vetores
- Strings e propriedade `Length`
- Formatação de moeda com `CultureInfo`
- Números aleatórios com `Random`

## 🛠️ Tecnologias

- C#
- .NET (Console App, com *top-level statements*)

## 📁 Estrutura do repositório

```
.
├── exercicio1.cs
├── exercicio2.cs
├── ...
├── exercicio19.cs
└── README.md
```

Um arquivo por exercício, todos na raiz do repositório.

## ▶️ Como executar

Cada exercício é um arquivo `.cs` independente, escrito com *top-level statements* (sem `class Program` / `Main`). Como um projeto só aceita **um** arquivo assim, rode um exercício por vez:

```bash
# 1. Clone o repositório
git clone https://github.com/Milly56/<nome-do-repositorio>.git
cd <nome-do-repositorio>

# 2. Crie um projeto console para testar
dotnet new console -o Playground
cd Playground

# 3. Copie o exercício desejado para o Program.cs (exemplo: exercício 5)
cp ../exercicio5.cs Program.cs

# 4. Execute
dotnet run
```

> 💡 Troque `exercicio5.cs` pelo número do exercício que quiser testar.

## 📝 Lista de exercícios

| # | Exercício | Arquivo | Status |
|---|-----------|---------|--------|
| 1 | Soma de dois números | [`exercicio1.cs`](exercicio1.cs) | ✅ Concluído |
| 2 | Antecessor e sucessor | [`exercicio2.cs`](exercicio2.cs) | ✅ Concluído |
| 3 | Área de um retângulo | [`exercicio3.cs`](exercicio3.cs) | ✅ Concluído |
| 4 | Conversor de moedas | [`exercicio4.cs`](exercicio4.cs) | ✅ Concluído |
| 5 | Calculadora simples | [`exercicio5.cs`](exercicio5.cs) | ✅ Concluído |
| 6 | Contagem crescente (1 a 100) | [`exercicio6.cs`](exercicio6.cs) | ✅ Concluído |
| 7 | Contagem regressiva (50 a 1) | [`exercicio7.cs`](exercicio7.cs) | ✅ Concluído |
| 8 | Tabuada | [`exercicio8.cs`](exercicio8.cs) | ✅ Concluído |
| 9 | Soma dos números pares | [`exercicio9.cs`](exercicio9.cs) | ✅ Concluído |
| 10 | Login simples | [`exercicio10.cs`](exercicio10.cs) | ✅ Concluído |
| 11 | Soma até digitar zero | [`exercicio11.cs`](exercicio11.cs) | 🔧 Em revisão |
| 12 | Contador de caracteres | [`exercicio12.cs`](exercicio12.cs) | ✅ Concluído |
| 13 | Verificador de senha | [`exercicio13.cs`](exercicio13.cs) | ✅ Concluído |
| 14 | Maior elemento | [`exercicio14.cs`](exercicio14.cs) | ⏳ Pendente |
| 15 | Média de um vetor | [`exercicio15.cs`](exercicio15.cs) | ⏳ Pendente |
| 16 | Contagem de pares | [`exercicio16.cs`](exercicio16.cs) | ⏳ Pendente |
| 17 | Ordem inversa | [`exercicio17.cs`](exercicio17.cs) | ⏳ Pendente |
| 18 | Jogo da senha | [`exercicio18.cs`](exercicio18.cs) | ⏳ Pendente |
| 19 | Caixa eletrônico | [`exercicio19.cs`](exercicio19.cs) | ⏳ Pendente |

## 📖 Enunciados

<details>
<summary><strong>1. Soma de dois números</strong></summary>

Solicite dois números inteiros e exiba a soma.

**Exemplo**

Entrada:
```
10
15
```
Saída:
```
A soma é 25.
```
</details>

<details>
<summary><strong>2. Antecessor e sucessor</strong></summary>

Leia um número inteiro e mostre:
- Antecessor
- Número informado
- Sucessor
</details>

<details>
<summary><strong>3. Área de um retângulo</strong></summary>

Solicite a **base** e a **altura** e calcule:
- Área
- Perímetro
</details>

<details>
<summary><strong>4. Conversor de moedas</strong></summary>

Leia um valor em reais e a cotação do dólar. Mostre quanto esse valor representa em dólares.
</details>

<details>
<summary><strong>5. Calculadora simples</strong></summary>

Solicite dois números e mostre:
- Soma
- Subtração
- Multiplicação
- Divisão
</details>

<details>
<summary><strong>6. Contagem crescente</strong></summary>

Mostre os números de 1 até 100.
</details>

<details>
<summary><strong>7. Contagem regressiva</strong></summary>

Mostre os números de 50 até 1.
</details>

<details>
<summary><strong>8. Tabuada</strong></summary>

Solicite um número e exiba sua tabuada de 1 a 10.
</details>

<details>
<summary><strong>9. Soma dos números pares</strong></summary>

Calcule a soma de todos os números pares entre 1 e 100.
</details>

<details>
<summary><strong>10. Login simples</strong></summary>

Solicite usuário e senha. Enquanto a senha estiver incorreta, peça novamente.
</details>

<details>
<summary><strong>11. Soma até digitar zero</strong></summary>

Leia números inteiros. Quando o usuário digitar zero, encerre o programa mostrando a soma dos valores digitados.
</details>

<details>
<summary><strong>12. Contador de caracteres</strong></summary>

Leia um nome e informe quantos caracteres ele possui.
</details>

<details>
<summary><strong>13. Verificador de senha</strong></summary>

Solicite uma senha. Informe se ela possui pelo menos 8 caracteres.
</details>

<details>
<summary><strong>14. Maior elemento</strong></summary>

Leia 10 números e informe:
- Maior valor
- Posição em que ele aparece
</details>

<details>
<summary><strong>15. Média de um vetor</strong></summary>

Leia 8 notas e calcule a média.
</details>

<details>
<summary><strong>16. Contagem de pares</strong></summary>

Leia 20 números e informe quantos são pares.
</details>

<details>
<summary><strong>17. Ordem inversa</strong></summary>

Leia 10 números e exiba-os na ordem inversa.
</details>

<details>
<summary><strong>18. Jogo da senha</strong></summary>

Gere um número aleatório entre 1 e 100. Informe ao usuário se o número digitado é maior ou menor que o número sorteado até que ele acerte.
</details>

<details>
<summary><strong>19. Caixa eletrônico</strong></summary>

Solicite um valor para saque. Informe quantas notas serão entregues considerando:
- R$100
- R$50
- R$20
- R$10
- R$5
- R$2
</details>

## 👩‍💻 Autora

**Jamily Alves Rodrigues** — [@Milly56](https://github.com/Milly56)

---

<p align="center">Feito durante o bootcamp .NET da <strong>WoMakersCode</strong> 💜</p>