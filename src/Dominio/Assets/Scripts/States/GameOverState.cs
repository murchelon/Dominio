using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverState : IGameState
{
    private GameStateMachine machine;

    public GameOverState(GameStateMachine machine)
    {
        this.machine = machine;
    }

    public void Enter()
    {
        //SceneManager.LoadScene("MainMenu");
        Debug.Log("Entrou no GameOverState");
    }

    public void Update() { }

    public void Exit() { }
}
