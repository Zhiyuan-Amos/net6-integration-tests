namespace Api;

public class DummyHelper : IDummyHelper
{
    public virtual string DummyMethod(string toReturn) => toReturn;
}
