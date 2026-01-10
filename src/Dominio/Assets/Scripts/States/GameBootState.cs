using UnityEngine;
using UnityEngine.SceneManagement;

public class GameBootState : IGameState
{
    private GameStateMachine machine;

    public GameBootState(GameStateMachine machine)
    {
        this.machine = machine;
    }

    public void Enter()
    {
        Debug.Log("Entrou no GameBootState");
        this.machine.ChangeState(new MainMenuState(this.machine));
    }

    public void Update() { }

    public void Exit() { }
}
