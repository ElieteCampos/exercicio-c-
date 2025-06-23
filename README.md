# 🏦 Bank Account Console App

Este é um programa de console em **C#** que simula uma operação bancária simples. Ele permite criar uma conta bancária, realizar depósitos, saques e visualizar os dados atualizados da conta.

## 🚀 Funcionalidades

- Abertura de conta bancária:
  - Com ou sem depósito inicial
- Realização de depósitos
- Realização de saques (com desconto de taxa)
- Exibição dos dados da conta atualizados após cada operação

## 🏗️ Funcionamento

O programa solicita ao usuário:

1. Número da conta
2. Nome do titular
3. Se haverá depósito inicial (opção `s` para sim ou `n` para não)

Após criar a conta, o usuário pode realizar:

- **Depósitos:** Informando o valor desejado.
- **Saques:** Informando o valor desejado, sendo descontada uma taxa por operação (definida na classe `ContaBank`).

Ao final de cada operação, os dados da conta são exibidos atualizados.

## 🛠️ Tecnologias Utilizadas

- Linguagem: **C#**
- .NET Console Application
- Manipulação de dados via console
- Programação Orientada a Objetos (POO)
- Construtores com sobrecarga

## 📦 Estrutura do Projeto

- `ContaBank`: Classe que representa a conta bancária, contendo:
  - Número da conta
  - Nome do titular
  - Saldo
  - Métodos:
    - `Deposito(double valor)`
    - `Saque(double valor)`
    - `ToString()` para formatação dos dados da conta

- `Constutores` (Classe principal):
  - Contém o método `Main` que executa toda a lógica interativa via console.

## 🎯 Exemplo de Uso

 Em um banco, para se cadastrar uma conta bancária, é necessário informar o número da conta, o nome do 
titular da conta, e o valor de depósito inicial que o titular depositou ao abrir a conta. Este valor de depósito 
inicial, entretanto, é opcional, ou seja: se o titular não tiver dinheiro a depositar no momento de abrir sua 
conta, o depósito inicial não será feito e o saldo inicial da conta será, naturalmente, zero.
 Importante: uma vez que uma conta bancária foi aberta, o número da conta nunca poderá ser alterado. Já 
o nome do titular pode ser alterado (pois uma pessoa pode mudar de nome por ocasião de casamento, por 
exemplo). 
Por fim, o saldo da conta não pode ser alterado livremente. É preciso haver um mecanismo para proteger 
isso. O saldo só aumenta por meio de depósitos, e só diminui por meio de saques. Para cada saque 
realizado, o banco cobra uma taxa de $ 5.00. Nota: a conta pode ficar com saldo negativo se o saldo não for 
suficiente para realizar o saque e/ou pagar a taxa.
 Você deve fazer um programa que realize o cadastro de uma conta, dando opção para que seja ou não 
informado o valor de depósito inicial. Em seguida, realizar um depósito e depois um saque, sempre 
mostrando os dados da conta após cada operação.

 Entre o número da conta: 8532
 Entre o titular da conta: Alex Green
 Haverá depósito inicial (s/n)? s
 Entre o valor de depósito inicial: 500.00
 Dados da conta:
 Conta 8532, Titular: Alex Green, Saldo: $ 500.00
 Entre um valor para depósito: 200.00
 Dados da conta atualizados:
 Conta 8532, Titular: Alex Green, Saldo: $ 700.00
 Entre um valor para saque: 300.00
 Dados da conta atualizados:
 Conta 8532, Titular: Alex Green, Saldo: $ 395.00

Outro exemplo:
Entre o número da conta: 1234
Entre com o titular da conta: Maria Silva
Hávera depósito inicial (s / n)? s
Entre o valor do deposito inicial: 500.00

Dados da conta:
Conta 1234, Titular: Maria Silva, Saldo: R$ 500.00

Entre um valor para deposito: 200.00
Dados da conta atualizados:
Conta 1234, Titular: Maria Silva, Saldo: R$ 700.00

Entre um valor para saque: 100.00
Dados da conta atualizados:
Conta 1234, Titular: Maria Silva, Saldo: R$ 597.00


> 💡 *Obs.: O saldo após o saque é reduzido pelo valor sacado + taxa de saque (definida no código).*

## 📚 Aprendizados

Este projeto demonstra:

- Criação de classes com construtores sobrecarregados
- Encapsulamento de dados
- Manipulação de entrada e saída no console
- Operações matemáticas básicas
- Formatação de dados com `CultureInfo.InvariantCulture`


