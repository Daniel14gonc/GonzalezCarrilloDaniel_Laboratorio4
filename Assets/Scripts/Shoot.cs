using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public AudioClip impact;
    AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hitInfo;

        if (Input.GetMouseButton(0) && Physics.Raycast(myRay, out hitInfo))
        {
            audio.PlayOneShot(impact, 0.04F);

            if (hitInfo.collider.CompareTag("Target"))
            {
                ScoreManager.setScore(ScoreManager.getScore()+1);
                Destroy(hitInfo.collider.gameObject);
            }
        }
    }
}
