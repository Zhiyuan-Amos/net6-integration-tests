namespace Api;

public class DummyHelper : IDummyHelper
{
    public virtual string CallDummyEndpoint(string toReturn) => toReturn;
}
