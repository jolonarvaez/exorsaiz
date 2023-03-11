using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    public int selectedLevel;
    public int exerciseTimer;
    public int restTimer;
    public int setNo;
    public string[] exerciseList;

    public TMP_Text exerciseLabel;
    public TMP_Text currentLevel;

    void Start()
    {
        int selectedLevel = LevelSelectDisplay.selectedLevel;
        int exerciseTimer = LevelSelectDisplay.exerciseTimer;
        int restTimer = LevelSelectDisplay.restTimer;
        int setNo = LevelSelectDisplay.setNo;
        string[] exerciseList = LevelSelectDisplay.exerciseList;

       
        exerciseLabel.text = exerciseList[0];
        currentLevel.text = "Level " + selectedLevel;
        Debug.Log("First exercise = " + exerciseLabel.text.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
