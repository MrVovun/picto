using Fluent;
using UnityEngine;

public class Actor2Conversation1 : FluentScript
{
    public GameObject queen;
    public GameObject king;
    public GameObject cameraON;
    public GameObject cameraOFF;
    public override void OnStart()
    {
        cameraON.SetActive(true);
        cameraOFF.SetActive(false);
        FluentManager.Instance.activeCamera = cameraON;
    }
    public override void OnFinish() { king.GetComponent<MoveTo>().target = king.GetComponent<MoveTo>().entrance;
        GetComponentInChildren<Actor2Conversation2>().StartConversation();
    }
    public void StartConversation()
    {
        Run();
    }
    public override FluentNode Create()
    {
        return
            Yell("Где же она, ") *
            Yell("эта прекрасная королева Дании?") *
            Yell(queen,"Что с тобой, Офелия?") *
            Yell("Как бы мне теперь узнать") *
            Yell("Кто ваш друг любимый!") *
            Yell("С длинным посохом в руках,") *
            Yell("В... в...") *
            Show() *
            Options
            (
                Option("В шляпе пилигрима") *
                Hide() *
            Yell("В шляпе пилигрима?") *
            End() *

                Option("В федоре мага") *
                Hide() *
            Yell("В федоре мага?") *
            End() *
                Option("В... в...") *
                Hide() *
            Yell("В... в...?") *
            End()
            );

    }

}