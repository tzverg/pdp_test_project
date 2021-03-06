
using System;

class ExampleClassA : ICloneable
{
    public string PropertyName { get; set; }
    public string PropertyAge { get; set; }

    public ExampleClassB classB;

    public ExampleClassA()
    {
        classB = new ExampleClassB();
    }

    public object Clone() 
    {
        ExampleClassA clonedObject = new ExampleClassA() { PropertyName = this.PropertyName, PropertyAge = this.PropertyAge };
        classB = new ExampleClassB() { stringValue = "new class B" };
        return clonedObject;
    }
    public void TestFunctionA()
    { 

    }

    private bool TestFunctionB()
    {
        return true;
    }
}