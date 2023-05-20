
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainM : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene("Level_1");
    }
        public void Maze()
    {
        SceneManager.LoadScene("Maze-1");
    }
        public void Quit()
    {
        print("Quit");
        Application.Quit();
    }
        public void Minue()
    {
        print("Quit");
        SceneManager.LoadScene("L1");
    }
    

}   