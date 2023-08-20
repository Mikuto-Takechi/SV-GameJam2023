using UnityEngine;

public class Star : MonoBehaviour
{
    [SerializeField] CheckPointController _checkPoint;
    EnemyGenerator[] _generators = null;
    private void Start()
    {
        _generators = FindObjectsOfType<EnemyGenerator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            foreach(EnemyGenerator generator in _generators)
            {
                generator.EnemyGenerate(2);
            }
            _checkPoint.GetStar();
            AudioManager.instance.PlaySE(5);
        }
    }
}
