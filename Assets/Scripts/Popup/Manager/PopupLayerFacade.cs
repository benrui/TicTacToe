using System;
using Zenject;
using UnityEngine;
using System.Collections.Generic;

public class PopupLayerFacade : MonoBehaviour {
    private PopupLayerBase popupLayerBase;
    private Dictionary<PopupType, Transform> popupDictionary;

    public Transform SearchingPopup;


    [Inject]
    public void Construct(PopupLayerBase popupLayerBase) {
        this.popupLayerBase = popupLayerBase;
        popupDictionary = new Dictionary<PopupType, Transform>();
    }

    public void Show(PopupType type) {
        popupLayerBase.ShowOverlay();
        var popup = PresentPopup(type);
        popup.gameObject.SetActive(true);
        popup.InternalCloseDelegate = Hide;
    }

    public void Hide(PopupType type) {
        popupLayerBase.HideOverlay();
        popupDictionary[type].gameObject.SetActive(false);
    }



    private PopupBase PresentPopup(PopupType type) {
        if (popupDictionary.ContainsKey(type)) {
            return popupDictionary[type].GetComponent<PopupBase>();
        } 

        Transform popup;
        switch (type) {
            case PopupType.SearchOpponent:
                popup = Instantiate(SearchingPopup, this.transform);
                break;
            default:
                throw new Exception("Invalid Popup Type");
        }

        popupDictionary[type] = popup;
        return popup.GetComponent<PopupBase>();
    }
}
