using Fluent;
using UnityEngine;

public class Actor1Intro : FluentScript
{
    public GameObject horace;
    public GameObject cameraON;
    public GameObject cameraOFF;

    public override void OnStart() { horace.GetComponent<MoveTo>().target = horace.GetComponent<MoveTo>().entrance; }
    public override void OnFinish() {
        cameraON.SetActive(true);
        cameraOFF.SetActive(false);
        FluentManager.Instance.activeCamera = cameraON;
        GetComponent<Actor1Conversation2>().StartConversation();  }
    public void StartConversation()
    {
        Run();
    }
    public override FluentNode Create()
    {
        return
            Yell("Приветствую зрителей теарта!") *
            Yell("Сегодня мы представляем вам старую историю...") *
            Yell("...и демонстрируем её в новом формате!") *
            Yell("Надеюсь вам понравится эта постановка.") *
            Yell("Не будем же задерживаться.") *
            Yell("И пусть начнется театр!");

    }

}