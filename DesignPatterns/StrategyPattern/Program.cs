using StrategyPattern;

// The client code picks a concrete strategy and passes it to the
// context. The client should be aware of the differences between
// strategies in order to make the right choice.

Duck mallared = new MallaredDuck();

mallared.SetFlyBehavior(new FlyNoWay());
mallared.PerformFly();

mallared.SetFlyBehavior(new FlyWithWings());
mallared.PerformFly();

mallared.SetQuackBehavior(new Quack());
mallared.PerformQuack();

mallared.SetFlyBehavior(new FlyBehavior());
mallared.PerformFly();

mallared.PerformSwim();