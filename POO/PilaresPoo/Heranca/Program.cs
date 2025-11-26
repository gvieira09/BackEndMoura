using Heranca;

Console.Clear();
// Veiculo generic = new Veiculo();

// Aviao AirBus = new Aviao();
// Moto Repsoul = new Moto();
// Repsoul.Marca = "Repsoul";
// Repsoul.Modelo = "1000cc";
// Repsoul.Ano = 2028;
// Repsoul.SomDaMoto();

// AirBus.Marca = "LATAM AirLines";
// AirBus.Modelo = "AirBus 320";
// AirBus.Ano = 2022;
// AirBus.qtdAsas = 2;
// AirBus.Voar();


// Gato Persa = new Gato();
// Cachorro Buldogg = new Cachorro();

// Persa.nome = "Lia";
// Persa.raca = "Persa";
// Persa.idade = 2;
// Persa.ExibirInfo();
// Persa.FazerSom();

// Buldogg.nome = "Theo";
// Buldogg.raca = "Buldogg";
// Buldogg.idade = 1;
// Buldogg.ExibirInfo();
// Buldogg.FazerSom();

//Console.Clear();  
// Gerente gerente = new Gerente();
// Funcionario GerenteGeneric = new Funcionario();
// Console.Clear();
// gerente.nome = "Guilherme";
// gerente.salarioBase = 4000;
// gerente.ExibirSalario();

// Console.Clear();
// Aluno aluno = new Aluno();
// Pessoa AlunoGeneric = new Pessoa();
// aluno.nome = "Guilherme";
// aluno.idade = 16;
// aluno.curso = "Desenvolvimento de Sistemas";
// aluno.ExibirInfo();

// Console.Clear();
// Professor professor = new Professor();
// Pessoa ProfessorGeneric = new Pessoa();
// professor.nome = "Eduardo";
// professor.idade = 43;
// professor.disciplina = "Area de TI";
// professor.ExibirInfo();

Console.Clear();
ContaPoupanca conta = new ContaPoupanca();
Conta contaGeneric = new Conta();
conta.numero = 11915021323f;
conta.saldoaBase = 0;
conta.ExibirInfo();
conta.Exibir();
conta.QntdDeposito = 100;
conta.Depositar();
conta.ExibirInfo2();
conta.Exibir2();
conta.QntdSacar = 50;
conta.Sacar();
conta.ExibirInfo2();
