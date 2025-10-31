using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int currentEnergy;
    [SerializeField] private int energyTheshold = 3;
    [SerializeField] private GameObject boss;
    [SerializeField] private GameObject enemySpaner;
    private bool bossCalled = false;
    [SerializeField] private AudioManager audioManager;
    
    void Start()
    {
        boss.SetActive(false);
        audioManager.StopAudioGame();
    }

    
    void Update()
    {
        
    }

    public void AddEnergy()
    {
        if (bossCalled)
        {
            return;
        }
        currentEnergy += 1;
        if (currentEnergy == energyTheshold)
        {
            CallBoss();
        }
    }

    private void CallBoss()
    {
        bossCalled = true;
        boss.SetActive(true);
        enemySpaner.SetActive(false);
        audioManager.PlayBossAudio();
    }

    public void StartGame()
    {
        audioManager.PlayDefautAudio();
    }
}
