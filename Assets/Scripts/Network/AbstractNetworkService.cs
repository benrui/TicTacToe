using System;

public enum NetworkStatus {
    TryingToConnect,
    Connected,
    Disconnected
}


public abstract class AbstractNetworkService : INetworkService {

    private NetworkStatus status = NetworkStatus.Disconnected;

    public AbstractNetworkService() {
        connectService();
    }

    protected abstract void connectService();

    #region INetworkService implementation

    public abstract void FindOpponent();

    public abstract void MakeMove();

    public NetworkStatus Status {
        get {
            return status;
        }
    }

    #endregion

    protected virtual void ChangeStatus(NetworkStatus newStatus) {
        status = newStatus;
    }
}
