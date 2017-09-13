using System;
using Zenject;
using UnityEngine;

public delegate void CloseDelegate(PopupType type);

public class PopupBase : MonoBehaviour, IPopup {
    public PopupType Type;

    public CloseDelegate InternalCloseDelegate{ get; set; }


    public void CloseClick() {
        InternalCloseDelegate(this.Type);
    }
}