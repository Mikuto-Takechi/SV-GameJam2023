using UnityEngine;

/// <summary>チェックポイント</summary>
public class CheckPointController : MonoBehaviour
{
    bool _checkPointValid = true;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out OxygenManager oxygenManager) && _checkPointValid)
        {
            GameManager.instance.SaveData(oxygenManager.GetAmountOfOxygenOnCheckPoint(), transform.position);
            _checkPointValid = false;
        }
    }

    public void GetStar()
    {
        _checkPointValid = true;
    }
}
