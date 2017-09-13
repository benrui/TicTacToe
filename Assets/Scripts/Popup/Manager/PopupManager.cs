using System;
using UnityEngine;


public class PopupManager : IPopupManager {
    private Settings settings;
    private PopupLayerFacade popupLayerFacade;

    public PopupManager(
        Settings settings,
        PopupLayerFacade popupLayerFacade
    ) {
        this.settings = settings;
        this.popupLayerFacade = popupLayerFacade;
    }

    #region IPopupManager implementation

    public void Show(PopupType type) {
        popupLayerFacade.Show(type);
    }

    public void Close(PopupType type) {
        popupLayerFacade.Hide(type);
    }

    #endregion



    [System.Serializable]
    public class Settings {
        //
    }
}
