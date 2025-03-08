using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuState : ISceneState
{
    public void EnterScene()
    {
        SceneManager.LoadSceneAsync(0);
    }

    public void ExitScene()
    {
        throw new System.NotImplementedException();
    }
}
