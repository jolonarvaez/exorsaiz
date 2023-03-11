using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PilotLogic : MonoBehaviour
{
    public Image SyncBar;
    public Image SideBarL;
    public Image SideBarR;
    public int SyncPercentage;
    

    private int selectedLevel;
    private int exerciseTimer;
    private int restTimer;
    private int setNo;
    private int currentExercise;
    private string[] exerciseList;
    private int exerciseLength;

    public TMP_Text exerciseLabel;
    public TMP_Text currentLevel;

    // Start is called before the first frame update
    void Start()
    {
        selectedLevel = LevelSelectDisplay.selectedLevel;
        exerciseTimer = LevelSelectDisplay.exerciseTimer;
        restTimer = LevelSelectDisplay.restTimer;
        setNo = LevelSelectDisplay.setNo;
        exerciseList = LevelSelectDisplay.exerciseList;
        currentLevel.text = "Level " + selectedLevel;

        exerciseLength = exerciseList.Length;
        currentExercise = 0;

        StartCoroutine(ExerciseCoroutine());
        
    }

    // Update is called once per frame
    void Update()
    {
        getSyncBar();
        getLabel();
        setBar();
    }

    IEnumerator ExerciseCoroutine()
    {
        while(currentExercise < exerciseLength)
        {
            yield return new WaitForSeconds(2f);
            currentExercise++;
            Debug.Log(exerciseList[currentExercise]);
        }
    }

    public void getSyncBar()
    {
        SyncBar.fillAmount = (float)SyncPercentage / 100;
    }

    public void setLabel()
    {

        exerciseLabel.text = exerciseList[currentExercise];
    }

    public void getLabel()
    {
        exerciseLabel.text = exerciseList[currentExercise];
    }

    public void setBar()
    {
        if (SyncPercentage >= 75)
        {
            SideBarL.color = new Color32(71, 198, 83, 255);
            SideBarR.color = new Color32(71, 198, 83, 255);
        }
        else if (SyncPercentage < 75 && SyncPercentage >= 50)
        {
            SideBarL.color = new Color32(241, 146, 66, 255);
            SideBarR.color = new Color32(241, 146, 66, 255);
        }
        else
        {
            SideBarL.color = new Color32(238, 63, 63, 255);
            SideBarR.color = new Color32(238, 63, 63, 255);
        }

    }
}
