using UnityEngine;
using UnityEngine.SceneManagement;

public static class BootstrapLoader
{
#if UNITY_EDITOR
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void LoadBootstrap()
    {
        Debug.Log("BootstrapLoader rodando !");

        if (Object.FindObjectOfType<GameBootstrap>() != null)
            return;

        Debug.Log("Carregando cena Bootstrap... !");

        SceneManager.LoadScene("Bootstrap", LoadSceneMode.Additive);
    }
#endif
}
