using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller<GameInstaller> {
    [Inject]
    private Settings settings = null;

    public override void InstallBindings() {
        InstallController();
        InstallStates();

    }

    void InstallController() {
        Container.BindInterfacesAndSelfTo<GameController>().AsSingle();
    }

    void InstallStates() {
        Container.BindInterfacesAndSelfTo<GameStateManager>().AsSingle();
        Container.Bind<LobbyState>().AsSingle();
    }

    [System.Serializable]
    public class Settings {
        //
    }
}