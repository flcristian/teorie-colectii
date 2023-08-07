using System;
using System.Collections.Generic;
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
    }
}
