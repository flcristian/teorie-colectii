using Microsoft.VisualStudio.TestPlatform.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using teorie_colectii.car.model;
using teorie_colectii.colectii.coada;
using teorie_colectii.colectii.stiva;
using teorie_colectii.cub;
using teorie_colectii.interval;
using Xunit.Abstractions;

namespace test_lista.Tests
{
    public class TestStiva
    {
        private readonly ITestOutputHelper output;

        public TestStiva(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void TestPush()
        {
            // Arrange
            Stiva<Car> stiva = new Stiva<Car>();
            Car a = new Car(-1, "a", "a", "a", 2000);
            Car b = new Car(-1, "b", "b", "b", 2000);
            Car c = new Car(-1, "c", "c", "c", 2000);

            // Act
            stiva.Push(a);
            stiva.Push(b);
            stiva.Push(c);

            // Assert
            output.WriteLine(stiva.ToString());
        }

        [Fact]
        public void TestPop()
        {
            // Arrange
            Stiva<Car> stiva = new Stiva<Car>();
            Car a = new Car(-1, "a", "a", "a", 2000);
            Car b = new Car(-1, "b", "b", "b", 2000);
            Car c = new Car(-1, "c", "c", "c", 2000);
            stiva.Push(a);
            stiva.Push(b);
            stiva.Push(c);

            // Act
            stiva.Pop();

            // Assert
            output.WriteLine(stiva.ToString());
        }

        [Fact]
        public void TestPeek()
        {
            // Arrange
            Stiva<Car> stiva = new Stiva<Car>();
            Car a = new Car(-1, "a", "a", "a", 2000);
            Car b = new Car(-1, "b", "b", "b", 2000);
            Car c = new Car(-1, "c", "c", "c", 2000);
            stiva.Push(a);
            stiva.Push(b);
            stiva.Push(c);

            // Act
            Car check = stiva.Peek();

            // Assert
            Assert.Equal(c, check);
            output.WriteLine(check.ToString());
        }

        [Fact]
        public void TestIsEmpty()
        {
            // Arrange
            Stiva<Car> stiva = new Stiva<Car>();

            // Act
            bool empty = stiva.IsEmpty();

            // Assert
            Assert.True(empty);
        }

        [Fact]
        public void ExercitiuParanteze()
        {
            int openParentheses = 0, openSquareBrackets = 0, openCurlyBrackets = 0, openAngleBrackets = 0;

            IStiva<Char> stiva = new Stiva<Char>();
            String text = "(asfa{<sadaasf>}2131)123131[(dhasjfa)sadasfafqas]";
            bool invalidText = false;
            foreach (Char c in text)
            {
                if (invalidText)
                {
                    break;
                }

                switch (c)
                {
                    case '(':
                        stiva.Push(c);
                        break;
                    case ')':
                        if (stiva.IsEmpty() || stiva.Peek() != '(')
                        {
                            invalidText = true;
                        }
                        else
                        {
                            stiva.Pop();
                        }
                        break;

                    case '[':
                        stiva.Push(c);
                        break;
                    case ']':
                        if (stiva.IsEmpty() || stiva.Peek() != '[')
                        {
                            invalidText = true;
                        }
                        else
                        {
                            stiva.Pop();
                        }
                        break;

                    case '{':
                        stiva.Push(c);
                        break;
                    case '}':
                        if (stiva.IsEmpty() || stiva.Peek() != '{')
                        {
                            invalidText = true;
                        }
                        else
                        {
                            stiva.Pop();
                        }
                        break;

                    case '<':
                        stiva.Push(c);
                        break;
                    case '>':
                        if (stiva.IsEmpty() || stiva.Peek() != '<')
                        {
                            invalidText = true;
                        }
                        else
                        {
                            stiva.Pop();
                        }
                        break;
                }
            }

            output.WriteLine("" + stiva.IsEmpty());
        }

        // Problema 1
        // Gigel are un set de n cuburi. Fiecare cub este marcat cu un număr natural,
        // de la 1 la n și i se cunoaște lungimea laturii – număr natural.
        //
        // Cu o parte dintre aceste cuburi Gigel va construi o stivă, astfel:
        // fiecare cub se analizează o singură dată, în ordinea numerelor marcate;
        // dacă stiva nu conține niciun cub, cubul curent devine baza stivei
        // dacă cubul curent are latura mai mică sau egală cu cubul din vârful stive, se adaugă pe stivă;
        // dacă cubul curent are latura mai mare decât cubul din vârful stivei, se vor înlătura
        // de pe stivă cuburi(eventual toate) până când cubul curent are latura mai mică sau egală cu
        // cubul din vârful stivei.        
        //
        // Să se afișeze numerele de pe cuburile existente la final în stivă, de la bază spre vârf.

        [Fact]
        public void Problema1()
        {
            List<Cub> cuburi = new List<Cub>
            {
                new Cub(0, 5),
                new Cub(1, 3),
                new Cub(2, 2),
                new Cub(3, 6),
                new Cub(4, 1),
                new Cub(5, 4)
            };

            Stiva<Cub> stiva = new Stiva<Cub>();
            foreach (Cub cub in cuburi)
            {
                if (stiva.IsEmpty())
                {
                    stiva.Push(cub);
                }
                else
                {
                    while (!stiva.IsEmpty() && stiva.Peek().CompareTo(cub) == -1)
                    {
                        stiva.Pop();
                    }
                    stiva.Push(cub);
                }
            }
            output.WriteLine(stiva.ToString());
        }

        // Problema 2
        // Eroul nostru, Căldărușe, are un număr n de cărți pe care le are aranjate una peste cealaltă
        // (sub forma unui stack). Cartea din vârf are valoarea a1, următoarea a2 și așa mai departe.
        // Cartea de la bază are indicele n (an). Toate numerele sunt distincte.
        //
        // Căldărușe vrea să mute toate cărțile în ghiozdanul lui în exact n pași.În timpul pasului de ordin i,
        // el vrea să mute cartea cu numărul bi în ghiozdan. Dacă această carte se află în stack, el o ia atât pe
        // ea, cât și toate cărțile situate deasupra acesteia și le pune în ghiozdan; în caz contrar, el nu va face
        // nimic și va trece la următorul pas.De exemplu, dacă în stack cărțile sunt aranjate în ordinea[1, 2, 3]
        // (cartea cu numărul 1 este aflată în vârf) și pașii prin care Căldărușe trece sunt, în această ordine,
        // [2, 1, 3], atunci în cadrul primului pas el va muta două cărți(1 și 2), în cadrul celui de-al doilea
        // pas nu va face nimic(din moment ce cartea cu numărul 1 este deja în ghiozdan) și în cadrul ultimului
        // pas va muta o singură carte(cartea cu numărul 3).

        [Fact]
        public void Problema2()
        {
            Stiva<int> carti = new Stiva<int>();
            carti.Push(4); carti.Push(5); 
            carti.Push(6); carti.Push(2);
            carti.Push(3); carti.Push(1);

            List<int> pasi = new List<int> { 3, 2, 1, 5, 6, 4 };
            foreach(int pas in pasi)
            {
                int c = 0;
                bool found = false;
                Stiva<int> removed = new Stiva<int>();

                while (!carti.IsEmpty() && carti.Peek() != pas)
                {
                    removed.Push(carti.Peek());
                    carti.Pop();
                    c++;
                }
                if (!carti.IsEmpty() && carti.Peek() == pas)
                {
                    found = true;
                    carti.Pop();
                    c++;
                }

                if (!found)
                {
                    while (!removed.IsEmpty())
                    {
                        carti.Push(removed.Peek());
                        removed.Pop();
                    }
                    c = 0;
                }
                output.WriteLine($"{c}");
            }
        }

        // Problema 3
        // Se consideră un șir de n intervale închise întregi.
        // // Două intervale consecutive în șir care au intersecția nevidă se reunesc și se
        // înlocuiesc în șir cu intervalul reuniune. Operația se repetă până când nu mai sunt
        // în șir două intervale consecutive cu intersecția nevidă.
        //
        // Să se determine câte intervale există în șir după realizarea acestor operații.
        
        [Fact]
        public void Problema3()
        {
            Stiva<Interval> stiva = new Stiva<Interval>();
            stiva.Push(new Interval(7, 11));
            stiva.Push(new Interval(8, 10));
            stiva.Push(new Interval(3, 5));
            stiva.Push(new Interval(4, 6));
            stiva.Push(new Interval(2, 3));

            bool intersectate = true;

            while (intersectate)
            {
                intersectate = false;

                Stiva<Interval> passed = new Stiva<Interval>();
                while (!stiva.IsEmpty())
                {
                    passed.Push(stiva.Peek());
                    stiva.Pop();

                    if (!stiva.IsEmpty() && passed.Peek().CompareTo(stiva.Peek()) == 1)
                    {
                        Interval interval = passed.Peek().ReuniteWith(stiva.Peek());
                        passed.Pop();
                        passed.Push(interval);
                        stiva.Pop();

                        intersectate = true;
                    }
                }

                while (!passed.IsEmpty())
                {
                    stiva.Push(passed.Peek());
                    passed.Pop();
                }
            }
            output.WriteLine(stiva.ToString());
        }

        // Problema 4
        // Se dă un șir de paranteze rotunde care se închid corect
        // (corect parantezat). Să se determine adâncimea parantezării.

        [Fact]
        public void Problema4()
        {
            String text = "(()((()())()))";

            int depth = 0;

            int open = 0;
            Stiva<char> stiva = new Stiva<char>();
            for(int i = 0; i < text.Length; i++)
            {
                stiva.Push(text[i]);
                if(stiva.Peek() == '(')
                {
                    open++;
                    if(open > depth)
                    {
                        depth = open;
                    }
                }
                else
                {
                    open--;
                }
            }

            output.WriteLine(depth.ToString());
        }

        // Problema 5
        // Se dă un șir cu n elemente, numere naturale.
        // Să se afișeze, pentru fiecare element din șir, valoarea din șir aflată după acesta
        // și mai mare decât acesta (Următorul Element Mai Mare). Dacă o asemenea valoare nu
        // există, se va afișa -1.

        [Fact]
        public void Problema5()
        {
            int count = 5;
            int[] numbers = new int[5] { 3, 4, 3, 5, 1 };

            Stiva<int> maxnr = new Stiva<int>();
            Stiva<int> check = new Stiva<int>();

            int pos = count - 1;
            while(pos > -1)
            {
                int max = -1;
                for (int i = pos + 1; i < count; i++)
                {
                    check.Push(numbers[i]);
                }

                while (!check.IsEmpty())
                {
                    if(check.Peek() > numbers[pos])
                    {
                        max = check.Peek();
                    }
                    check.Pop();
                }
                maxnr.Push(max);
                pos--;
            }

            int[] assert = new int[5] { 4, 5, 5, -1, -1 };

            int k = 0;
            while (k < count)
            {
                Assert.Equal(assert[k], maxnr.Iterator().Data);
                maxnr.Pop();
                k++;
            }
        }

        // Problema 6
        // Se consideră o expresie corectă formată din
        // numere naturale și operatorii +, -, *. Să se evalueze expresia.

        [Fact]
        public void Problema6()
        {

        }
    }
}
