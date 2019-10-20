using Fluent;
using UnityEngine;

public class Actor3Conversation1 : FluentScript
{
    public GameObject queen;
    public GameObject servant;
    public GameObject cameraON;
    public GameObject cameraOFF;
    public override void OnStart()
    {
        servant.GetComponent<MoveTo>().target = servant.GetComponent<MoveTo>().entrance;
        cameraON.SetActive(true);
        cameraOFF.SetActive(false);
        FluentManager.Instance.activeCamera = cameraON;
    }
    public override void OnFinish() {

        GetComponentInChildren<Actor3Conversation2>().StartConversation();
    }
    public void StartConversation()
    {
        Run();
    }
    public override FluentNode Create()
    {
        return
            Yell(queen,"Что там за шум?") *
            Yell("Сюда, швейцарцы, охраняйте дверь!") *
            Yell("Что там у вас?") *
            Yell(servant,"Спасайтесь, государь!") *
            Yell(servant,"И океан, помчавшийся на отмель,") *
            Yell(servant, "Не так стремительно бросает волны,") *
            Yell(servant, "Как молодой Лаэрт с толпою буйной") *
            Yell(servant, "Отбросил вашу... вашу...") *
             Show() *
            Options
            (
            Option("стражу") *
            Hide() *
            Yell(servant, "Отбросил вашу стражу!") *
            End() *

                Option("спаржу") *
                Hide() *
            Yell(servant, "Отбросил вашу спаржу!") *
            End() *
                Option("стужу") *
                Hide() *
            Yell(servant, "Отбросил вашу стужу!") *
            End()
            );

    }

}