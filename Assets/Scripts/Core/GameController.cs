using     Zenject;

public class GameController : IInitializable {
    private readonly StartGameSignal startGameSignal;
    private readonly IPopupManager popupManager;
    private readonly GameStateManager gameStateManager;

    public GameController(
        StartGameSignal startGameSignal,
        IPopupManager popupManager,
        GameStateManager gameStateManager
    ) {
        this.startGameSignal = startGameSignal;
        this.popupManager = popupManager;
        this.gameStateManager = gameStateManager;
    }

    public void Initialize() {
        startGameSignal.Listen(OnStartGameSignalFired);
    }

    private void OnStartGameSignalFired(Opponent obj) {
        gameStateManager.ChangeState(GameStates.Playing);
        popupManager.CloseActivePopup();
    }

}