using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject _playerObject;
    [SerializeField] Slider _slider;
    [SerializeField] GameObject _gameOverPanel;

    Vector3 _reSpawnPosition;
    float _amountOfOxygen;
    bool _singleSound = true;
    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

        private void Start()
    {
        _reSpawnPosition = _playerObject.transform.position;
        _amountOfOxygen = 1;
        _gameOverPanel.SetActive(false);
    }

    public void SaveData(float amountOfOxygen, Vector3 checkPoint)
    {
        _amountOfOxygen = amountOfOxygen;
        _reSpawnPosition = checkPoint;
    }

    public void Retry()
    {
        _singleSound = true;
        AudioManager.instance.PauseBGM(false);
        AudioManager.instance.PlaySE(3);
        _gameOverPanel.SetActive(false);
        _playerObject.transform.position = _reSpawnPosition;
        _slider.value = _amountOfOxygen;
    }

    public void GameOver()
    {
        if(_singleSound)
        {
            AudioManager.instance.PauseBGM(true);
            AudioManager.instance.PlaySE(12);
            _singleSound = false;
        }
        _gameOverPanel.SetActive(true);
    }
}
