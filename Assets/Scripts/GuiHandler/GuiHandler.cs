using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GuiHandler : MonoBehaviour {
    private GameStateManager stateManager;

    [Inject]
    public void Construct(GameStateManager stateManager)
    {
        this.stateManager = stateManager;
    }

    public void StartNewGame() {
        stateManager.ChangeState(GameStates.Playing);
    }
}
