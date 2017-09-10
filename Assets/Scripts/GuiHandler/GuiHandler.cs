using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GuiHandler : MonoBehaviour {
    private GameStateManager stateManager;
    private IPopupManager popupManager;
    private INetworkService networkService;

    [Inject]
    public void Construct(
        GameStateManager stateManager,
        IPopupManager popupManager,
        INetworkService networkService
    )
    {
        this.stateManager = stateManager;
        this.popupManager = popupManager;
        this.networkService = networkService;
    }

    public void StartNewGame() {
        Debug.Log("Trying to find new opponent");
        popupManager.Show(PopupType.SearchOpponent);
        networkService.FindOpponent();
    }
}
