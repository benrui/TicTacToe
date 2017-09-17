using System;
using UnityEngine;
using Zenject;

public class PhotonNetworkService : AbstractNetworkService, IInitializable {
    
    public PhotonNetworkService() {
        Debug.Log("it will connect to server!");
    }

    public void Initialize() {
        connectService();
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
