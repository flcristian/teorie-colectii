using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teorie_colectii.colectii;
using teorie_colectii.colectii.coada;
using teorie_colectii.person.model;
using Xunit.Abstractions;

namespace test_lista.Tests
{
    public class TestCoada
    {
        private readonly ITestOutputHelper output;

        public TestCoada(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void TestPush()
        {
            // Arrange
            Person a = new Person(0, 18, "a", "a");
            Person b = new Person(1, 18, "b", "b");
            Person c = new Person(2, 18, "c", "c");
            ICoada<Person> coada = new Coada<Person>();

            // Act
            coada.Push(a);
            coada.Push(b);
            coada.Push(c);

            // Assert
            Assert.Equal(a, coada.Peek());
            output.WriteLine(coada.ToString());
        }

        [Fact]
        public void TestPeek()
        {
            // Arrange
            Person a = new Person(0, 18, "a", "a");
            Person b = new Person(1, 18, "b", "b");
            Person c = new Person(2, 18, "c", "c");
            ICoada<Person> coada = new Coada<Person>();
            coada.Push(a);
            coada.Push(b);
            coada.Push(c);

            // Assert
            Assert.Equal(a, coada.Peek());
            output.WriteLine(coada.Peek().ToString());
        }

        [Fact]
        public void TestPop()
        {
            // Arrange
            Person a = new Person(0, 18, "a", "a");
            Person b = new Person(1, 18, "b", "b");
            Person c = new Person(2, 18, "c", "c");
            Person d = new Person(3, 18, "d", "d");
            ICoada<Person> coada = new Coada<Person>();
            coada.Push(a);
            coada.Push(b);
            coada.Push(c);
            coada.Push(d);

            // Act
            coada.Pop();
            coada.Pop();

            // Assert
            Assert.Equal(c, coada.Peek());
            output.WriteLine(coada.ToString());
        }

        [Fact]
        public void TestIsEmpty()
        {
            // Arrange
            ICoada<Person> coada = new Coada<Person>();

            // Act
            bool empty = coada.IsEmpty();

            // Assert
            Assert.True(empty);
        }

        // Problema 1
        // Se consideră un șir A de n numere întregi.
        // Pentru fiecare subsecvență de lungimea k să se afișeze valoarea maximă.

        [Fact]
        public void Problema1()
        {
            // 1 2 4 1 3 6 3 2 5
            Coada<int> numere = new Coada<int>();
            numere.Push(1); numere.Push(2);
            numere.Push(4); numere.Push(1);
            numere.Push(3); numere.Push(6);
            numere.Push(3); numere.Push(2);
            numere.Push(5);
            int k = 3;
        }

        // Problema 2
        // Sa se determine pozitia din coada pe care se afla un element.
        // Se afiseaza -1 daca elementul nu apartine cozii.

        [Fact]
        public void Problema2()
        {
            Coada<int> coada = new Coada<int>();
            coada.Push(2); coada.Push(4);
            coada.Push(5); coada.Push(1);
            coada.Push(7);

            int query = 1, pos = 1;
            while (coada.Peek() != query)
            {
                coada.Pop();
                pos++;
            }

            output.WriteLine(pos.ToString());
        }

        // Problema 3
        // Se dau patru numere naturale n a x y.
        // Să se afișeze elementele mulțimii M, cu următoarele proprietăți:
        // 
        // toate elementele lui M sunt numere naturale mai mici sau egale cu n;
        // a se află în M;
        // dacă b se află în M, atunci b+x și b+y se află în M.

        [Fact]
        public void Problema3()
        {
            // ? ? ? 
        }

        // Problema 4
    }
}
