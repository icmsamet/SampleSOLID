using UnityEngine;
using TMPro;
namespace GameManager
{
    public class GameManagers : MonoBehaviour
    {
        public static GameManagers instance { get; private set; }
        [Header("UI Components")]
        [SerializeField] GameObject m_startPanel;
        [SerializeField] GameObject m_gamePanel;
        [SerializeField] GameObject m_pausePanel;
        [SerializeField] GameObject m_failPanel;
        [SerializeField] TextMeshProUGUI m_pointText;
        [SerializeField] TextMeshProUGUI m_failPanelPointText;
        [SerializeField] TextMeshProUGUI m_failPanelBestPointText;
        [Header("-----")]
        public bool isPlaying = false;
        public int point = 0;
        [SerializeField] GameObject m_Platform;
        [SerializeField] Player.Player m_Player;
        [SerializeField] Pipe.PipeSpawner m_pipeSpawner;
        public GameManagerEnviroment gameManagerEnviroment;
        public GameManagerPlayer gameManagerPlayer;
        public GameManagerUI gameManagerUI;
        public GameManagerScene gameManagerScene;
        public GameManagerPipe gameManagerPipe;
        public GameManagerBestScore gameManagerBestScore;

        private void Awake()
        {
            if (instance == null)
                instance = this;
        }
        private void Start()
        {
            gameManagerEnviroment = new GameManagerEnviroment(m_Platform);
            gameManagerPlayer = new GameManagerPlayer(m_Player.playerAnimation, m_Player.playerMovement);
            gameManagerUI = new GameManagerUI(m_startPanel, m_gamePanel, m_failPanel
                ,m_pointText, m_failPanelPointText, m_failPanelBestPointText);
            gameManagerScene = new GameManagerScene();
            gameManagerPipe = new GameManagerPipe(m_pipeSpawner);
            gameManagerBestScore = new GameManagerBestScore();
            gameManagerUI.StartPanelState(true);
        }
        public void StartGame()
        {
            isPlaying = true;
            gameManagerEnviroment.StartPlatformMove();
            gameManagerPlayer.StartGame();
            gameManagerUI.StartGamePanels();
            gameManagerPipe.StartGame();
        }
        public void FailGame()
        {
            isPlaying = false;
            gameManagerEnviroment.StopPlatformMove();
            gameManagerPlayer.StopGame();
            gameManagerUI.FailGamePanels();
            gameManagerUI.FailPanelPoint(point);
            int bestPoint = gameManagerBestScore.BestScore(point);
            gameManagerUI.FailPanelBestPoint(bestPoint);
        }
        public void RestartGame()
        {
            gameManagerScene.RestartGame();
        }
    }
}
