using UnityEngine;
using Zenject;

public class PopupInstaller : MonoInstaller<PopupInstaller> {
    [SerializeField]
    Settings settings = null;

    public override void InstallBindings() {
        Container.Bind<PopupLayerBase>().AsSingle()
            .WithArguments(
                settings.PopupLayer,
                settings.PopupOverlay
            );
    }

    [System.Serializable]
    public class Settings {
        public Transform PopupLayer;
        public Transform PopupOverlay;
    }

}