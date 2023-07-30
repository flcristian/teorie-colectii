using Microsoft.VisualStudio.TestPlatform.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teorie_colectii.car.model;
using teorie_colectii.colectii.stiva;
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
            Car a = new Car(0, "a", "a", "a");
            Car b = new Car(1, "b", "b", "b");
            Car c = new Car(2, "c", "c", "c");

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
            Car a = new Car(0, "a", "a", "a");
            Car b = new Car(1, "b", "b", "b");
            Car c = new Car(2, "c", "c", "c");
            stiva.Push(a);
            stiva.Push(b);
            stiva.Push(c);

            // Act
            stiva.Pop();

            // Assert
            output.WriteLine(stiva.ToString());
        }

        [Fact]
        public void TestPeekk()
        {
            // Arrange
            Stiva<Car> stiva = new Stiva<Car>();
            Car a = new Car(0, "a", "a", "a");
            Car b = new Car(1, "b", "b", "b");
            Car c = new Car(2, "c", "c", "c");
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
            Car a = new Car(0, "a", "a", "a");
            Car b = new Car(1, "b", "b", "b");
            Car c = new Car(2, "c", "c", "c");

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
    }
}
