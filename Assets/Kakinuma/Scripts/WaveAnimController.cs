using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveAnimController : MonoBehaviour
{
    [Tooltip("�g��ɓ����I�u�W�F�N�g(�e�I�u�W�F�N�g)")]
    [SerializeField] GameObject _waveObstacle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnAnimationEnd()
    {
        Instantiate(_waveObstacle, this.transform);
        //Destroy(gameObject);

    }
}
