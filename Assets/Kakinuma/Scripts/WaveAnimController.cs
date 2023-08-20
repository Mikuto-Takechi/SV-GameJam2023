using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveAnimController : MonoBehaviour
{
    [Tooltip("波状に動くオブジェクト(親オブジェクト)")]
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
