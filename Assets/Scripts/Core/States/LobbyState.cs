using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyState : IGameState {
    private readonly GameStateManager stateManager;

    public LobbyState(
        GameStateManager stateManager
    ) {
        this.stateManager = stateManager;
    }

    public void EnterState() {
        Debug.Log("Player waiting in the lobby!");
    }

    public void ExitState() {
        //
    }

    public void Update() {
        // 
    }

    public void FixedUpdate() {
        /*throw new System.NotImplementedException();*/
    }
}
