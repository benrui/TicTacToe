using System;
using Zenject;

public class GameInstaller : MonoInstaller<GameInstaller> {
    [Inject] private Settings settings = null;


    public override void InstallBindings() {
        Container.BindInterfacesAndSelfTo<GameController>().AsSingle();
        Container.BindInterfacesAndSelfTo<PopupManager>().AsSingle();

        if (settings.UseRealService) {
            Container.BindInterfacesTo<PhotonNetworkService>().AsSingle();
        } else {
            Container.BindInterfacesTo<DummyPhotonService>().AsSingle();
        }

        InstallStates();
        DeclareSignals();
    }

    private void InstallStates() {
        Container.BindInterfacesAndSelfTo<GameStateManager>().AsSingle();
        Container.Bind<LobbyState>().AsSingle();
        Container.Bind<PlayingState>().AsSingle();
    }

    private void DeclareSignals() {
        Container.DeclareSignal<StartGameSignal>();
    }


    [Serializable]
    public class Settings {
        public bool UseRealService;
    }
}