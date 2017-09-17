using System;

public class PopupManager : IPopupManager {
    private readonly PopupLayerFacade popupLayerFacade;

    public PopupManager(
        PopupLayerFacade popupLayerFacade
    ) {
        this.popupLayerFacade = popupLayerFacade;
    }

    #region IPopupManager implementation

    public void Show(PopupType type) {
        popupLayerFacade.Show(type);
    }

    public void Close(PopupType type) {
        popupLayerFacade.Hide(type);
    }

    public void CloseActivePopup() {
        popupLayerFacade.CloseActivePopup();
    }

    #endregion
}
