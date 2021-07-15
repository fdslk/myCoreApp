using System;
using Bogus;
using Models;

namespace Common
{
    public static class DataHelper{
        public static Order GenerateOrder(){
            var faker = new Faker<Order>();
            
            faker.RuleFor(Order=>Order.Id, faker=>faker.Random.Number(1, 10))
            .RuleFor(Order=>Order.Name, faker=>faker.Random.String())
            .RuleFor(Order=>Order.Note, faker=>faker.Random.Words())
            .RuleFor(Order=>Order.OrderedDate, faker=>DateTime.Now);
            
            return faker.Generate();
        }
    }
}