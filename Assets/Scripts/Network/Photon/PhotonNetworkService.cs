using System;
using UnityEngine;

public class PhotonNetworkService : AbstractNetworkService {
    
    public PhotonNetworkService() {
        Debug.Log("connecting to server!");
    }

    protected override void connectService() {
        ChangeStatus(NetworkStatus.TryingToConnect);
        Debug.Log("trying to connect");
    }


    public override void FindOpponent() {
        if (!Status.Equals(NetworkStatus.Connected)) {
            // TODO show a popup?
            return;
        }

        Debug.Log("Finding an opponent");
    }

    public override void MakeMove() {
        if (!Status.Equals(NetworkStatus.Connected)) {
            // TODO show a popup?
            return;
        }

        Debug.Log("Move sending to opponent!");
    }
}
