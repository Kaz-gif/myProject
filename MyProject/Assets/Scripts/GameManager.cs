using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void link1()
    {
        Application.OpenURL("https://www.google.com/D");
    }

    public void link2()
    {
        Application.OpenURL("https://www.google.com/search?q=how+to+add+hyperlinks+to+buttons+in+unity+6&sca_esv=47422b062f7ec537&ei=nNiHaf7oLu7NkPIPwuD46As&ved=0ahUKEwj-pvjH0ciSAxXuJkQIHUIwHr0Q4dUDCBE&uact=5&oq=how+to+add+hyperlinks+to+buttons+in+unity+6&gs_lp=Egxnd3Mtd2l6LXNlcnAiK2hvdyB0byBhZGQgaHlwZXJsaW5rcyB0byBidXR0b25zIGluIHVuaXR5IDYyBRAhGKABMgUQIRigATIFECEYoAEyBRAhGKABSLoHUJ4DWKMGcAF4AJABAJgB3gOgAbwFqgEHMi0xLjAuMbgBA8gBAPgBAZgCAqAC_wHCAggQABiwAxjvBZgDAIgGAZAGBJIHBTEuMC4xoAedCLIHAzItMbgH6gHCBwUyLTEuMcgHEYAIAA&sclient=gws-wiz-serp");
    }

    public void link3()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=qqOqLNqAdDo&t=99s");
    }

    public void Patreon()
    {
        Application.OpenURL("https://www.patreon.com/es-ES");
    }

    public void Gamejolt()
    {
        Application.OpenURL("https://gamejolt.com/");
    }

    public void Itch()
    {
        Application.OpenURL("https://itch.io/");
    }

    public void X()
    {
        Application.OpenURL("https://x.com/home");
    }
}
