using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelSelectDisplay : MonoBehaviour
{

    public Level level;
    public TMP_Text levelNo;

    // Start is called before the first frame update
    void Start()
    {
        levelNo.text = level.levelNumber.ToString();
    }

    public void Test()
    {
        Debug.Log("Level = " + level.levelNumber);
    }

}
