using UnityEngine;
using UnityEngine.SceneManagement;

public class MedicalSimulationState : ISceneState
{
    private SceneStateManager _manager;
    private IMedicalSimStrategy _medicalUseCase;

    public MedicalSimulationState(SceneStateManager manager, IMedicalSimStrategy medicalUseCase)
    {
        _manager = manager;
        _medicalUseCase = medicalUseCase;
    }

    public void EnterScene()
    {
        Debug.Log("Entering Medical Simulation Scene...");
        SceneManager.LoadSceneAsync(1);
        _medicalUseCase.ApplyMode(); // Apply medical mode when entering scene
    }

    public void ExitScene()
    {
        Debug.Log("Exiting Medical Simulation Scene...");
    }
}
