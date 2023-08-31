using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teorie_colectii.car.model;
using teorie_colectii.colectii.hashtable;
using teorie_colectii.colectii.lista;
using Xunit.Abstractions;

namespace test_lista.Tests
{
    public class TestHashTable
    {
        private readonly ITestOutputHelper output;

        public TestHashTable(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void TestPutAndGet()
        {
            HashTable<String, Car> hash = new HashTable<String, Car>(1000);

            Car data = ICar.BuildCar()
                .Make("Volkswagen")
                .Model("Polo")
                .Color("Black")
                .Year(2015);

            hash.Put("marian", data);

            Car check = ICar.BuildCar()
                .Make("Volkswagen")
                .Model("Polo")
                .Color("Black")
                .Year(2015);

            hash.Put("cosmin", check);

            Car car1 = ICar.BuildCar();
            Car car2 = ICar.BuildCar();
            Car car3 = ICar.BuildCar();

            hash.Put("ashf1asfja", car1);
            hash.Put("a", car2);
            hash.Put("askf", car3);

            // Assert

            output.WriteLine(hash.ToString());
            Assert.Equal(data, hash.Get("marian"));
            Assert.Equal(check, hash.Get("cosmin"));
        }

        [Fact]
        public void TestIsEmpty()
        {
            HashTable<String, Car> hash = new HashTable<String, Car>(1000);

            Assert.True(hash.IsEmpty());

            Car car = ICar.BuildCar()
                .Make("Volkswagen")
                .Model("Polo")
                .Color("Black")
                .Year(2015);

            hash.Put("car", car);

            Assert.False(hash.IsEmpty());
        }

        [Fact]
        public void TestContainsKey()
        {
            HashTable<String, Car> hash = new HashTable<String, Car>(1000);

            Assert.False(hash.ContainsKey("car"));

            Car car = ICar.BuildCar()
                .Make("Volkswagen")
                .Model("Polo")
                .Color("Black")
                .Year(2015);

            hash.Put("cat", car);

            Assert.False(hash.ContainsKey("car"));

            hash.Put("car", car);

            Assert.True(hash.ContainsKey("car"));
        }

        [Fact]
        public void TestContainsValue()
        {
            HashTable<String, Car> hash = new HashTable<String, Car>(1000);

            Car car = ICar.BuildCar()
                .Make("Volkswagen")
                .Model("Polo")
                .Color("Black")
                .Year(2015);

            Assert.False(hash.ContainsValue(car));

            hash.Put("car", car);

            Assert.True(hash.ContainsValue(car));
        }

        [Fact]
        public void TestKeyList()
        {
            HashTable<String, Car> hash = new HashTable<String, Car>(1000);
            ILista<String> check = new Lista<String>(), check2 = new Lista<String>();
            check.Add("car");
            check2.Add("cat");

            Car car = ICar.BuildCar()
                .Make("Volkswagen")
                .Model("Polo")
                .Color("Black")
                .Year(2015);

            hash.Put("car", car);

            Assert.Equal(check, hash.KeyList());
            Assert.NotEqual(check2, hash.KeyList());
        }

        [Fact]
        public void TestRemove()
        {
            HashTable<String, Car> hash = new HashTable<String, Car>(1000);

            Car car = ICar.BuildCar()
                .Make("Volkswagen")
                .Model("Polo")
                .Color("Black")
                .Year(2015);

            hash.Put("cat", car);
            hash.Put("car", car);
            hash.Put("abc", car);

            hash.Remove("car");

            Assert.True(hash.ContainsKey("cat"));
            Assert.False(hash.ContainsKey("car"));
            Assert.True(hash.ContainsKey("abc"));
        }

        [Fact]
        public void TestValues()
        {
            HashTable<String, Car> hash = new HashTable<String, Car>(1000);
            ILista<Car> check = new Lista<Car>();

            Car car = ICar.BuildCar()
                .Make("Volkswagen")
                .Model("Polo")
                .Color("Black")
                .Year(2015);

            check.Add(car);

            hash.Put("car", car);

            Assert.Equal(check, hash.Values());
        }
    }
}
