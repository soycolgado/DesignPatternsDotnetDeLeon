using System;

namespace DesignPattern.Singleton;

public class Singleton
{
    private readonly static Singleton _instance = new Singleton();
    
    public static Singleton Instance {
        get
        {
            return _instance;
        }
    }

    private Singleton() { }

}
