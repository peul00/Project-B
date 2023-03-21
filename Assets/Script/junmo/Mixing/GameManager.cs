using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject cus;

    private void Awake()
    {
        instance = this;
    }
    public GameObject obj;

    public void NextDay()
    {
        SceneManager.LoadScene("Total");
        DontDestroyOnLoad(obj);
    }

    public void Custom()
    {
        cus.SetActive(true);
    }
}
