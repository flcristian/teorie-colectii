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

        // Problema 1
        // Să se scrie o funcție C++ care determină câte elemente
        // sunt memorate într-o lista simplu înlănțuită.

        [Fact]
        public void Problema1()
        {
            Lista<int> list = new Lista<int>();
            list.Add(4); list.Add(3); list.Add(2);
            list.Add(12); list.Add(1); list.Add(3);
            output.WriteLine(list.Count().ToString());
        }

        // Problema 2
        // Sa se insereze inainte de fiecare element impar dublul sau.

        [Fact]
        public void Problema2()
        {
            Lista<int> list = new Lista<int>();
            list.Add(1); list.Add(7); list.Add(4); list.Add(3);

            for(int i = 0; i < list.Count(); i++)
            {
                if (list.ElementAt(i) % 2 == 1)
                {
                    list.Add(list.ElementAt(i) * 2, i);
                    i++;
                }
            }

            for (int i = 0; i < list.Count(); i++)
            {
                output.WriteLine(list.ElementAt(i).ToString());
            }
        }

        // Problema 3
        // Să se scrie o funcție C++ care verifică dacă informațiile reținute
        // în primele n/2 noduri formează un șir identic cu informațiile din ultimele n/2 noduri.

        [Fact]
        public void Problema3()
        {
            Lista<int> list = new Lista<int>();
            list.Add(11); list.Add(7); list.Add(2);
            list.Add(11); list.Add(7); list.Add(3);

            output.WriteLine(list.ToString());
            if (list.Count() % 2 == 1)
            {
                output.WriteLine("false");
                return;
            }

            int half = list.Count() / 2;
            for (int i = 0; i < half; i++)
            {
                if (list.ElementAt(i) != list.ElementAt(i + half))
                {
                    output.WriteLine("false");
                    return;
                }
            }
            output.WriteLine("true");
        }

        // Problema 4
        // Să se scrie o funcție C++ care determină câte perechi de elemente
        // consecutive egale sunt memorate într-o lista simplu înlănțuită.

        [Fact]
        public void Problema4()
        {
            Lista<int> list = new Lista<int>();
            list.Add(1); list.Add(6); list.Add(6);
            list.Add(4); list.Add(5); list.Add(5);
            list.Add(5); list.Add(1);

            int c = 0;
            while(list.Count() > 1)
            {
                if(list.Iterator().Data == list.ElementAt(1))
                {
                    c++;
                }
                list.RemoveStart();
            }

            output.WriteLine(c.ToString());
        }

        // Problema 5
        // Să se scrie o funcție C++ care oglindește
        // nodurile unei liste simplu înlănțuite alocate dinamic.

        [Fact]
        public void Problema5()
        {
            Lista<int> list = new Lista<int>();
            list.Add(1); list.Add(6); list.Add(6);
            list.Add(4); list.Add(5);

            Lista<int> oglindire = new Lista<int>();
            while(list.Count() > 0)
            {
                oglindire.AddStart(list.Iterator().Data);
                list.RemoveStart();
            }

            output.WriteLine(oglindire.ToString());
        }

        // Problema 6
        // Să se scrie o funcție C++ care șterge dintr-o lista
        // simplu înlănțuită elementul situat după un element dat.

        [Fact]
        public void Problema6()
        {
            Lista<int> list = new Lista<int>();
            list.Add(1); list.Add(6); list.Add(6);
            list.Add(4); list.Add(5);

            int number = 1;
            list.Remove(list.IndexOf(number) + 1);

            output.WriteLine(list.ToString());
        }

        // Problema 7
        // Să se scrie o funcție C++ care șterge dintr-o
        // lista simplu înlănțuită toate elementele pare.

        [Fact]
        public void Problema7()
        {
            Lista<int> list = new Lista<int>();
            list.Add(1); list.Add(6); list.Add(6);
            list.Add(4); list.Add(5);

            for(int i = 0; i < list.Count(); i++)
            {
                if(list.ElementAt(i) % 2 == 0)
                {
                    list.Remove(i);
                    i--;
                }
            }

            output.WriteLine(list.ToString());
        }

        // Problema 8
        // Să se scrie o funcție C++ care inserează o anumită
        // valoare după un element dat dintr-o lista simplu înlănțuită.

        [Fact]
        public void Problema8()
        {
            Lista<int> list = new Lista<int>();
            list.Add(1); list.Add(6); list.Add(6);
            list.Add(4); list.Add(5);

            int number = 6, toAdd = 9;
            list.Add(toAdd, list.IndexOf(number) + 1);

            output.WriteLine(list.ToString());
        }

        // Problema 9
        // Să se scrie o funcție C++ care inserează după fiecare
        // element par al unei liste simplu înlănțuită dublul său.

        [Fact]
        public void Problema9()
        {
            Lista<int> list = new Lista<int>();
            list.Add(1); list.Add(6); list.Add(6);
            list.Add(4); list.Add(5);

            Lista<int> newlist = new Lista<int>();
            while(list.Count() > 0)
            {
                int number = list.Iterator().Data;
                newlist.Add(number);
                if(number % 2 == 0)
                {
                    newlist.Add(number * 2);
                }
                list.RemoveStart();
            }

            while(newlist.Count() > 0)
            {
                list.Add(newlist.Iterator().Data);
                newlist.RemoveStart();
            }

            output.WriteLine(list.ToString());
        }
    }
}
