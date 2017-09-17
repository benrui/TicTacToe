using System;
using Zenject;

//[CreateAssetMenu(fileName = "GameSettingsInstaller", menuName = "Installers/GameSettingsInstaller")]
public class GameSettingsInstaller : ScriptableObjectInstaller<GameSettingsInstaller> {
    public GameInstaller.Settings GameInstaller;

    public GameStateSettings GameState;

    [Serializable]
    public class GameStateSettings {
        public LobbyState.Settings LobbyStateSettings;
        public PlayingState.Settings PlayingStateSettings;
    }

    public override void InstallBindings() {
        Container.BindInstance(GameInstaller);

        Container.BindInstance(GameState.LobbyStateSettings);
        Container.BindInstance(GameState.PlayingStateSettings);
    }
}