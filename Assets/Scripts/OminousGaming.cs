using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OminousGaming : MonoBehaviour
{
    public GameObject firstPanel;
    public GameObject secondPanel;
    public GameObject thirdPanel;

    public void Part1(bool choice)
    {
        if (choice == false)
        {
            SceneManager.LoadScene("Menu");
        }
        if (choice == true)
        {
            firstPanel.SetActive(false);
            secondPanel.SetActive(true);
        }
    }
    public void Part2(bool choice)
    {
        if (choice == false)
        {
            SceneManager.LoadScene("Menu");
        }
        if (choice == true)
        {
            secondPanel.SetActive(false);
            thirdPanel.SetActive(true);
        }
    }
    public void GoOn()
    {
        SceneManager.LoadScene("Lvl Secret");
    }
}
