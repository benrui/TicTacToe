using UnityEngine;

public delegate void CloseDelegate();

public class PopupBase : MonoBehaviour, IPopup {
    public PopupType Type;

    public CloseDelegate InternalCloseDelegate{ get; set; }


    public void CloseClick() {
        InternalCloseDelegate();
    }
}