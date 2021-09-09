### list for how to make a abstract factory

* AbstractFactory- IGeneralVegetable
* ConcreteFactory - RootVegetable, StemVegetable
* AbstractProduct- IGenericVegetable, INonGenericVegetable
* Product- RootGenericVegetable, RootNonGenericVegetable, StemGenericVegetable, StemNonGenericVegetable
* Client- VegetableClient

SimpleFactory、FactoryMethod
Cons: 扩展时需要，修改工厂类
Pros: 适合于场景单一类型，简单不同类型的，不能有多层抽象

AbstractFactory
Cons: 
Pros: 扩展简单，只需要实现abstract 工厂即可（横向扩展），可以有多层工厂的抽象