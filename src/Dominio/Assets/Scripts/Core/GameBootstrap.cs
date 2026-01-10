using UnityEngine;

public class GameBootstrap : MonoBehaviour
{
    public static GameBootstrap Instance { get; private set; }
    public GameStateMachine StateMachine { get; private set; }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        StateMachine = new GameStateMachine();

        Debug.Log("GameStateMachine criado");
    }

    private void Start()
    {
        StateMachine.ChangeState(new BootState(StateMachine));
    }

    private void Update()
    {
        StateMachine.Update();
    }
}
