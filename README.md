## SolidApiExample
Este projeto é uma API Web simples construída com .NET Core que aplica os princípios SOLID para demonstrar como melhorar a estrutura e a qualidade do código, tornando-o mais modular, flexível e fácil de manter.

## Princípios SOLID Aplicados
- S - Single Responsibility Principle (SRP): Cada classe tem uma única responsabilidade.
- O - Open/Closed Principle (OCP): O código está aberto para extensão, mas fechado para modificação.
- L - Liskov Substitution Principle (LSP): Objetos de uma classe derivada podem substituir a classe base sem alterar o comportamento da aplicação.
- I - Interface Segregation Principle (ISP): Interfaces específicas para cada tipo de cliente, evitando métodos desnecessários.
- D - Dependency Inversion Principle (DIP): Dependência de abstrações e não de implementações concretas.
  
## Estrutura do Projeto
- Controllers: Controladores da API (ex: PedidosController).
- Services: Contém a lógica de negócios (ex: PedidoService).
- Models: Modelos de dados (ex: Pedido).
- PaymentStrategies: Estratégias de pagamento (ex: PagamentoCredito, PagamentoBoleto).

## Funcionalidade
Esta API simula um sistema de criação de pedidos, onde os pedidos podem ser pagos com diferentes formas de pagamento (Cartão de Crédito ou Boleto). O código é estruturado para seguir os princípios SOLID.

## Fluxo de Trabalho:
- Recebe um pedido com dados como Id, Valor e FormaPagamento.
- Escolhe a estratégia de pagamento com base na forma de pagamento fornecida (Cartão de Crédito ou Boleto).
- Processa o pagamento usando a estratégia escolhida.
- Cria o pedido com sucesso.

## Arquitetura SOLID
- Single Responsibility Principle (SRP): As responsabilidades são bem definidas entre as classes. PedidoService cuida apenas da lógica do pedido, e as estratégias de pagamento cuidam da lógica de pagamento.
- Open/Closed Principle (OCP): O código está aberto para a adição de novas formas de pagamento sem precisar modificar o código existente.
- Liskov Substitution Principle (LSP): A aplicação pode facilmente substituir as implementações de pagamento sem quebrar a funcionalidade.
- Interface Segregation Principle (ISP): A interface IPagamentoStrategy é bem específica, evitando métodos desnecessários.
- Dependency Inversion Principle (DIP): O código depende de abstrações (interfaces) e não de implementações concretas.
