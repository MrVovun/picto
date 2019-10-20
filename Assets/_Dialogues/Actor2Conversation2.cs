using Fluent;
using UnityEngine;

public class Actor2Conversation2 : FluentScript
{
    public GameObject queen;
    public GameObject king;
    public override void OnStart() {; }
    public override void OnFinish() { GetComponentInChildren<Actor2Outro>().StartConversation(); }
    public void StartConversation()
    {
        Run();
    }
    public override FluentNode Create()
    {
        return
            Yell(queen, "Ну, полно же, Офелия!") *
            Yell("Да нет же, вы только послушайте!") *
            Yell("Его саван - бел как снег...") *
            Yell(queen, "О, государь! Взгляните на нее!") *
            Yell("...Весь покрыт цветами") *
            Yell("Орошала их любовь") *
            Yell("Горькими слезами!") *
            Yell(king, "Как ваше здоровье, милая Офелия?") *
            Yell("Хорошо, воздай вам Господь!") *
            Yell("Ведь вот сказывают же, что сова") *
            Yell("была когда-то дочерью булочника.") *
            Yell("О Господи! Все-то мы знаем,") *
            Yell("что мы такое, но не знаем,") *
            Yell("чем можем сделаться. Так пускай же") *
            Yell("Господь благословит и вашу пищу.") *
            Yell(king, "Давно ли она в таком положении?") *
            Yell("Надеюсь... надеюсь...") *
             Show() *
            Options
            (
            Option("Надеюсь... надеюсь...") *
            Hide() *
            Yell("Надеюсь... надеюсь...") *
            End() *

                Option("Надеюсь на вашу помощь") *
                Hide() *
            Yell("Надеюсь на вашу помощь") *
            End() *
                Option("Надеюсь, что все обойдется к лучшему") *
                Hide() *
            Yell("Надеюсь, что все обойдется к лучшему") *
            End()
            );

    }

}