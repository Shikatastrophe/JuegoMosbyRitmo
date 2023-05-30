using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerz : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Lvl Select");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void WeWillRockYou()
    {
        SceneManager.LoadScene("Lvl 1 We Will Rock You");
    }

    public void WeAre()
    {
        SceneManager.LoadScene("Lvl 2 We Are!");
    }

    public void SpiderDance()
    {
        SceneManager.LoadScene("Lvl 3 SpiderDance");
    }

    public void Radioactive()
    {
        SceneManager.LoadScene("Lvl 4 iimagine dragonzzz");
    }

    public void Crypteque()
    {
        SceneManager.LoadScene("Lvl 5 Crypteque");
    }
}
