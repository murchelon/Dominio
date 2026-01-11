using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuState : IGameState
{
    private GameStateMachine machine;

    public MainMenuState(GameStateMachine machine)
    {
        this.machine = machine;
    }

    public void Enter()
    {
        Debug.Log("Entrou no MainMenuState");
        //SceneManager.LoadScene("MainMenuScene");
        this.machine.ChangeState(new GamePlayState(this.machine));
    }

    public void Update() { }

    public void Exit() { }
}
