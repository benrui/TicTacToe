using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller<GameInstaller> {
    [Inject]
    private Settings settings = null;

    public override void InstallBindings() {
        
        Container.BindInterfacesAndSelfTo<GameController>().AsSingle();
        Container.BindInterfacesTo<PopupManager>().AsSingle();

        #if UNITY_EDITOR
        Container.BindInterfacesTo<DummyPhotonService>().AsSingle();
        #elif
        Container.BindInterfacesTo<PhotonNetworkService>().AsSingle();
        #endif
     
        InstallStates();

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