using System;

public interface INetworkService {
    NetworkStatus Status{ get; }
    void FindOpponent();
    void MakeMove();
}
