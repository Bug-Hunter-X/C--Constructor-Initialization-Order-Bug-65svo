# C# Constructor Initialization Order Bug

This repository demonstrates a common bug in C# related to the order of constructor execution and property initialization.  When a derived class's constructor attempts to access properties or fields before the base class's constructor completes, unexpected behavior or exceptions can result.

## The Bug

The `BuggyConstructor.cs` file showcases the problem. The derived class's constructor tries to use a property that depends on values set in the base class constructor.  Because of the order of execution, this might lead to exceptions or incorrect values.

## The Solution

The `FixedConstructor.cs` file illustrates how to rectify this issue.  The key is to ensure that the base class's constructor has completed before attempting to access its initialized properties within the derived class's constructor.