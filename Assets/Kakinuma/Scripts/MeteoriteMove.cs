using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoriteMove : MonoBehaviour
{
    //[SerializeField] GameObject _meteorite;
    [SerializeField] float _meteoriteSpeed = 1f;
    Rigidbody _meteoriteRigidbody;
    Vector3 _direction = new Vector3(1, 0, 0);
    public ReturnCheck returnCheck;
    // Start is called before the first frame update
    void Start()
    {
        _meteoriteRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!returnCheck._return)
        {
            Vector3 _meteoriteVelo = _direction * _meteoriteSpeed;
            _meteoriteRigidbody.velocity = _meteoriteVelo;
        }
        else
        {
            Vector3 _meteoriteVelo = -_direction * _meteoriteSpeed;
            _meteoriteRigidbody.velocity = _meteoriteVelo;
        }
    }
}
