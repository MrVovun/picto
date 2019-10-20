using Fluent;
using UnityEngine;

public class GeneralOutro : FluentScript
{
    public GameObject ophelia;
    public GameObject king;
    public GameObject cameraON;
    public GameObject cameraOFF;

    public override void OnStart()
    {
        cameraON.SetActive(true);
        cameraOFF.SetActive(false);
        FluentManager.Instance.activeCamera = cameraON;
    }
    public override void OnFinish()
    {
        //выводить статистику игрока и затемнять экран
    }
    public void StartConversation()
    {
        Run();
    }
    public override FluentNode Create()
    {
        return
            Yell("А ведь и то может случится, что эта бессмыслица") *
            Yell("посодержательнее иного дела...") *
            Yell(ophelia, "И к нам он больше не придет?") *
            Yell(ophelia, "Нет, нет, его уж схоронили.") *
            Yell(ophelia, "Ступай, ищи его в могиле!") *
            Yell(ophelia, "Он никогда уж не придет ?") *
            Yell(king, "Лаэрт! Необходимо должен я") *
            Yell(king, "Поговорить с твоею скорбью, коль не хочешь") *
            Yell(king, "Несправедливо ты мое нарушить право") *
            Yell(king, "Из друзей пусть лучшие тебя сопровождают;") *
            Yell(king, "И ежели они найдут, что мы,") *
            Yell(king, "Хоть в чем-нибудь повинны - мы согласны") *
            Yell(king, "Отдать тебе в возмездье королевство,") *
            Yell(king, "Корону нашу, жизнь и все, что только") *
            Yell(king, "Но если ж не найдут нас в виноватых,") *
            Yell(king, "Тогда соедини свое терпенье с нашим,") *
            Yell(king, "И станем мы с тобой работать вместе,") *
            Yell(king, "Чтоб дать тебе, чего искать ты вправе.") *
            Yell("Да будет так.") 
            ;

    }

}