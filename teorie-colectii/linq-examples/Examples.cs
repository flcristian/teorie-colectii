using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teorie_colectii.car.comparators;
using teorie_colectii.car.model;
using teorie_colectii.order.model;
using teorie_colectii.person.comparators;
using teorie_colectii.person.model;

namespace teorie_colectii.linq_examples
{
    public class Examples
    {
        public static void ExampleListFiltering1()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Filtering even numbers and projecting their squares
            IEnumerable<int> evenSquares = numbers
                .Where(n => n % 2 == 0)
                .Select(n => n* n);

            Console.WriteLine("Filtering example 1 :");
            evenSquares.ToList().ForEach(s =>
            {
                Console.WriteLine(s);
            });
            Console.WriteLine();
        }

        public static void ExampleListFiltering2()
        {
            List<Car> cars = new List<Car>
            {
                ICar.BuildCar()
                    .Make("Dacia")
                    .Model("Logan")
                    .Color("Black")
                    .Year(2014),
                ICar.BuildCar()
                    .Make("Ford")
                    .Model("Focus")
                    .Color("Blue")
                    .Year(2016),
                ICar.BuildCar()
                    .Make("Volkswagen")
                    .Make("Golf")
                    .Color("White")
                    .Year(2010)
            };

            IEnumerable<Car> newerCars = cars
                .Where(c => c.GetYear() > 2010)
                .Select(c => c);

            Console.WriteLine("Filtering example 2 :");
            newerCars.ToList().ForEach(car =>
            {
                Console.WriteLine(car);
            });
        }

        public static void ExampleListFiltering3()
        {
            List<Car> cars = new List<Car>
            {
                ICar.BuildCar()
                    .Make("Dacia")
                    .Model("Logan")
                    .Color("Black")
                    .Year(2014),
                ICar.BuildCar()
                    .Make("Ford")
                    .Model("Focus")
                    .Color("Blue")
                    .Year(2016),
                ICar.BuildCar()
                    .Make("Volkswagen")
                    .Make("Golf")
                    .Color("White")
                    .Year(2010)
            };

            IEnumerable<Car> filtered = cars
                .Where(c => c.GetMake().Equals("Ford"))
                .Select(c => c);

            Console.WriteLine("Filtering example 3 :");
            filtered.ToList().ForEach(c =>
            {
                Console.WriteLine(c);
            });
        }

        public static void ExampleSorting1()
        {
            List<int> numbers = new List<int> { 2, 3, 1, 6, 7, 9 };

            IEnumerable<int> sorted = numbers.OrderBy(n => n);

            Console.WriteLine("Sorting example :");
            sorted.ToList().ForEach(s =>
            {
                Console.WriteLine(s);
            });
            Console.WriteLine();
        }

        public static void ExampleSorting2()
        {
            List<Car> cars = new List<Car>
            {
                ICar.BuildCar()
                    .Make("Dacia")
                    .Model("Logan")
                    .Color("Black")
                    .Year(2014),
                ICar.BuildCar()
                    .Make("Ford")
                    .Model("Focus")
                    .Color("Blue")
                    .Year(2016),
                ICar.BuildCar()
                    .Make("Volkswagen")
                    .Model("Golf")
                    .Color("White")
                    .Year(2010)
            };

            IEnumerable<Car> sorted = cars.OrderByDescending(car => car, new ModelComparator());

            Console.WriteLine("Sorting example 2 :");
            sorted.ToList().ForEach(car =>
            {
                Console.WriteLine(car);
            });
        }

        public static void ExampleSorting3()
        {
            List<Person> persons = new List<Person> {
                IPerson.BuildPerson()
                    .Id(1)
                    .Age(18)
                    .Name("Andrei")
                    .Email("andrei@email.com"),
                IPerson.BuildPerson()
                    .Id(2)
                    .Age(19)
                    .Name("Marius")
                    .Email("marius@email.com"),
                IPerson.BuildPerson()
                    .Id(3)
                    .Age(23)
                    .Name("Paul")
                    .Email("paul@email.com")
            };

            IEnumerable<Person> sorted = persons.OrderBy(person => person, new NameComparator());

            Console.WriteLine("Sorting example 3 :");
            sorted.ToList().ForEach(person =>
            {
                Console.WriteLine(person);
            });
        }

        public static void ExampleGrouping1()
        {
            List<Car> cars = new List<Car>
            {
                ICar.BuildCar()
                    .Make("Dacia")
                    .Model("Logan")
                    .Color("Black")
                    .Year(2014),
                ICar.BuildCar()
                    .Make("Ford")
                    .Model("Focus")
                    .Color("Blue")
                    .Year(2014),
                ICar.BuildCar()
                    .Make("Dacia")
                    .Model("Duster")
                    .Color("Black")
                    .Year(2018),
                ICar.BuildCar()
                    .Make("Volkswagen")
                    .Model("Golf")
                    .Color("White")
                    .Year(2010)

            };

            IEnumerable<IGrouping<string, Car>> groupedByYear = cars.GroupBy(car => car.GetMake());

            Console.WriteLine("Grouping example 1 :");
            groupedByYear.ToList().ForEach(group =>
            {
                Console.WriteLine(group.Key);
                group.ToList().ForEach(car =>
                {
                    Console.WriteLine(car);
                });
            });

            int averageYear = (int)cars.Average(car => car.GetYear());
            Console.WriteLine($"Average year : {averageYear}\n");
        }

        public static void ExampleGrouping2()
        {
            List<Person> persons = new List<Person> {
                IPerson.BuildPerson()
                    .Id(1)
                    .Age(18)
                    .Name("Andrei")
                    .Email("andrei@email.com"),
                IPerson.BuildPerson()
                    .Id(2)
                    .Age(19)
                    .Name("Marius")
                    .Email("marius@email.com"),
                IPerson.BuildPerson()
                    .Id(3)
                    .Age(23)
                    .Name("Paul")
                    .Email("paul@email.com"),
                IPerson.BuildPerson()
                    .Id(4)
                    .Age(18)
                    .Name("Adrian")
                    .Email("adrian@email.com"),
                IPerson.BuildPerson()
                    .Id(5)
                    .Age(18)
                    .Name("Maria")
                    .Email("maria@email.com"),
                IPerson.BuildPerson()
                    .Id(6)
                    .Age(23)
                    .Name("Robert")
                    .Email("robert@email.com")
            };

            IEnumerable<IGrouping<int, Person>> groupedByAge = persons.GroupBy(person => person.GetAge());

            Console.WriteLine("Grouping example 2 :");
            groupedByAge.ToList().ForEach(group =>
            {
                Console.WriteLine(group.Key);
                group.ToList().ForEach(person =>
                {
                    Console.WriteLine(person);
                });
            });
        }

        public static void ExampleJoining1()
        {
            List<Car> cars = new List<Car>
            {
                ICar.BuildCar()
                    .Id(1)
                    .Make("Dacia")
                    .Model("Logan")
                    .Color("Black")
                    .Year(2014),
                ICar.BuildCar()
                    .Id(2)
                    .Make("Ford")
                    .Model("Focus")
                    .Color("Blue")
                    .Year(2014),
                ICar.BuildCar()
                    .Id(3)
                    .Make("Dacia")
                    .Model("Duster")
                    .Color("Black")
                    .Year(2018)
            };

            List<Person> persons = new List<Person> {
                IPerson.BuildPerson()
                    .Id(1)
                    .Age(18)
                    .Name("Andrei")
                    .Email("andrei@email.com"),
                IPerson.BuildPerson()
                    .Id(2)
                    .Age(19)
                    .Name("Marius")
                    .Email("marius@email.com"),
                IPerson.BuildPerson()
                    .Id(3)
                    .Age(23)
                    .Name("Paul")
                    .Email("paul@email.com")
            };

            List<Order> orders = new List<Order>
            {
                IOrder.BuildOrder()
                    .Id(101)
                    .CarId(2)
                    .PersonId(3),
                IOrder.BuildOrder()
                    .Id(102)
                    .CarId(1)
                    .PersonId(2),
                IOrder.BuildOrder()
                    .Id(103)
                    .CarId(3)
                    .PersonId(1)
            };

            // Inner join
            var innerJoin = from order in orders
                            join car in cars on order.GetCarId() equals car.GetId()
                            join person in persons on order.GetPersonId() equals person.GetId()
                            select new
                            {
                                OrderId = order.GetId(),
                                CarMake = car.GetMake(),
                                PersonName = person.GetName()
                            };


            innerJoin.ToList().ForEach(result =>
            {
                Console.WriteLine($"Order {result.OrderId} : {result.PersonName} - {result.CarMake}");
            });
            Console.WriteLine();

            // Left outer join
            var leftOuterJoin = from car in cars
                                join order in orders on car.GetId() equals order.GetCarId() into carOrders
                                from co in carOrders.DefaultIfEmpty()
                                select new
                                {
                                    CarMake = car.GetMake(),
                                    OrderId = co?.GetId(),
                                    PersonName = co != null ? persons.FirstOrDefault(p => p.GetId() == co.GetPersonId()).GetName() : "N/A"
                                };

            leftOuterJoin.ToList().ForEach(result =>
            {
                Console.WriteLine($"Order {result.OrderId} : {result.PersonName} - {result.CarMake}");
            });
            Console.WriteLine();

            // Group join

            var groupJoin = from car in cars
                            join order in orders on car.GetId() equals order.GetCarId() into carOrders
                            select new
                            {
                                CarId = car.GetId(),
                                OrderCount = carOrders.Count(),
                                PersonNames = from co in carOrders
                                              join person in persons on co.GetPersonId() equals person.GetId()
                                              select person.GetName()
                            };

            groupJoin.ToList().ForEach(result =>
            {
                Console.WriteLine($"Car id {result.CarId} - Ordered {result.OrderCount} times");
                Console.WriteLine("Who ordered :");
                result.PersonNames.ToList().ForEach(p =>
                {
                    Console.WriteLine(p);
                });
            });
            Console.WriteLine();
        }

        public static void ExampleJoining2()
        {
            List<Car> cars = new List<Car>
            {
                ICar.BuildCar()
                    .Id(1)
                    .Make("Dacia")
                    .Model("Logan")
                    .Color("Black")
                    .Year(2014),
                ICar.BuildCar()
                    .Id(2)
                    .Make("Ford")
                    .Model("Focus")
                    .Color("Blue")
                    .Year(2014),
                ICar.BuildCar()
                    .Id(3)
                    .Make("Dacia")
                    .Model("Duster")
                    .Color("Black")
                    .Year(2018)
            };

            List<Person> persons = new List<Person> {
                IPerson.BuildPerson()
                    .Id(1)
                    .Age(18)
                    .Name("Andrei")
                    .Email("andrei@email.com"),
                IPerson.BuildPerson()
                    .Id(2)
                    .Age(19)
                    .Name("Marius")
                    .Email("marius@email.com"),
                IPerson.BuildPerson()
                    .Id(3)
                    .Age(23)
                    .Name("Paul")
                    .Email("paul@email.com")
            };

            List<Order> orders = new List<Order>
            {
                IOrder.BuildOrder()
                    .Id(101)
                    .CarId(2)
                    .PersonId(3),
                IOrder.BuildOrder()
                    .Id(102)
                    .CarId(1)
                    .PersonId(2),
                IOrder.BuildOrder()
                    .Id(103)
                    .CarId(3)
                    .PersonId(1)
            };

            var joined1 = from order in orders
                         join car in cars on order.GetCarId() equals car.GetId()
                         join person in persons on order.GetPersonId() equals person.GetId()
                         select new
                         {
                             Order = order,
                             Car = car,
                             Person = person            
                         };

            Console.WriteLine("JOIN 1");
            joined1.ToList().ForEach(result =>
            {
                Console.WriteLine($"RESULT {joined1.ToList().IndexOf(result) + 1}");
                Console.WriteLine(result.Order);
                Console.WriteLine(result.Car);
                Console.WriteLine(result.Person);
            });

            var joined2 = from order in orders
                          join car in cars on order.GetCarId() equals car.GetId()
                          select new
                          {
                              Order = order,
                              Car = car,
                              Person = persons.FirstOrDefault(person => person.GetId() == order.GetPersonId())
                          };

            Console.WriteLine("JOIN 2");
            joined2.ToList().ForEach(result =>
            {
                Console.WriteLine($"RESULT {joined2.ToList().IndexOf(result) + 1}");
                Console.WriteLine(result.Order);
                Console.WriteLine(result.Car);
                Console.WriteLine(result.Person);
            });
        }

        public static void ExampleUnion1() {
            List<int> A = new List<int> { 1, 2, 3, 4, 5 };
            List<int> B = new List<int> { 3, 4, 5, 6, 7 };

            IEnumerable<int> union = A.Union(B);
            IEnumerable<int> intersection = A.Intersect(B);
            IEnumerable<int> difference = A.Except(B);

            Console.WriteLine("UNION :");
            union.ToList().ForEach(n =>
            {
                Console.Write($"{n} ");
            });
            Console.WriteLine();

            Console.WriteLine("INTERSECTION :");
            intersection.ToList().ForEach(n =>
            {
                Console.Write($"{n} ");
            });
            Console.WriteLine();

            Console.WriteLine("DIFFERENCE :");
            difference.ToList().ForEach(n =>
            {
                Console.Write($"{n} ");
            });
            Console.WriteLine("\n");
        }

        public static void ExampleUnion2()
        {
            List<Car> A = new List<Car>
            {
                ICar.BuildCar()
                    .Id(1)
                    .Make("Dacia")
                    .Model("Logan")
                    .Color("Black")
                    .Year(2014),
                ICar.BuildCar()
                    .Id(2)
                    .Make("Ford")
                    .Model("Focus")         
                    .Color("Blue")
                    .Year(2016),
                ICar.BuildCar()
                    .Id(3)
                    .Make("Volkswagen")
                    .Model("Golf")
                    .Color("White")
                    .Year(2010)
            };

            List<Car> B = new List<Car>
            {
                ICar.BuildCar()
                    .Id(2)          
                    .Make("Ford")
                    .Model("Focus")         
                    .Color("Blue")
                    .Year(2016),
                ICar.BuildCar()
                    .Id(3)
                    .Make("Volkswagen")
                    .Model("Golf")
                    .Color("White")
                    .Year(2010),
                ICar.BuildCar()
                    .Id(4)
                    .Make("Volkswagen")
                    .Model("Tiguan")
                    .Color("Black")
                    .Year(2012)
            };

            IEnumerable<Car> union = A.Union(B, new CarEqualityComparer());
            IEnumerable<Car> intersection = A.Intersect(B, new CarEqualityComparer());
            IEnumerable<Car> difference = A.Except(B, new CarEqualityComparer());


            Console.WriteLine("UNION :");
            union.ToList().ForEach(car =>
            {
                Console.WriteLine(car);
            });
            Console.WriteLine();

            Console.WriteLine("INTERSECTION :");
            intersection.ToList().ForEach(car =>
            {
                Console.WriteLine(car);
            });
            Console.WriteLine();

            Console.WriteLine("DIFFERENCE :");
            difference.ToList().ForEach(car =>
            {
                Console.WriteLine(car);
            });
            Console.WriteLine();
        }

        public static void ExampleConditionVerifiers1()
        {
            List<int> numbers = new List<int> { 2, 4, 6, 8, 10 };

            bool allEven = numbers.All(n => n % 2 == 0);
            bool anyBiggerThan5 = numbers.Any(n => n > 5);

            Console.WriteLine($"Are all numbers even? {allEven}");
            Console.WriteLine($"Are there any numbers bigger than 5? {anyBiggerThan5}");
        }

        public static void ExampleConditionVerifiers2()
        {
            List<Car> cars = new List<Car>
            {
                ICar.BuildCar()
                    .Id(1)
                    .Make("Dacia")
                    .Model("Logan")
                    .Color("Black")
                    .Year(2014),
                ICar.BuildCar()
                    .Id(2)
                    .Make("Ford")
                    .Model("Focus")
                    .Color("Blue")
                    .Year(2016),
                ICar.BuildCar()
                    .Id(3)
                    .Make("Volkswagen")
                    .Model("Golf")
                    .Color("White")
                    .Year(2010)
            };

            bool anyVolkswagen = cars.Any(car => car.GetMake().Equals("Volkswagen"));
            bool allCarsNewerThan2015 = cars.All(car => car.GetYear() > 2015);

            Console.WriteLine($"Are there any Volkswagen cars? {anyVolkswagen}");
            Console.WriteLine($"Are all cars newer than 2015? {allCarsNewerThan2015}");
        }

        public static void ExampleFirstLast1()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7 };

            int firstOdd = numbers.First(n => n % 2 == 1);
            int lastEven = numbers.Last(n => n % 2 == 0);
            int secondElement = numbers.ElementAt(1);

            Console.WriteLine($"First odd : {firstOdd}");
            Console.WriteLine($"Last even : {lastEven}");
            Console.WriteLine($"Second element : {secondElement}");
        }

        public static void ExampleFirstLast2()
        {
            List<Car> cars = new List<Car>
            {
                ICar.BuildCar()
                    .Id(1)
                    .Make("Dacia")
                    .Model("Logan")
                    .Color("Black")
                    .Year(2014),
                ICar.BuildCar()
                    .Id(2)
                    .Make("Ford")
                    .Model("Focus")
                    .Color("Blue")
                    .Year(2016),
                ICar.BuildCar()
                    .Id(3)
                    .Make("Volkswagen")
                    .Model("Golf")
                    .Color("White")
                    .Year(2010)
            };

            Car firstFrom2016 = cars.First(car => car.GetYear() == 2016);
            Car lastVolkswagen = cars.Last(car => car.GetMake().Equals("Volkswagen"));
            Car thirdElement = cars.ElementAt(2);

            Console.WriteLine($"First from 2016 :\n{firstFrom2016}");
            Console.WriteLine($"Last Volkswagen :\n{lastVolkswagen}");
            Console.WriteLine($"Third element :\ng{thirdElement}");
        }
    }
}
