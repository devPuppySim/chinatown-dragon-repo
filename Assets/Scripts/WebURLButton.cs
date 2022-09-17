using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebURLButton : MonoBehaviour
{

    public string url = "https://www.firedragonfestival.com/about";



    public void OnButtonPressed()
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        Nfynt.NPlugin.OpenURLInSameTab(url);
#else
        Nfynt.NPlugin.OpenURL(url);
#endif
    }
}
