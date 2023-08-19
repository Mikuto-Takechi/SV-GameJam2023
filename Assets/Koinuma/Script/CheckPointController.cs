using UnityEngine;

public class CheckPointController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out OxygenManager oxygenManager))
        {
            GameManager.instance.CheckPoint(oxygenManager.GetAmountOfOxygenOnCheckPoint(), transform.position);
        }
    }
}
