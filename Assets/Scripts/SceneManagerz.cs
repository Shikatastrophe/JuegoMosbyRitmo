using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerz : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            SceneManager.LoadScene("Lvl Select");
        }
    }
    public void Play()
    {
        SceneManager.LoadScene("Lvl Select");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void WeWillRockYou()
    {
        SceneManager.LoadScene("Lvl 1 We Will Rock You 1");
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

    public void ReaverKing()
    {
        SceneManager.LoadScene("Lvl 6 The Reaver King");
    }

    public void MightBePainful()
    {
        SceneManager.LoadScene("Lvl 7 It Might be painful");
    }

    public void BIB()
    {
        SceneManager.LoadScene("Lvl 8 Back in Black");
    }

    public void PINK()
    {
        SceneManager.LoadScene("Lvl9 PINK");
    }

    public void Humanlike()
    {
        SceneManager.LoadScene("Lvl10 HUMANLIKE");
    }
    public void Ominous()
    {
        SceneManager.LoadScene("Escena ominosa");
    }
    public void toho()
    {
        SceneManager.LoadScene("Lvl 11 Nights of Nights");
    }

    public void ajaja()
    {
        SceneManager.LoadScene("Creditos");
    }
    public void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
