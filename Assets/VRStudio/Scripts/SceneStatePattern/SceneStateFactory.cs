using System;

public static class SceneStateFactory
{
    public static ISceneState GetSceneState(string sceneName, SceneStateManager manager, object mode = null)
    {
        switch (sceneName)
        {
            case "MainMenu":
                return new MainMenuState();

            case "MedicalSimulation":
                if (mode is not IMedicalSimStrategy medicalMode)
                    throw new Exception("Invalid mode for MedicalSimulationState!");
                return new MedicalSimulationState(manager, medicalMode);
            default:
                throw new Exception($"Scene '{sceneName}' not found!");
        }
    }
}
