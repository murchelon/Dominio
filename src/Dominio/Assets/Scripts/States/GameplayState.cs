using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlayState : IGameState
{
    private GameStateMachine machine;

    public GamePlayState(GameStateMachine machine)
    {
        this.machine = machine;
    }

    public void Enter()
    {
        Debug.Log("Entrou no GamePlayState");
        SceneManager.LoadScene("GamePlayScene");
    }

    public void Update() { }

    public void Exit() { }
}
