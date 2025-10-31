using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int currentEnergy;
    [SerializeField] private int energyTheshold = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddEnergy()
    {
        currentEnergy += 1;
    }
}
