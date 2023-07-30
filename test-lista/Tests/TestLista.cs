using teorie_colectii.car.model;
using teorie_colectii.colectii;
using teorie_colectii.colectii.lista;
using teorie_colectii.person.model;
using Xunit.Abstractions;

namespace test_lista.Tests
{
    public class TestLista
    {
        private readonly ITestOutputHelper output;

        public TestLista(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void TestAddStart()
        {
            // Arrange
            ILista<Person> lista = new Lista<Person>();
            Person andrei = new Person(0, 20, "Andrei", "andrei@email.com");
            Person maria = new Person(1, 23, "Maria", "maria@email.com");
            Person gabriel = new Person(2, 19, "Gabriel", "gabriel@email.com");

            // Act
            lista.AddStart(andrei);
            lista.AddStart(maria);
            lista.AddStart(gabriel);

            output.WriteLine(lista.ToString());
        }

        [Fact]
        public void TestAddAtEnd()
        {
            // Arrange
            ILista<Person> lista = new Lista<Person>();
            Person andrei = new Person(0, 20, "Andrei", "andrei@email.com");
            Person maria = new Person(1, 23, "Maria", "maria@email.com");
            Person gabriel = new Person(2, 19, "Gabriel", "gabriel@email.com");

            // Act
            lista.AddStart(andrei);
            lista.AddStart(maria);
            lista.Add(gabriel);

            output.WriteLine(lista.ToString());
        }

        [Fact]
        public void TestAddAtIndex()
        {
            // Arrange
            ILista<Person> lista = new Lista<Person>();
            Person andrei = new Person(0, 20, "Andrei", "andrei@email.com");
            Person maria = new Person(1, 23, "Maria", "maria@email.com");
            Person gabriel = new Person(2, 19, "Gabriel", "gabriel@email.com");
            Person george = new Person(3, 20, "George", "george@email.com");
            Person andra = new Person(4, 23, "Andra", "andra@email.com");
            Person paul = new Person(5, 19, "Paul", "paul@email.com");

            // Act
            lista.Add(andrei);
            lista.Add(maria);
            lista.Add(george);
            lista.Add(andra);
            lista.Add(paul);
            lista.Add(gabriel, 4);

            output.WriteLine(lista.ToString());
        }

        [Fact]
        public void TestRemoveStart()
        {
            // Arrange
            ILista<Person> lista = new Lista<Person>();
            Person andrei = new Person(0, 20, "Andrei", "andrei@email.com");
            Person maria = new Person(1, 23, "Maria", "maria@email.com");
            Person gabriel = new Person(2, 19, "Gabriel", "gabriel@email.com");
            Person george = new Person(3, 20, "George", "george@email.com");
            Person andra = new Person(4, 23, "Andra", "andra@email.com");
            Person paul = new Person(5, 19, "Paul", "paul@email.com");

            // Act
            lista.Add(andrei);
            lista.Add(maria);
            lista.Add(gabriel);
            lista.Add(george);
            lista.Add(andra);
            lista.Add(paul);

            lista.RemoveStart();

            output.WriteLine(lista.ToString());
        }

        [Fact]
        public void TestRemoveAtIndex()
        {
            // Arrange
            ILista<Person> lista = new Lista<Person>();
            Person andrei = new Person(0, 20, "Andrei", "andrei@email.com");
            Person maria = new Person(1, 23, "Maria", "maria@email.com");
            Person gabriel = new Person(2, 19, "Gabriel", "gabriel@email.com");
            Person george = new Person(3, 20, "George", "george@email.com");
            Person andra = new Person(4, 23, "Andra", "andra@email.com");
            Person paul = new Person(5, 19, "Paul", "paul@email.com");

            // Act
            lista.Add(andrei);
            lista.Add(maria);
            lista.Add(gabriel);
            lista.Add(george);
            lista.Add(andra);
            lista.Add(paul);

            lista.Remove(3);

            output.WriteLine(lista.ToString());
        }

        [Fact]
        public void TestIndexOf()
        {
            // Arrange
            ILista<Person> lista = new Lista<Person>();
            Person andrei = new Person(0, 20, "Andrei", "andrei@email.com");
            Person maria = new Person(1, 23, "Maria", "maria@email.com");
            Person gabriel = new Person(2, 19, "Gabriel", "gabriel@email.com");
            Person george = new Person(3, 20, "George", "george@email.com");
            Person andra = new Person(4, 23, "Andra", "andra@email.com");
            Person paul = new Person(5, 19, "Paul", "paul@email.com");

            // Act
            lista.Add(andrei);
            lista.Add(maria);
            lista.Add(gabriel);
            lista.Add(george);
            lista.Add(andra);
            lista.Add(paul);

            output.WriteLine(lista.ToString());
            output.WriteLine("" + lista.IndexOf(andra));
        }

        [Fact]
        public void TestElementAt()
        {
            // Arrange
            ILista<Person> lista = new Lista<Person>();
            Person andrei = new Person(0, 20, "Andrei", "andrei@email.com");
            Person maria = new Person(1, 23, "Maria", "maria@email.com");
            Person gabriel = new Person(2, 19, "Gabriel", "gabriel@email.com");
            Person george = new Person(3, 20, "George", "george@email.com");
            Person andra = new Person(4, 23, "Andra", "andra@email.com");
            Person paul = new Person(5, 19, "Paul", "paul@email.com");

            // Act
            lista.Add(andrei);
            lista.Add(maria);
            lista.Add(gabriel);
            lista.Add(george);
            lista.Add(andra);
            lista.Add(paul);

            output.WriteLine(lista.ToString());
            output.WriteLine(lista.ElementAt(4).ToString());
        }

        [Fact]
        public void TestSortAscending()
        {
            // Arrange
            Lista<Person> lista = new Lista<Person>();
            Person andrei = new Person(0, 20, "Andrei", "andrei@email.com");
            Person maria = new Person(1, 23, "Maria", "maria@email.com");
            Person gabriel = new Person(2, 19, "Gabriel", "gabriel@email.com");
            Person george = new Person(3, 20, "George", "george@email.com");
            Person andra = new Person(4, 23, "Andra", "andra@email.com");
            Person paul = new Person(5, 19, "Paul", "paul@email.com");
            lista.Add(andrei);
            lista.Add(maria);
            lista.Add(gabriel);
            lista.Add(george);
            lista.Add(andra);
            lista.Add(paul);

            // Act
            lista.SortAscending();

            // Assert
            output.WriteLine(lista.ToString());
        }

        [Fact]
        public void TestSortDescending()
        {
            // Arrange
            Lista<Person> lista = new Lista<Person>();
            Person andrei = new Person(0, 20, "Andrei", "andrei@email.com");
            Person maria = new Person(1, 23, "Maria", "maria@email.com");
            Person gabriel = new Person(2, 19, "Gabriel", "gabriel@email.com");
            Person george = new Person(3, 20, "George", "george@email.com");
            Person andra = new Person(4, 23, "Andra", "andra@email.com");
            Person paul = new Person(5, 19, "Paul", "paul@email.com");
            lista.Add(andrei);
            lista.Add(maria);
            lista.Add(gabriel);
            lista.Add(george);
            lista.Add(andra);
            lista.Add(paul);

            // Act
            lista.SortDescending();

            // Assert
            output.WriteLine(lista.ToString());
        }
    }
}
