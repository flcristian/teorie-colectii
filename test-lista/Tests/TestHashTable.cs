using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teorie_colectii.car.model;
using teorie_colectii.colectii.hashtable;
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
    }
}
