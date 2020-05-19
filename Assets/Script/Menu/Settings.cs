using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    takeDamage setMaxHealthEnemy;
    MainMenu mainMenuSettings;
    static public int difficultyEnemy = 2;


    void Start()
    {
        mainMenuSettings = GameObject.FindGameObjectWithTag("MainMenu").GetComponent<MainMenu>();
        DontDestroyOnLoad(this);
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "Dungeon_1")
        {
            setMaxHealthEnemy = GameObject.FindGameObjectWithTag("Enemy").GetComponent<takeDamage>();
            ApplySettings();
        }
    }

    public void ApplySettings()
    {
        difficultyEnemy = mainMenuSettings.setDificultyLvl;
        setMaxHealthEnemy.SetMaxHealthEnemy(difficultyEnemy * 200);
    }
}
