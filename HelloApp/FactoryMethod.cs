namespace HelloApp
{
    public interface Product
    {
        public void doSomething();
    }

    public class Iphone : Product
    {
        public void doSomething()
        {
            Console.WriteLine("I`m calling");
        }
    }

    public class Ipad : Product
    {
        public void doSomething()
        {
            Console.WriteLine("I`m serfing the internet");
        }
    }

    public abstract class Creator
    {
        public abstract Product createProduct();
    }

    public class IpadFactory : Creator
    {
        public override Product createProduct()
        {
            return new Ipad();
        }
    }

    public class IphoneFactory : Creator
    {
        public override Product createProduct()
        {
            return new Iphone();
        }
    }

    public class Client
    {
        public static void doSomething(Creator factory)
        {
            Product someProduct = factory.createProduct();

            someProduct.doSomething();
        }
    }
}
