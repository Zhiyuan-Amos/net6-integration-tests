using Api;

namespace ApiTest;

public class TestDummyHelper : DummyHelper
{
    public override string CallDummyEndpoint(string toReturn) => base.CallDummyEndpoint("notDummy");
}
