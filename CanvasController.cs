using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{
    public GameController gameController;
    public GameObject pausePanel;
    public Text timeText;
    public Text firstPlaceName;
    public Text firstPlaceBestTime;
    public Text secondPlaceName;
    public Text secondPlaceBestTime;
    public Text firstPlaceTime;
    public Text secondPlaceTime;
    public Text gameOver;
    public Button mainMenu;
    public Button restart;
    private bool _isPaused;
    private bool _hasGameEnded; 
    
    private void Start()
    {
        pausePanel.SetActive(false);
        gameOver.enabled = false;
        mainMenu.gameObject.SetActive(false);
        restart.gameObject.SetActive(false);
    }
    private void Update()
    {
        //O _hasGameEnded garante que o update não executará mais nenhuma instrução após o jogo ser finalizado
        if (!_hasGameEnded)
        {
            //Só começa a contar o tempo após o player iniciar a corrida
            if (gameController.playerLapStarted)
            {
                timeText.text = GetTimeString(gameController.playerTime);
            }
            // Caso o player clique "esc", o método de pause é chamado
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                OnPauseClicked();
            }            //Os textos e verificação de vencedor estarão acontecendo sempre (não é uma boa prática) 
            UpdateTextsScore();
            VerifyWinner();
        }
    }    //Método para transformar um tempo em segundos na formatação mm:ss
    private string GetTimeString(float time)
    {
        int seconds = (int)(time % 60);
        int minutes = (int)(time / 60) % 60;
        return $"{minutes:00}:{seconds:00}";
    }
    //Define os textos relativos ao primeiro lugar no canvas. 
    private void SetFirstPlaceTexts(string bestTimeText, string firstLapText, string firstPlaceText)
    {
        firstPlaceBestTime.text = bestTimeText;
        firstPlaceTime.text = firstLapText;
        firstPlaceName.text = firstPlaceText;
    }
    //Define os textos relativos ao segundo lugar no canvas. 
    private void SetSecondPlaceTexts(string bestTimeText, string firstLapText, string secondPlaceText)
    {
        secondPlaceBestTime.text = bestTimeText;
        secondPlaceTime.text = firstLapText;
        secondPlaceName.text = secondPlaceText;
    }
    //Esse método recebe como parâmetro se o player se encontra em primeiro lugar. Caso sim, ele passa as informações
    //necessárias para os métodos "SetFirstPlaceTexts" e "SetSecondPlaceTexts" fazerem as alterações necessárias
    //na UI, sendo elas mostrar os respectivos nomes, volta e melhor tempo.
    private void SetPlacementTexts(string playerBestTime, int playerLapsNumber, string enemyBestTime,
   int enemyLapsNumber, bool isPlayerFirst)
    {
        bool hasPlayerDoneALap = playerLapsNumber != 0;
        bool hasEnemyDoneALap = enemyLapsNumber != 0;
        if (isPlayerFirst)
        {
            if (hasPlayerDoneALap)
            {
                SetFirstPlaceTexts(playerBestTime, playerLapsNumber.ToString(), "Player");
            }
            if (hasEnemyDoneALap)
            {
                SetSecondPlaceTexts(enemyBestTime, enemyLapsNumber.ToString(), "Enemy");
            }
        }
        else
        {
            if (hasEnemyDoneALap)
            {
                SetFirstPlaceTexts(enemyBestTime, enemyLapsNumber.ToString(), "Enemy");
            }
            if (hasPlayerDoneALap)
            {
                SetSecondPlaceTexts(playerBestTime, playerLapsNumber.ToString(), "Player");
            }
        }
    }    //Esse método verifica quem está ganhando, garantindo que o player tenha vantagem no caso de empate.
    //Uma vez verificado quem está ganhando, ele passa essa informação ao SetPlacementTexts para que 
    // a UI seja atualizada
    private void UpdateTextsScore()
    {
        string playerBestTime = GetTimeString(gameController.bestTimePlayer);
        int playerLapsNumber = gameController.numLapPlayer;
        string enemyBestTime = GetTimeString(gameController.bestTimeEnemy);
        int enemyLapsNumber = gameController.numLapEnemy;
        bool isPlayerWinning; if (playerLapsNumber > enemyLapsNumber)
        {
            isPlayerWinning = true;
        }
        else if (playerLapsNumber < enemyLapsNumber)
        {
            isPlayerWinning = false;
        }
        else
        {
            if (gameController.numCheckPoint >= gameController.numCheckPointEnemy)
            {
                isPlayerWinning = true;
            }
            else
            {
                isPlayerWinning = false;
            }
        }
        SetPlacementTexts(playerBestTime, playerLapsNumber, enemyBestTime, enemyLapsNumber, isPlayerWinning);
    }    //Esse método verifica constantemente se algum dos corredores venceu. Caso aconteceça, ele mostra
    //o menu com a mensagem de derrota ou vitória.
    //É uma prática muito ruim fazer essa verificação acontecer no Update. O ideal seria que o GameController avisasse
    //Quem ganhou e quand ganhou
    private void VerifyWinner()
    {
        if (gameController.enemyWins)
        {
            gameOver.text = "DEFEAT";
            ShowGameOverPanel();
        }
        if (gameController.playerWins)
        {
            gameOver.text = "VICTORY";
            ShowGameOverPanel();
        }
    }    //Método que mostra o Menu de vitória, para o tempo e ainda seta o _hasGameEnded como true para o update parar de
    //chamar os métodos
    private void ShowGameOverPanel()
    {
        _hasGameEnded = true;
        gameOver.enabled = true;
        mainMenu.gameObject.SetActive(true);
        restart.gameObject.SetActive(true);
        Time.timeScale = 0;
    }    //Método a ser chamado quando o botão de pause for clicado, no caso o ESC 
    private void OnPauseClicked()
    {
        if (_isPaused)
            Unpause();
        else
            Pause();
    }    //Método para pausar o jogo
    private void Pause()
    {
        _isPaused = true;
        Time.timeScale = 0;
        pausePanel.SetActive(true);
    }    //Método para despausar o jogo. Ele também será chamado no OnClick do botão RESUME
    public void Unpause()
    {
        _isPaused = false;
        Time.timeScale = 1;
        pausePanel.SetActive(false);
    }
}