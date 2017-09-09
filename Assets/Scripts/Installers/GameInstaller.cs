using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller<GameInstaller> {
    [Inject]
    private Settings settings = null;

    public override void InstallBindings() {
        Debug.Log("Hello World from Zenject!");
    }

    [System.Serializable]
    public class Settings {
        //
    }
}