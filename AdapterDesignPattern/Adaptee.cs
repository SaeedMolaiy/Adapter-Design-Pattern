﻿namespace AdapterDesignPattern;

internal class Adaptee
{
    public void SpecificRequest()
    {
        Console.WriteLine("Adaptee's specific request.");
    }
}