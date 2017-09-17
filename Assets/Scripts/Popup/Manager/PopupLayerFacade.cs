using System;
using Zenject;
using UnityEngine;
using System.Collections.Generic;

public class PopupLayerFacade : MonoBehaviour {
    private PopupLayerBase popupLayerBase;
    private Dictionary<PopupType, PopupBase> popupDictionary;
    private PopupBase activePopup;

    public Transform SearchingPopup;


    [Inject]
    public void Construct(PopupLayerBase popupLayerBase) {
        this.popupLayerBase = popupLayerBase;
        popupDictionary = new Dictionary<PopupType, PopupBase>();
    }

    public void Show(PopupType type) {
        popupLayerBase.ShowOverlay();
        var popup = PresentPopup(type);
        popup.gameObject.SetActive(true);
        popup.InternalCloseDelegate = () => Hide(popup.Type);
        activePopup = popup;
    }

    public void Hide(PopupType type) {
        popupLayerBase.HideOverlay();
        activePopup.gameObject.SetActive(false);
    }

    public void CloseActivePopup() {
        activePopup.InternalCloseDelegate.Invoke();
    }


    private PopupBase PresentPopup(PopupType type) {
        if (popupDictionary.ContainsKey(type)) {
            return popupDictionary[type].GetComponent<PopupBase>();
        }

        Transform popup;
        switch (type) {
            case PopupType.SearchOpponent:
                popup = Instantiate(SearchingPopup, transform);
                break;
            default:
                throw new Exception("Invalid Popup Type");
        }

        var popupBase = popup.GetComponent<PopupBase>();
        popupDictionary[type] = popupBase;
        return popupBase;
    }
}