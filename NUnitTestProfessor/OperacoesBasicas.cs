using AcademySystem.Context;
using AcademySystem.Controllers;
using AcademySystem.Models;
using NUnit.Framework;

namespace Tests
{
    public class OperacoesBasicas
    {
        private ContextAcademy context;
        [SetUp]
        public void Setup(ContextAcademy _context)
        {
            context = _context;
        }

        [Test]
        public void Inserir()
        {
            var professor = new Professor
            {
                Nome = "Teste"
            };

            
           var retorno =  context.Add(professor);
           Assert.Equals(1,retorno);
        }

        [Test]
        public void InserirProfessorNulo()
        {
            var professor = new Professor();
            var retorno = context.Add(professor);
            Assert.Equals(1, retorno);
        }

        [Test]
        public void Alterar()
        {
            Assert.Pass();
        }

        [Test]
        public void Listar()
        {
            Assert.Pass();
        }


        [Test]
        public void Excluir()
        {
            Assert.Pass();
        }
    }
}