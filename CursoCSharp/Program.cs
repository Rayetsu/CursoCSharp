using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                { "Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar },
                {"Interpolação - Fundamentos", Interpolacao.Executar },
                {"Notacão Ponto - Fundamentos", NotacaoPonto.Executar },
                {"Lendo Dados - Fundamentos", LendoDados.Executar },
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar },
                {"Converções - Fundamentos", Convercoes.Executar },
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar },
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar },
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar },
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar },
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar },
                {"Operadore Ternário - Fundamentos", OperadorTernario.Executar },
                
                // Estruturas de Controle
                { "Estrutura If - Estruturas de Controle", EstruturaIf.Executar },
                { "Estrutura If/Else - Estruturas de Controle", EstruturaIfElse.Executar },
                { "Estrutura If/Else If - Estruturas de Controle", EstruturaIfElseIf.Executar },
                { "Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar },
                { "Estrutura While - Estruturas de Controle", EstruturaWhile.Executar },
                { "Estrutura Do While - Estruturas de Controle", EstruturaDoWhile.Executar },
                { "Estrutura For - Estruturas de Controle", EstruturaFor.Executar },
                { "Estrutura Foreach - Estruturas de Controle", EstruturaForEach.Executar },
                { "Usando Break - Estruturas de Controle", UsandoBreak.Executar },
                { "Usando Continue - Estruturas de Controle", UsandoContinue.Executar },
                
                // Classes e Métodos
                { "Membros - Classes e Métodos", Membros.Executar },
                { "Construtores - Classes e Métodos", Construtores.Executar },
                { "Métodos com Retorno - Classes e Métodos", MetodosComRetorno.Executar },
                { "Métodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar },
                { "Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar },
                { "Desafio Atributo - Classes e Métodos", DesafioAtributo.Executar },
                { "Params - Classes e Métodos", Params.Executar },
                { "Parametros Nomeados - Classes e Métodos", ParametrosNomeados.Executar },
                { "Get e Set - Classes e Métodos", GetSet.Executar },
                { "Props - Classes e Métodos", Props.Executar },
                { "Readonly - Classes e Métodos", Readonly.Executar },
                { "Enum - Classes e Métodos", ExemploEnum.Executar },
                { "Struct - Classes e Métodos", ExemploStruct.Executar },
                { "Struct Vs Classe - Classes e Métodos", StructVsClasse.Executar },
                { "Valor Vs Referência - Classes e Métodos", ValorVsReferencia.Executar },
                { "Parâmetros Por Referência - Classes e Métodos", ParametrosPorReferencia.Executar },
                { "Parâmetro com Valor Padrão  - Classes e Métodos", ParametroPadrao.Executar },

                //Coleções
                { "Array  - Coleções", Colecoes.Array.Executar },
                { "List  - Coleções", ColecoesList.Executar },
                { "ArrayList  - Coleções", ColecoesArrayList.Executar },
                { "Set  - Coleções", ColecoesSet.Executar },
                { "Queue  - Coleções", ColecoesQueue.Executar },
                { "Igualdade  - Coleções", Igualdade.Executar },
                { "Stack  - Coleções", ColecoesStack.Executar },
                { "Dictionary  - Coleções", ColecoesDictionary.Executar },

                // OO
                { "Herança  - OO", Heranca.Executar },
                { "Construtor This  - OO", ConstrutorThis.Executar },
                { "Encapsulamento  - OO", OO.Encapsulamento.Executar },
                { "Polimorfismo  - OO", OO.Polimorfismo.Executar },
                { "Abstract  - OO", OO.Abstract.Executar },
                { "Interface  - OO", OO.Interface.Executar },
                { "Sealed  - OO", OO.Sealed.Executar },

                // Métodos e Funções
                { "Exemplo Lambda  - Métodos e Funções", ExemploLambda.Executar },
                { "Lambdas Como Delegate  - Métodos e Funções", LambdasDelegate.Executar },
                { "Usando Delegates  - Métodos e Funções", UsandoDelegates.Executar },
                { "Delegates Como Função Anonima - Métodos e Funções", DelegateFuncAnonima.Executar },
                { "Métodos de Extensão - Métodos e Funções", MetodosDeExtensao.Executar },

                //Exceções
                { "Primeira Exceção - Exceções", PrimeiraExcecao.Executar },
                { "Exceções Personalizadas - Exceções", ExcecoesPersonalizadas.Executar },
            });

            central.SelecionarEExecutar();
        }
    }
}