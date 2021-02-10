using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillation : MonoBehaviour
{
    float velocity;
    float amplitude;
    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        //Inicializacion de los valores para los atributos.
        velocity = 3.0f;
        amplitude = 3.0f;
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Creacion de un vector que almacena un valor de posicion en y en funcion del seno del tiempo.
        Vector3 change = new Vector3(amplitude * Mathf.Sin(Time.time * velocity), 0 , 0);

        //Modificacion de la posicion del Game Object
        transform.position = pos + change;
    }
}
