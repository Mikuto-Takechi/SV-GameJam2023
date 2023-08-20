using UnityEngine;

/// <summary>�`�F�b�N�|�C���g</summary>
public class CheckPointController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out OxygenManager oxygenManager))
        {
            GameManager.instance.SaveData(oxygenManager.GetAmountOfOxygenOnCheckPoint(), transform.position);
            Destroy(this);
        }
    }
}
