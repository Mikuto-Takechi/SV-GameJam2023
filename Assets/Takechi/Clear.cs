using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clear : MonoBehaviour
{
    public bool _active { get; set; } = false;
    private void OnTriggerEnter(Collider other)
    {
        if(_active)
            SceneManager.LoadScene("Clear");
    }
}
