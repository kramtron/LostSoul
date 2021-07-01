using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FullScreen : MonoBehaviour
{
    public ScreenResol sr;
    public Dropdown m_Dropdown;
    public int m_DropdownValue;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        m_DropdownValue = m_Dropdown.value;

        if (m_DropdownValue == 0)
        {
            sr.FullScreen = true;
        }
        if (m_DropdownValue == 1)
        {
            sr.FullScreen = false;
        }
    }
}