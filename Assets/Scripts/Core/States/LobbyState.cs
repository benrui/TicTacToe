using System;
using UnityEngine;

public class LobbyState : IGameState {
    private readonly GameStateManager stateManager;
    private readonly Settings settings;

    public LobbyState(
        GameStateManager stateManager,
        Settings settings
    ) {
        this.stateManager = stateManager;
        this.settings = settings;
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
    
    [Serializable]
    public class Settings {
        public GameObject Lobby;
    }
}