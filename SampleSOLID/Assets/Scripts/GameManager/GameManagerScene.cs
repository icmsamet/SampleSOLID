using UnityEngine.SceneManagement;
using UnityEngine;


namespace GameManager
{
    public class GameManagerScene
    {
        public void RestartGame()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}

