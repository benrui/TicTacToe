using System;
using UnityEngine;

public class DummyPhotonService : PhotonNetworkService {
    public override void FindOpponent() {
        Debug.Log("Dummy Service override ");
    }

    public override void MakeMove() {
        Debug.Log("makeMove dummy service override");
    }
}
