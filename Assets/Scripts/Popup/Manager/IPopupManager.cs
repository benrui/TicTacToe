public interface IPopupManager {
    void Show(PopupType type);
    void Close(PopupType type);
    void CloseActivePopup();
}
