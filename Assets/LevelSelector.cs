using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{
    [SerializeField] private int levelNumber;

    public void DisplayLevelNumber(Level level)
    {
        levelNumber = level.levelNumber;
    }

    public void Test()
    {
        Debug.Log("Level = " + levelNumber);
    }
}
