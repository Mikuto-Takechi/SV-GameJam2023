using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnCheck : MonoBehaviour
{
    [SerializeField] GameObject _obstacle;
    [SerializeField] GameObject _returnObstacle;
    public bool _return = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        _return = true;
        Destroy(_obstacle);
        _returnObstacle.SetActive(true);
    }
}
