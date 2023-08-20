using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoriteMoveWave : MonoBehaviour
{
    //[SerializeField] float _meteoriteSpeed = 1f;
    //Rigidbody _meteoriteRigidbody;
    //Vector3 _direction = new Vector3(1, 0, 0);

    //public float theta = 0;
    //public float z = 0;
    //public float x = 0;
    //public float y = 0;
    //public float r = 3;
    // Start is called before the first frame update
    //float a = 1.0f;
    //float b = 3.0f;
    //float x;
    float y;
    void Start()
    {
        //_meteoriteRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //x = Mathf.Sin(a * Time.time);
        //y = Mathf.Cos(b * Time.time);
        //transform.position = new Vector3(x * 0.02f + transform.position.x, y * 0.01f + transform.position.y, transform.position.z);
        //if (x < 0)
        //{
        //    transform.position = new Vector3(x * 0.02f + transform.position.x, y * 0.01f + transform.position.y, transform.position.z);
        //}


        y += 0.1f * Time.deltaTime; // ècÇ…ìÆÇ©Ç∑ó Ç0.1Ç∏Ç¬ãAÇÈ

        if (y >= 0.1f)
        {
            y *= -1f;
        }

        transform.position += new Vector3(0.01f, y * 0.5f, 0); // ëOï˚Ç…êiÇ›Ç»Ç™ÇÁècÇ…yÇÃï™ÇæÇØìÆÇ©Ç∑


        ////x = r * Mathf.Cos(theta);
        //y = r * Mathf.Cos(theta);
        ////z = r * Mathf.Cos(theta);
        //this.gameObject.transform.position = new Vector3(0.5f, y, z);

        //theta += 2f * Mathf.PI / 360;
        //Vector3 _meteoriteVelo = -_direction * _meteoriteSpeed;
        //_meteoriteRigidbody.velocity = _meteoriteVelo;

    }
}
