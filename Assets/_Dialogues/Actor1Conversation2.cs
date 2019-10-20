using Fluent;
using UnityEngine;

public class Actor1Conversation2 : FluentScript
{
    public GameObject horace;
    public GameObject queenNewPosition;
    public GameObject horaceNewPosition;
    public GameObject ophelia;

    public override void OnStart()
    {
        GetComponentInParent<MoveTo>().myPosition = queenNewPosition;
        GetComponentInParent<MoveTo>().target = GetComponentInParent<MoveTo>().myPosition;  }
    public override void OnFinish() { ophelia.GetComponent<MoveTo>().target = ophelia.GetComponent<MoveTo>().entrance;
        horace.GetComponent<MoveTo>().myPosition = horaceNewPosition;
        horace.GetComponent<MoveTo>().target = horace.GetComponent<MoveTo>().myPosition;
        GetComponent<Actor1Outro>().StartConversation();
    }
    public void StartConversation()
    {
        Run();
    }
    public override FluentNode Create()
    {
        return
            Yell("Я не хочу с ней говорить.") *
            Yell(horace, "Она об этом просит неотступно,") *
            Yell(horace, "Хоть и не в полном разуме. Нельзя") *
            Yell(horace, "Ее не пожалеть.") *
            Yell("Что делает она?") *
            Yell(horace, "Толкует об отце. Да говорит,") *
            Yell(horace, "Что где-то слышала, что свет коварен,") *
            Yell(horace, "К себе кого-то кличет, ударяет") *
            Yell(horace, "Себя... эм...") *
            Show() *
            Options
            (
                Option("Себя ложкою по ноге") *
                Hide() *
            Yell(horace, "Себя ложкою по ноге") *
            Yell("Приведите ее сюда.") *
            End() *

                Option("Себя рукою в грудь") *
                Hide() *
            Yell(horace, "Себя рукою в грудь") *
            Yell("Приведите ее сюда.") *
            End() *
                Option("Себя... себя...") *
                Hide() *
            Yell(horace, "Себя... себя...") *
            Yell("Приведите ее сюда.") *
            End()
            );

    }

}