using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using ModestTree;

public interface IGameState {
    void EnterState();
    void ExitState();
    void Update();
    void FixedUpdate();
}


public enum GameStates {
    Lobby,
    Playing,
    None
}

// TODO find a better way to initialize/change states, if there is any.
public class GameStateManager : IInitializable, ITickable, IFixedTickable {
    private GameStates currentState = GameStates.None;
    private IGameState currentStateHandler;
    private List<IGameState> states;

    [Inject]
    public void Construct(
        LobbyState lobbyState
    ) {
        states = new List<IGameState>() {
            lobbyState
        };
    }

    public void Initialize() {
        Assert.IsEqual(currentState, GameStates.None);
        Assert.IsNull(currentStateHandler);

        ChangeState(GameStates.Lobby);
    }

    public void ChangeState(GameStates state) {
        if (currentState == state) {
            return;
        }

        currentState = state;

        if (currentStateHandler != null) {
            currentStateHandler.ExitState();
            currentStateHandler = null;
        }

        currentStateHandler = states[(int) state];
        currentStateHandler.EnterState();
    }

    public void Tick() {
        currentStateHandler.Update();
    }


    public void FixedTick() {
        currentStateHandler.FixedUpdate();
    }
}
