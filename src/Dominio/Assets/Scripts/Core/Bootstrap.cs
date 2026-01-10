using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    public static Bootstrap Instance { get; private set; }
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
        StateMachine.ChangeState(new GameBootState(StateMachine));
    }

    private void Update()
    {
        StateMachine.Update();
    }
}
