using System;
using UnityEngine;

public class PlayingState : IGameState {
    public void EnterState() {
        Debug.Log("prepare game ui");
    }

    public void ExitState() {
        Debug.Log("dispose game ui or hide");
    }

    public void Update() {
        //
    }

    public void FixedUpdate() {
        //
    }

    [Serializable]
    public class Settings {
        //public GameGrid gameGrid;
    }
}