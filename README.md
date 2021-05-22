# desafio-api
Criar um projeto com padrão ASP.NET MVC que tenha como possibilidades:

    Crie telas para atender a:
        Cadastro (CRUD) de Pessoa, contendo:
            Nome da pessoa (texto obrigatório),
            Data de nascimento (data obrigatória),
            Ativo no sistema (bool)
      
    Na tela de listagem de Pessoas
        Apresente, além das propriedades da Pessoa: Idade e Faixa Etaria(0-9, 10-19, 20-29, etc..).
            Ex: se a pessoa tiver 8 anos, ela pertence a faixa etaria de 0-9.
        Deve possibilitar realizar filtros por [Nome], [Idade] e [Faixa etária].
        Possibilite realizar a ordenação das colunas de [Nome], [Faixa Etária], [Idade] e [Data de nascimento]
      
    O CRUD deve ser feito consumindo APIs (Criação, Leitura, Atualização e Deleção).
        No caso da Deleção, a deleção deve ser lógica, ou seja, manter o dado no banco de dados e retornar apenas caso esteja com a propriedade [Ativa no sistema] como verdadeiro(true).
      
    O dado deve ser armazenado em banco de dados, no caso, crie um arquivo .MDF (Sql Server Database) no projeto para servir como o banco de dados.
  
    Para as APIs de Criação e Leitura
        Utilize a conexão com o banco de dados utilizando Entity Framework.
  
    Para as APIs de Update e Delete
        Utilize SQL e deve aplicar proteção básica contra SQL Injection (Usar SQL Parameter).
      
    Utilize JQuery para consumir as APIs e manipulação dos dados da tela (DOM).
      
    Aplique no front preferencialmente a biblioteca Bootstrap4 ou fique a vontade para customizar da forma que preferir.
