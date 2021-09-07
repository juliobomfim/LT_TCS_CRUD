# LT_TCS_CRUD
Teste de Conhecimentos Especificos Cadastro de Contatos

O Projeto contem as migrations para criação das tabelas.
Foi utilizado Visual Studio 2019 e Asp.net MVC 5 para estrutura do projeto.
Para o Front-end foi utilizado por padrão Razor-Pages, HTML, Bootstrap, Jquery e Javascript.
Para o Back-end foi utilizado o próprio padrão MVC com persistencia com o EntityFrameworkCore e SQL Server.
Como solicitado, no controller de Cadastro, foram criados os métodos de renderização da lista de cadastrados (Página index)
e a tela de cadastro com validações realizadas por Annotations nas próprias propriedades do modelo utilizado (Contato).
Para a validação de Telefones válidos foi utilizado uma Expressão Regular também nas Annotations da propriedade de modelo e
a lib MaskedInput para criar um input mascarado e tornar o telefone sempre válido.
