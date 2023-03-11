using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    private int selectedLevel;
    private int exerciseTimer;
    private int restTimer;
    private int setNo;
    private string[] exerciseList;

    public TMP_Text exerciseLabel;
    public TMP_Text currentLevel;

    void Start()
    {
        selectedLevel = LevelSelectDisplay.selectedLevel;
        exerciseTimer = LevelSelectDisplay.exerciseTimer;
        restTimer = LevelSelectDisplay.restTimer;
        setNo = LevelSelectDisplay.setNo;
        exerciseList = LevelSelectDisplay.exerciseList;
       
        exerciseLabel.text = exerciseList[0];
        currentLevel.text = "Level " + selectedLevel;
        Debug.Log("First exercise = " + exerciseLabel.text.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
