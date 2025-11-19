using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; // Singleton — tylko jeden GameManager w grze

    public float playerEnergy = 100f;

    public bool isDrunkCamera = true;

    public Slider progressBar;

    private void Awake()
    {
        // Utrzymanie jednego GameManagera miêdzy scenami
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        if (isDrunkCamera)
        {

        playerEnergy -= Time.deltaTime * 1.5f; // zu¿ycie energii z czasem
        progressBar.value = playerEnergy;
        }
    }
}
