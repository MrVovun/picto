using Fluent;
using UnityEngine;

public class Actor3Conversation2 : FluentScript
{
    public GameObject laert;
    public GameObject queen;
    public GameObject queenNewPoint;

    public override void OnStart()
    {

        laert.GetComponent<MoveTo>().target = laert.GetComponent<MoveTo>().entrance;
    }
    public override void OnFinish()
    {
        laert.GetComponentInChildren<Actor4Conversation1>().StartConversation();
    }
    public void StartConversation()
    {
        Run();
    }
    public override FluentNode Create()
    {
        return
            Yell("Сломали двери!") *
            Yell(laert,"Где же он? Где этот король?") *
            Yell(laert, "Где мой отец?") *
            Yell("Он мертв.") *
            Yell(laert, "Отчего он умер?") *
            Yell(laert, "Себя ведь я дурачить не позволю:") *
            Yell(laert, "И провались оно, верноподданство!") *
            Yell(laert, "Присяга - к черту! ") *
            Yell(laert, "И будь со мной что будет - не оставлю") *
            Yell(laert, "Я смерть отца без полного отмщенья!") *
            Yell("А в ком твоя опора?") *
            Yell(laert, "В... в...") *
             Show() *
            Options
            (
            Option("в силе воли") *
            Hide() *
            Yell(laert, "В силе воли!") *
            Yell(laert, "И более ни в чем.") *
            End() *

                Option("в морской соли") *
                Hide() *
            Yell(laert, "В морской соли!") *
            Yell(laert, "И более ни в чем.") *
            End() *
                Option("в ночной моли!") *
                Hide() *
            Yell(laert, "В ночной моли!") *
            Yell(laert, "И более ни в чем.") *
            End()
            );

    }

}