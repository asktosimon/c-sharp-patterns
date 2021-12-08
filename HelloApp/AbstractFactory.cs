namespace HelloApp
{
    public interface IChair
    {
        public string name { get; }
    }

    public interface ISofa
    {
        public string name { get; }
    }

    public class VictorianChair: IChair
    {
        public string name { get; }

        public VictorianChair(string name)
        {
            this.name = name;
        }
    }

    public class ModernChair : IChair
    {
        public string name { get; }

        public ModernChair(string name)
        {
            this.name = name;
        }
    }

    public class VictorianSofa: ISofa
    {
        public string name { get; }

        public VictorianSofa(string name)
        {
            this.name = name;
        }
    }

    public class ModernSofa : ISofa
    {
        public string name { get; }

        public ModernSofa(string name)
        {
            this.name = name;
        }
    }

    public interface IFactory
    {
        public IChair createChair(string name);

        public ISofa createSofa(string name);

    }

    public class ModernFactory: IFactory
    {
        public ISofa createSofa(string name)
        {
            return new ModernSofa(name);
        }

        public IChair createChair(string name)
        {
            return new ModernChair(name);
        }
    }

    public class VictorianFactory : IFactory
    {
        public ISofa createSofa(string name)
        {
            return new VictorianSofa(name);
        }

        public IChair createChair(string name)
        {
            return new VictorianChair(name);
        }
    }

    public enum stylesOfFurnuture
    {
        Victorian,
        Modern
    }
}