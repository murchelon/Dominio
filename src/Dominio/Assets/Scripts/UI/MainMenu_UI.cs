using UnityEngine;


public class MainMenuUI : MonoBehaviour
{
    public void OnStartGameClicked()
    {
        Debug.Log("Start Game clicado");

        Bootstrap.Instance.StateMachine
            .ChangeState(new GamePlayState(
                Bootstrap.Instance.StateMachine
            ));

    }
}
