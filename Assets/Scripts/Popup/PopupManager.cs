using System;
public enum PopupType {
    SearchOpponent
}

public class PopupManager : IPopupManager {
    public PopupManager() {
    }

    #region IPopupManager implementation

    public void Show(PopupType type) {
        throw new NotImplementedException();
    }

    public void Close(PopupType type) {
        throw new NotImplementedException();
    }

    #endregion
}
