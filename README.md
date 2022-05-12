# Integration Tests on .NET 6

This repository demonstrates how a test class can extend an application class to provide mock parameters. The classes are related as follow:

```mermaid
classDiagram
DummyController --|> IDummyHelper
DummyController : string Get()

IDummyHelper <|-- DummyHelper
<<interface>> IDummyHelper
IDummyHelper : string DummyMethod(string toReturn)

DummyHelper <|-- TestDummyHelper
```

Refer to [logic file](Api/DummyHelper.cs) & [test file](ApiTest/DummyTest.cs) for more details. One caveat is that `DummyHelper.DummyMethod(string toReturn)` requires the `virtual` modifier for `TestDummyHelper` to `override.
