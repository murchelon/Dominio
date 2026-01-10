using UnityEngine;
using UnityEngine.SceneManagement;

public static class BootstrapLoader
{
#if UNITY_EDITOR
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void LoadBootstrap()
    {
        Debug.Log("BootstrapLoader rodando !");

        if (Object.FindFirstObjectByType<Bootstrap>() != null)
            return;

        SceneManager.LoadScene("Bootstrap", LoadSceneMode.Additive);
    }
#endif
}
