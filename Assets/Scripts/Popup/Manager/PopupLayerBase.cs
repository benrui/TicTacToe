using System;
using UnityEngine;

public class PopupLayerBase {
    private readonly Transform popuplayer;
    private readonly Transform popupOverlay;

    public PopupLayerBase (
        Transform popuplayer,
        Transform popupOverlay
    ) {
        this.popupOverlay = popupOverlay;
        this.popuplayer = popuplayer;
    }

    public void ShowOverlay() {
        popupOverlay.gameObject.SetActive(true);
    }

    public void HideOverlay() {
        popupOverlay.gameObject.SetActive(false);
    }

    public void Add(PopupType popup) {
        //
    }

    public void Remove(PopupType popup) {
        //
    }
}


