using System.Collections.Generic;
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

        // Problema 10
        // Să se scrie o funcție C++ care inserează înaintea
        // fiecărui element par al unei liste simplu înlănțuită dublul său.

        [Fact]
        public void Problema10()
        {
            Lista<int> list = new Lista<int>();
            list.Add(1); list.Add(6); list.Add(6);
            list.Add(4); list.Add(5);

            Lista<int> newlist = new Lista<int>();
            while (list.Count() > 0)
            {
                int number = list.Iterator().Data;
                if (number % 2 == 0)
                {
                    newlist.Add(number * 2);
                }
                newlist.Add(number);
                list.RemoveStart();
            }

            while (newlist.Count() > 0)
            {
                list.Add(newlist.Iterator().Data);
                newlist.RemoveStart();
            }

            // Assert

            Lista<int> check = new Lista<int>();
            check.Add(1); check.Add(12); check.Add(6);
            check.Add(12); check.Add(6); check.Add(8);
            check.Add(4); check.Add(5);

            while (check.Count() > 0)
            {
                Assert.Equal(check.Iterator().Data, list.Iterator().Data);
                check.RemoveStart();
                list.RemoveStart();
            }
        }

        // Problema 11
        // Să se scrie o funcție care interclasează două liste.

        [Fact]
        public void Problema11()
        {
            Lista<int> a = new Lista<int>();
            a.Add(1); a.Add(3); a.Add(5); a.Add(6); a.Add(10);
            Lista<int> b = new Lista<int>();
            b.Add(2); b.Add(3); b.Add(7); b.Add(8);

            Lista<int> c = new Lista<int>();
            while(a.Count() > 0 && b.Count() > 0)
            {
                int ai = a.Iterator().Data, bi = b.Iterator().Data;
                if(ai < bi)
                {
                    c.Add(ai);
                    a.RemoveStart();
                } 
                else if(ai == bi)
                {
                    c.Add(ai);
                    a.RemoveStart();
                    b.RemoveStart();
                }
                else
                {
                    c.Add(bi);
                    b.RemoveStart();
                }
            }
            while(a.Count() > 0)
            {
                c.Add(a.Iterator().Data);
                a.RemoveStart();
            }
            while (b.Count() > 0)
            {
                c.Add(b.Iterator().Data);
                b.RemoveStart();
            }

            // Assert

            Lista<int> check = new Lista<int>();
            check.Add(1); check.Add(2); check.Add(3);
            check.Add(5); check.Add(6); check.Add(7);
            check.Add(8); check.Add(10);

            while (check.Count() > 0)
            {
                Assert.Equal(check.Iterator().Data, c.Iterator().Data);
                check.RemoveStart();
                c.RemoveStart();
            }
        }

        // Problema 12
        // Sa se scrie o functie care sorteaza o lista crescator.

        [Fact]
        public void Problema12()
        {
            Lista<int> list = new Lista<int>();
            list.Add(6); list.Add(1); list.Add(3); list.Add(10);
            list.Add(9); list.Add(3); list.Add(4); list.Add(2);

            Lista<int> final = new Lista<int>();
            bool flag = true;
            while(flag && list.Count() > 1)
            {
                flag = false;
                for(int j = list.Count() - 1; j > 0; j--)
                {
                    if (list.ElementAt(j) < list.ElementAt(j - 1))
                    {
                        int r = list.ElementAt(j - 1);
                        list.Remove(j - 1);
                        list.Add(r, j);
                        flag = true;
                    }
                }
                final.Add(list.Iterator().Data);
                list.RemoveStart();
            }

            while(list.Count() > 0)
            {
                final.Add(list.Iterator().Data);
                list.RemoveStart();
            }

            // Assert
            Lista<int> check = new Lista<int>();
            check.Add(1); check.Add(2); check.Add(3); check.Add(3);
            check.Add(4); check.Add(6); check.Add(9); check.Add(10);

            while (check.Count() > 0)
            {
                Assert.Equal(check.Iterator().Data, final.Iterator().Data);
                check.RemoveStart();
                final.RemoveStart();
            }
        }

        // Problema 13
        // Sa se verifice dacă o listă simplu înlănțuită formează un palindrom.

        [Fact]
        public void Problema13()
        {
            Lista<int> list = new Lista<int>();
            list.Add(1); list.Add(2); list.Add(7); list.Add(2); list.Add(1);

            bool palindrom = true;
            while(list.Count() > 1)
            {
                if(list.Iterator().Data != list.ElementAt(list.Count() - 1))
                {
                    palindrom = false;
                    break;
                }
                list.RemoveStart();
                list.Remove(list.Count() - 1);
            }

            // Assert

            Assert.True(palindrom);
        }

        // Problema 14
        // Să se scrie o funcție care să elimine nodurile care conțin
        // duplicate dintr-o listă care are valorile ordonate crescător.

        [Fact]
        public void Problema14()
        {
            Lista<int> list = new Lista<int>();
            list.Add(3); list.Add(3); list.Add(3);
            list.Add(5); list.Add(5); list.Add(7);
            list.Add(10); list.Add(10);

            Lista<int> mod = new Lista<int>();
            int last = -1;
            while(list.Count() > 0)
            {
                if(list.Iterator().Data != last)
                {
                    last = list.Iterator().Data;
                    mod.Add(last);
                }
                list.RemoveStart();
            }

            while(mod.Count() > 0)
            {
                list.Add(mod.Iterator().Data);
                mod.RemoveStart();
            }

            // Assert

            Lista<int> check = new Lista<int>();
            check.Add(3); check.Add(5); check.Add(7); check.Add(10);

            while (check.Count() > 0)
            {
                Assert.Equal(check.Iterator().Data, list.Iterator().Data);
                check.RemoveStart();
                list.RemoveStart();
            }
        }
    }
}
