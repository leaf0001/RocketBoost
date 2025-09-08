using TMPro;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GhostScoreManager : MonoBehaviour
{
    public int ghostCount = 0;
    // This will change the text to "Ghosts: " and the value of ghostCount
    public TMP_Text ghostUI;
    public void increaseScore(int amount)
    {
        ghostCount++;
    }
    private void Update()
    {
        if(ghostCount == 4)
        {
            ghostUI.text = "Complete";
        }
        else
        {
            ghostUI.text = "Ghosts: " + ghostCount + "/4";
        }
    }
}
