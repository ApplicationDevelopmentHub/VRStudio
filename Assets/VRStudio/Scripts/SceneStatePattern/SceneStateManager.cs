using UnityEngine;

public class SceneStateManager : MonoBehaviour
{
    private static SceneStateManager _instance;
    private ISceneState _currentSceneState;

    public static SceneStateManager Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject obj = new GameObject("SceneStateManager");
                _instance = obj.AddComponent<SceneStateManager>();
                DontDestroyOnLoad(obj);
            }
            return _instance;
        }
    }

    public void SwitchScene(string sceneName, object mode = null)
    {
        _currentSceneState?.ExitScene();
        _currentSceneState = SceneStateFactory.GetSceneState(sceneName, this, mode);
        _currentSceneState.EnterScene();
    }
}
