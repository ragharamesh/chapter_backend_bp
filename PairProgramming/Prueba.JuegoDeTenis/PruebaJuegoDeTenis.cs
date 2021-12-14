using JuegoDeTenis;
using Moq;
using NUnit.Framework;
using System;
using System.IO;

namespace Prueba.JuegoDeTenis
{
    public class Tests
    {
        Mock<IConsole> mockConsole;

        [SetUp]
        public void Setup()
        {
            mockConsole = new Mock<IConsole>();
        }

        [Test]
        public void PruebaJuegoDeTenisPlayer10Player220()
        {
            Juego j1 = new Juego();

            mockConsole.SetupSequence(c => c.ReadLine())
                .Returns("1")
                .Returns("Player1")
                .Returns("1")
                .Returns("Player2")
                .Returns("3")
                .Returns("4");
            j1.Console = mockConsole.Object;

            string result = j1.JuegoDeTenisEmpezar();

            //Primero result
            Assert.AreEqual("Player1 0 Player2 0", result);
        }

        [Test]
        public void PruebaJuegoDeTenisPlayer130Player215()
        {
            Juego j1 = new Juego();

            mockConsole.SetupSequence(c => c.ReadLine())
                .Returns("1")
                .Returns("Player1")
                .Returns("1")
                .Returns("Player2")
                .Returns("2")
                .Returns("Player1")
                .Returns("30")
                .Returns("2")
                .Returns("Player2")
                .Returns("15")
                .Returns("3")
                .Returns("4");
            j1.Console = mockConsole.Object;

            string result = j1.JuegoDeTenisEmpezar();

            //segundo result
            Assert.AreEqual("Player1 30 Player2 15", result);
        }

        [Test]
        public void PruebaJuegoDeTenisPlayer140Player240()
        {
            Juego j1 = new Juego();

            mockConsole.SetupSequence(c => c.ReadLine())
                .Returns("1")
                .Returns("Player1")
                .Returns("1")
                .Returns("Player2")
                .Returns("2")
                .Returns("Player1")
                .Returns("30")
                .Returns("2")
                .Returns("Player2")
                .Returns("15")
                .Returns("2")
                .Returns("Player1")
                .Returns("10")
                .Returns("2")
                .Returns("Player2")
                .Returns("25")
                .Returns("3")
                .Returns("4");
            j1.Console = mockConsole.Object;

            string result = j1.JuegoDeTenisEmpezar();

            //3rd result
            Assert.AreEqual("Deuce", result);
        }

        [Test]
        public void PruebaJuegoDeTenisPlayer141Player240()
        {
            Juego j1 = new Juego();

            mockConsole.SetupSequence(c => c.ReadLine())
                .Returns("1")
                .Returns("Player1")
                .Returns("1")
                .Returns("Player2")
                .Returns("2")
                .Returns("Player1")
                .Returns("30")
                .Returns("2")
                .Returns("Player2")
                .Returns("15")
                .Returns("2")
                .Returns("Player1")
                .Returns("10")
                .Returns("2")
                .Returns("Player2")
                .Returns("25")
                .Returns("2")
                .Returns("Player1")
                .Returns("1")
                .Returns("3")
                .Returns("4");
            j1.Console = mockConsole.Object;

            string result = j1.JuegoDeTenisEmpezar();

            //4th result
            Assert.AreEqual("Advantage Player1", result);
        }

        [Test]
        public void PruebaJuegoDeTenisPlayer140Player2402()
        {
            Juego j1 = new Juego();

            mockConsole.SetupSequence(c => c.ReadLine())
                .Returns("1")
                .Returns("Player1")
                .Returns("1")
                .Returns("Player2")
                .Returns("2")
                .Returns("Player1")
                .Returns("30")
                .Returns("2")
                .Returns("Player2")
                .Returns("15")
                .Returns("2")
                .Returns("Player1")
                .Returns("10")
                .Returns("2")
                .Returns("Player2")
                .Returns("25")
                .Returns("2")
                .Returns("Player1")
                .Returns("1")
                .Returns("2")
                .Returns("Player1")
                .Returns("-1")
                .Returns("3")
                .Returns("4");
            j1.Console = mockConsole.Object;

            string result = j1.JuegoDeTenisEmpezar();

            //4th result
            Assert.AreEqual("Deuce", result);
        }

        [Test]
        public void PruebaJuegoDeTenisPlayer140Player241()
        {
            Juego j1 = new Juego();

            mockConsole.SetupSequence(c => c.ReadLine())
                .Returns("1")
                .Returns("Player1")
                .Returns("1")
                .Returns("Player2")
                .Returns("2")
                .Returns("Player1")
                .Returns("30")
                .Returns("2")
                .Returns("Player2")
                .Returns("15")
                .Returns("2")
                .Returns("Player1")
                .Returns("10")
                .Returns("2")
                .Returns("Player2")
                .Returns("25")
                .Returns("2")
                .Returns("Player1")
                .Returns("1")
                .Returns("2")
                .Returns("Player1")
                .Returns("-1")
                .Returns("2")
                .Returns("Player2")
                .Returns("1")
                .Returns("3")
                .Returns("4");
            j1.Console = mockConsole.Object;

            string result = j1.JuegoDeTenisEmpezar();

            //5th result
            Assert.AreEqual("Advantage Player2", result);
        }

        [Test]
        public void PruebaJuegoDeTenisPlayer140Player242()
        {
            Juego j1 = new Juego();

            mockConsole.SetupSequence(c => c.ReadLine())
                .Returns("1")
                .Returns("Player1")
                .Returns("1")
                .Returns("Player2")
                .Returns("2")
                .Returns("Player1")
                .Returns("30")
                .Returns("2")
                .Returns("Player2")
                .Returns("15")
                .Returns("2")
                .Returns("Player1")
                .Returns("10")
                .Returns("2")
                .Returns("Player2")
                .Returns("25")
                .Returns("2")
                .Returns("Player1")
                .Returns("1")
                .Returns("2")
                .Returns("Player1")
                .Returns("-1")
                .Returns("2")
                .Returns("Player2")
                .Returns("1")
                .Returns("2")
                .Returns("Player2")
                .Returns("1")
                .Returns("3")
                .Returns("4");
            j1.Console = mockConsole.Object;

            string result = j1.JuegoDeTenisEmpezar();

            //7th result
            Assert.AreEqual("Player2 wins.", result);
        }
    }
}