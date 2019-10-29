using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Localizer : MonoBehaviour
{
    // Start is called before the first frame update
    public void SetLanguage(string culture)
    {
        GlobalSettings.Culture = culture;
    }
    
    
}
