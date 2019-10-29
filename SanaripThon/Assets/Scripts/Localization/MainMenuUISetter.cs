using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuUISetter : MonoBehaviour, IUISetter
{
    public Text GameNameText;
    public Text PlayGameText;
    public Text AboutUsText;
    public Text QuitText;
    public Text BackText;

    public void SetUI()
    {
        GameNameText.text = LocaizationsData.CulturedData[GlobalSettings.Culture]["GameName"];
    }
}
