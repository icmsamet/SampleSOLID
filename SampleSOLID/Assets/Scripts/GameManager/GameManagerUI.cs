using UnityEngine;
using TMPro;

namespace GameManager
{
    public class GameManagerUI
    {
        GameObject startPanel;
        GameObject gamePanel;
        GameObject failPanel;
        TextMeshProUGUI pointText;
        TextMeshProUGUI failPanelPointText;
        TextMeshProUGUI failPanelBestPointText;
        public GameManagerUI(GameObject _startPanel,GameObject _gamePanel,GameObject _failPanel
            ,TextMeshProUGUI _pointText,TextMeshProUGUI _failPanelPointText,TextMeshProUGUI _failPanelBestPointText)
        {
            startPanel = _startPanel;
            gamePanel = _gamePanel;
            failPanel = _failPanel;
            pointText = _pointText;
            failPanelPointText = _failPanelPointText;
            failPanelBestPointText = _failPanelBestPointText;
        }
        public void StartPanelState(bool state)
        {
            startPanel.SetActive(state);
        }
        public void GamePanelState(bool state)
        {
            gamePanel.SetActive(state);
        }
        public void FailPanelState(bool state)
        {
            failPanel.SetActive(state);
        }
        public void StartGamePanels()
        {
            startPanel.SetActive(false);
            gamePanel.SetActive(true);
            failPanel.SetActive(false);
            PointUpdate(0);
        }
        public void FailGamePanels()
        {
            startPanel.SetActive(false);
            gamePanel.SetActive(false);
            failPanel.SetActive(true);
        }
        public void PointUpdate(int point)
        {
            pointText.text = point.ToString();
        }
        public void FailPanelPoint(int point)
        {
            failPanelPointText.text = point.ToString();
        }
        public void FailPanelBestPoint(int point)
        {
            failPanelBestPointText.text = point.ToString();
        }
    }
}
