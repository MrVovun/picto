using Fluent;
using UnityEngine;

public class Actor2Outro : FluentScript
{
    public GameObject horace;
    public GameObject king;
    public GameObject horaceNewPoint;
    public GameObject opheliaNewPoint;
    public override void OnStart() {; }
    public override void OnFinish() { king.GetComponentInChildren<Actor3Conversation1>().StartConversation();
        GetComponentInParent<MoveTo>().myPosition = opheliaNewPoint;
        horace.GetComponent<MoveTo>().myPosition = horaceNewPoint;
        GetComponentInParent<MoveTo>().target = GetComponentInParent<MoveTo>().myPosition;
        horace.GetComponent<MoveTo>().target = horace.GetComponent<MoveTo>().myPosition;
    }
    public void StartConversation()
    {
        Run();
    }
    public override FluentNode Create()
    {
        return
            Yell("Терпенья надо, терпенья.") *
            Yell("А все-таки не могу не плакать, как подумаю,") *
            Yell("что они уже закопали его в сырую землю!") *
            Yell("Покойной, покойной ночи!") *
            Yell(king, "Ступайте за нею следом;")
            ;

    }

}