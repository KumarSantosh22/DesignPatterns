namespace DesignPattern.Adapter
{
    public interface ITranslater
    {
        string Translate(string word);
    }
}

/*
 * The Adapter Design Pattern is a structural pattern that
 * allows objects with incompatible interfaces to work together. 
 * It acts as a bridge between two incompatible interfaces.
 * This pattern is useful when you want to use existing classes,
 * but their interfaces do not match the one you need.
 * 
 * Adapter Design Pattern Real-Time Example in C# – Language Translator
 */