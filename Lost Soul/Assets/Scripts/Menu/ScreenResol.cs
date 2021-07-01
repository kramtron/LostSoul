using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenResol : MonoBehaviour
{
    public Dropdown m_Dropdown;
    public int m_DropdownValue;
    public bool FullScreen = true;

    void Update()
    {
        m_DropdownValue = m_Dropdown.value;

        if (m_DropdownValue == 0)
        {
            Screen.SetResolution(1024, 576, FullScreen);
        }
        if (m_DropdownValue == 1)
        {
            Screen.SetResolution(1280, 720, FullScreen);
        }
        if (m_DropdownValue == 2)
        {
            Screen.SetResolution(1600, 900, FullScreen);
        }
        if (m_DropdownValue == 3)
        {
            Screen.SetResolution(1920, 1080, FullScreen);
        }
    }
}
