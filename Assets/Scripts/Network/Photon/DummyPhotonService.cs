using UnityEngine;

public class DummyPhotonService : PhotonNetworkService {
    private StartGameSignal startGameSignal;

    public DummyPhotonService(StartGameSignal startGameSignal) {
        this.startGameSignal = startGameSignal;
    }

    protected override void connectService() {
        ChangeStatus(NetworkStatus.Connected);
    }

    public override void FindOpponent() {
        var dummyOpponent = new Opponent("1234", "I am Dummy");
        Debug.Log("Opponnet found!");
        startGameSignal.Fire(dummyOpponent);
    }

    public override void MakeMove() {
        Debug.Log("makeMove dummy service override");
    }
}
