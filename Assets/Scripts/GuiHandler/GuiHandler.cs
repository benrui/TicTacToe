using UnityEngine;
using Zenject;

public class GuiHandler : MonoBehaviour {
    public GameObject Lobby;
    public GameObject GameGrid;
    
    private GameStateManager stateManager;
    private IPopupManager popupManager;
    private INetworkService networkService;

    [Inject]
    public void Construct(
        GameStateManager stateManager,
        IPopupManager popupManager,
        INetworkService networkService,
        StartGameSignal startGameSignal
    )
    {
        this.stateManager = stateManager;
        this.popupManager = popupManager;
        this.networkService = networkService;
        startGameSignal += OnStartGame;
    }

    private void OnStartGame(Opponent obj) {
        Lobby.SetActive(false);
        GameGrid.SetActive(true);
    }

    public void StartNewGame() {
        Debug.Log("Trying to find new opponent");
        popupManager.Show(PopupType.SearchOpponent);
        networkService.FindOpponent();
    }
}
