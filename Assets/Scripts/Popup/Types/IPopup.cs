using Zenject;

public interface IPopup {
    CloseDelegate InternalCloseDelegate{ get; set; }
}
