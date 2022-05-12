using Api;

namespace ApiTest;

public class TestDummyHelper : DummyHelper
{
    public override string DummyMethod(string toReturn) => base.DummyMethod("notDummy");
}
