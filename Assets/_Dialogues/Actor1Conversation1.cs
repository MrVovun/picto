using Fluent;
using UnityEngine;

public class Actor1Conversation1 : FluentScript
{
    public GameObject destroyQuest;
    public override void OnStart() { GetComponentInParent<StatsHolder>().playerObject.GetComponent<PlayerController>().canMove = false;
        Destroy(destroyQuest);
    }
    public override void OnFinish() {
        GetComponentInParent<MoveTo>().target = GetComponentInParent<MoveTo>().entrance;
        GetComponentInParent<StatsHolder>().playerObject.GetComponent<MoveTo>().target = GetComponentInParent<StatsHolder>().playerObject.GetComponent<MoveTo>().myPosition;
    }
    public override FluentNode Create()
    {
        return
            Yell("Твою мать!") *
            Yell("А, это ты. Привет.") *
            Yell("У нас тут небольшой кризис.") *
            Yell("После вчерашнего праздника все актеры...") *
            Yell("...так сказать, не в лучшем состоянии.") *
            Yell("А времени приводить их в порядок совсем нет") *
            Yell("Слушай, сделай одолжение в последний раз, м?") *
            Yell("У тебя ведь осталась копия сценария.") *
            Yell("Просто стой за кулисами и подсказывай им строки") *
            Yell("Выглядеть будет ужасно, но лучше, чем пустить на самотек") *
            Yell("Я в долгу не останусь, ты меня знаешь. Ну?") *
            Show() *
            Options
            (
                Option ("Ух... ладно. Хорошо.")*
                Hide()*
            Yell("Замечательно. Не будем терять времени.") *
            Yell("Вставай за ширму и не показывайся.") *
            Yell("А я постараюсь вывести этот сброд на сцену.") *
            End()*

                Option("Нам не помешает лишний ствол!") *
                Hide() *
            Yell("Замечательно. Не будем терять времени.") *
            Yell("Вставай за ширму и не показывайся.") *
            Yell("А я постараюсь вывести этот сброд на сцену.") *
            End() 
            );
    
    }

}