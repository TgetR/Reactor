using TMPro;
using UnityEngine;

public class InteractivePanel : MonoBehaviour
{
    public TMP_Text text;
    public void ActivateAllRods()
    {
        text.text = "-All rods activated \n" + text.text;
        GameObject[] rodsTemp = GameObject.FindGameObjectsWithTag("Rod");
        for(int i = 0; i < rodsTemp.Length; i++)
        {
            rodsTemp[i].GetComponent<RodCon>().Active = true;
        }
    }
    public void DeactivateAllRods()
    {
        text.text = "-All rods deactivated \n" + text.text;
        GameObject[] rodsTemp = GameObject.FindGameObjectsWithTag("Rod");
        for(int i = 0; i < rodsTemp.Length; i++)
        {
            rodsTemp[i].GetComponent<RodCon>().Active = false;
        }
    }
}
