using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerTurnState : IGameState
{
    private GameStateMachine machine;

    public PlayerTurnState(GameStateMachine machine)
    {
        this.machine = machine;
    }

    public void Enter()
    {
        Debug.Log("Entrou no PlayerTurnState");
        //SceneManager.LoadScene("MainMenu");
    }

    public void Update() { }

    public void Exit() { }
}
