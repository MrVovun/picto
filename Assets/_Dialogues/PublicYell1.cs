using Fluent;

public class PublicYell1 : FluentScript
{
    public override FluentNode Create()
    {
        return Yell("Надеюсь, что шоу скоро начнется!");
    }
}