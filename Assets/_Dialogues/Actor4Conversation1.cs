using Fluent;
using UnityEngine;

public class Actor4Conversation1 : FluentScript
{
    public GameObject ophelia;
    public GameObject opheliaNewPoint;
    public GameObject cameraON;
    public GameObject cameraOFF;
    public override void OnStart()
    {
        cameraON.SetActive(true);
        cameraOFF.SetActive(false);
        FluentManager.Instance.activeCamera = cameraON;
        ophelia.GetComponentInParent<MoveTo>().myPosition = opheliaNewPoint;
        ophelia.GetComponentInParent<MoveTo>().target = ophelia.GetComponentInParent<MoveTo>().myPosition;
    }
    public override void OnFinish()
    {
        GetComponentInChildren<GeneralOutro>().StartConversation();
    }
    public void StartConversation()
    {
        Run();
    }
    public override FluentNode Create()
    {
        return
            Yell("Что там такое?") *
            Yell("О, иссуши мне мозг,") *
            Yell("Ты, зной моей горячки!") *
            Yell(ophelia,"Выносили его с непокрытым лицом...") *
            Yell(ophelia, "О горе ты, горе! О горькое горе!") *
            Yell(ophelia, "А на гроб его слезы катились ручьем...") *
            Yell(ophelia, "Прощай... эм...") *
             Show() *
            Options
            (
            Option("мой подкаблучник") *
            Hide() *
            Yell(ophelia, "Прощай, прощай, мой подкаблучник") *
            End() *

                Option("мой попутчик") *
                Hide() *
            Yell(ophelia, "Прощай, прощай, мой попутчик") *
            End() *
                Option("мой голубчик!") *
                Hide() *
            Yell(ophelia, "Прощай, прощай, мой голубчик") *
            End()
            );

    }

}