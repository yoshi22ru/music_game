using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    [SerializeField] private float Speed = 3;
    [SerializeField] private int num = 0;
    private Renderer rend;
    private float alfa = 0;
    public AudioClip LightSe;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        audioSource = GetComponent<AudioSource>();   
    }

    // Update is called once per frame
    void Update()
    {
        if(!(rend.material.color.a<=0))
        {
            rend.material.color= new Color(rend.material.color.r, rend.material.color.r, rend.material.color.b, alfa);
        }
        if(num==1)
        {
            if(Input.GetKeyDown(KeyCode.D))
            {
                colorChange();
                AudioSounds();

            }
        }
        if (num == 2)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                colorChange();
                AudioSounds();

            }
        }
        if (num == 3)
        {
            if (Input.GetKeyDown(KeyCode.J))
            {
                colorChange();
                AudioSounds();
            }
        }
        if (num == 4)
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
                colorChange();
                AudioSounds();
            }
        }
        alfa -= Speed * Time.deltaTime;
    }
    
    void colorChange()
    {
        alfa = 0.3f;
        rend.material.color = new Color(rend.material.color.r, rend.material.color.g, rend.material.color.b, alfa);
    }

    void AudioSounds()
    {
        audioSource.PlayOneShot(LightSe);
    }
}
