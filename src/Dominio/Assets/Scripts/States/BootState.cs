using UnityEngine;
using UnityEngine.SceneManagement;

public class BootState : IGameState
{
    private GameStateMachine machine;

    public BootState(GameStateMachine machine)
    {
        this.machine = machine;
    }

    public void Enter()
    {
        Debug.Log("Entrou no BootState");
        this.machine.ChangeState(new MainMenuState(this.machine));
    }

    public void Update() { }

    public void Exit() { }
}
