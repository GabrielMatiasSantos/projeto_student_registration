1. Apresentação do projeto

 
    .Aplicativo para um professor de inglês registrar seus estudantes e detalhes de suas aulas

    .Aplicativo Windows Forms (C#) com banco de dados SQL, sendo a comunicação com o banco de dados feita com ADO.NET






2. Descrição geral do projeto



    .O aplicativo registra o seguinte: registros dos alunos, data das aulas, detalhes de cada aula, pagamento das mensalidades

    .O aplicativo consiste de uma janela com quatro abas

    .O banco de dados possui quatro tabelas

    .Visto que o professor é natural de um país de língua inglesa (portanto, é mais confortável para ele lidar com a língua inglesa), todo texto no            aplicativo está em inglês





3. Detalhes e desafios do projeto


    .Todos os campos Textbox foram colocados limitações de caracteres aceitos. Por exemplo, no campo para informar o nome do estudante só serão aceitos        letras e espaços, e nos campos para informar valores monetários só são aceitos valores numéricos

    .Na primeira aba (Students' data) o usuário irá registrar os dados de seus alunos. Dados registrados: nome, CPF, telefone celular, dia de pagamento da     mensalidade, valor do pagamento da mensalidade, endereço, e status (se o estudante está estudando com o professor (Active) ou não (Inactive)). Todos       estudantes são registrados como 'Active', só podendo mudar o status na atualização

    .Informações de telefone e CPF devem ser únicas. Ou seja, dois ou mais estudantes não podem ter o mesmo número de CPF e/ou telefone. E dia máximo de       pagamento de mensalidade é 30

    .Na segunda aba (Class schedules) são registrados os horários das aulas dos alunos. Os nomes dos alunos são selecionados em uma Combobox, e estarão        disponíveis os nomes dos estudantes registrados como 'Active'. Regras de registro de horários:


      -Só é possível registrar o horário de uma aula em horários redondos (minutos 00) ou 30 minutos após uma determinada hora (minutos 30)

      -É possível registrar aulas das 00:00 até às 23:30

      -Cada aula tem uma hora

      -Foi bloqueado a possibilidade de registrar mais de uma aula no mesmo horário. Isto inclui bloquear aulas que estejam espaçadas em apenas 30               minutos. Por exemplo: se existe uma aula registrada ás 11:00, não será possível registrar uma aula às 10:30 ou às 11:30, visto que uma aula tem uma        hora, e estes horários iriam sobrepor aulas


    .Na terceira aba (Class control) são registrados detalhes de cada aula. São registrados o que foi planejado, e como transcorreu a aula

    .Na quarta aba (Payment control) são registrados os status de pagamento das mensalidades dos alunos. É feito da seguinte maneira:


      -O usuário informa o mês e o ano do período a ser registrado os pagamentos

      -Este mês e ano é combinado com o dia de pagamento de cada estudante com o status como 'Active' informado na primeira aba

      -Foi levado em consideração a situação de o aluno ter o dia de pagamento nos dias 29 ou 30 no mês de Fevereiro. Caso o mês informado for 02                (Fevereiro) ocorrerá o seguinte: Se o ano não for bissexto, o dia de pagamento de quem está registrado dias 29 ou 30 será alterado para 28. Se o ano       for bissexto, o dia de pagamento de quem está registrado dia 30 será alterado para 29


 
    .Em todos os registros das três primeiras abas, é possível alterá-los e deletá-los. Para isto, basta fazer um duplo clique no registro no DataGridView     que irá abrir outra janela que fornecerá uma opção para alterar ou deletar o registro

    .Na última aba, só é possível alterar a informação sobre o estatus de pagamento (feito com um duplo clique). Assim como a inserção de registros é em       bloco, a remoção também é em bloco pelo mês e ano informados pelo usuário

    .Em todas as abas é possível fazer uma busca nas informações registradas

    .Estrutura do banco de dados:


      -Tabela 'tb_students': Registrar os dados dos estudantes. Possui relação com as demais tabelas

      -Tabela 'tb_class_schedules': Registrar os horários das aulas dos estudantes

      -Tabela 'tb_class_control': Registrar os detalhes de cada aula

      -Tabela 'tb_payment_control': Registrar os status de pagamento das mensalidades dos alunos

      -Todas as tabelas usam chaves primárias substitutas (identity)


    .Tudo aqui mencionado consta no 'commit 1'







  4. Refatorações planejadas no futuro

  
     .Aplicar o padrão repositório e remover o código de dentro dos eventos []

     .Usar métodos assíncronos em processos que envolvam banco de dados []

     .Aplicar transações SQL em processos de inserção de registros que envolvam múltiplas inserções de uma vez []

     .Inserir a criação de arquivos de log em caso de alguma falha (catch) []
