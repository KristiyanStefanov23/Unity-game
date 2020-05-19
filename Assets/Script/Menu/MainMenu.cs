using UnityEngine.SceneManagement;
using UnityEngine;
using System.Security.Cryptography;
using UnityEditor;

public class MainMenu : MonoBehaviour
{
    public int setDificultyLvl = 2;

    public Settings settings;

    public GameObject options;
    public GameObject mainMenu;
    public GameObject difficulty;
    public GameObject difficultyOptions;

    private void Awake()
    {
        
    }

    public void Start()
    {
        settings = GameObject.Find("Settings").GetComponent<Settings>();

        options.SetActive(false);
        difficulty.SetActive(false);
        mainMenu.SetActive(true);
        difficultyOptions.SetActive(false);
        difficulty.SetActive(false);
    }

    public void StartNewGame()
    {
        SceneManager.LoadSceneAsync("Dungeon_1");
    }

    public void OpenSettings()
    {
        options.SetActive(true);
        mainMenu.SetActive(false);
        difficultyOptions.SetActive(true);
    }

    public void SetDifficulty(int levelOfDiff)
    {
        setDificultyLvl = levelOfDiff;
        Start();
    }

    public void Difficulty()
    {
        difficultyOptions.SetActive(false);
        difficulty.SetActive(true);
        options.SetActive(false);
    }

    public void Back()
    {
        Start();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}