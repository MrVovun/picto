using Fluent;
using UnityEngine;

public class Actor1Outro : FluentScript
{
    public GameObject ophelia;

    public override void OnStart() {}
    public override void OnFinish()
    {
        ophelia.GetComponentInChildren<Actor2Conversation1>().StartConversation();
    }
    public void StartConversation()
    {
        Run();
    }
    public override FluentNode Create()
    {
        return
            Yell("Да, для души моей скорбящей -") *
            Yell("И таково уж свойство преступленья -") *
            Yell("Безделка всякая грозит несчастьем;");

    }

}