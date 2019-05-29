using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myMovie_texture : MonoBehaviour {

    public MovieTexture[] myVDO;
    private AudioSource mysound;
    public int s;
    public int s1 = 1;
    //public int s2 = 1;
    //float TR = 11;
    //public GameObject finalVDO;
	// Use this for initialization
	void Start () {
      s1 = 1;
      //s2 = 1;
    //myVDO.Play();
    //finalVDO.SetActive(false);
}
	
	// Update is called once per frame
	void Update () {
        /*TR -= Time.deltaTime;
        if(TR < 0)
        {
            myVDO.Stop();
            TR = 11;
            myVDO.Play();
        }*/
        if (Arduino_Initial.v1 == 0f && Arduino_Initial.v2 == 1f && Arduino_Initial.v3 == 1f && Arduino_Initial.v4 == 1f && Arduino_Initial.v5 == 1f && Arduino_Initial.v6 == 1f && Arduino_Initial.v7 == 1f && Arduino_Initial.v8 == 1f && Arduino_Initial.v9 == 1f)
        {
            s = 0;
            myVDO[1].Stop();
            myVDO[2].Stop();
            myVDO[3].Stop();
            myVDO[4].Stop();
            myVDO[5].Stop();
            myVDO[6].Stop();
            myVDO[7].Stop();
            myVDO[8].Stop();
            myVDO[0].Play();
        }
        else if(Arduino_Initial.v2 == 0f && Arduino_Initial.v1 == 1f && Arduino_Initial.v3 == 1f && Arduino_Initial.v4 == 1f && Arduino_Initial.v5 == 1f && Arduino_Initial.v6 == 1f && Arduino_Initial.v7 == 1f && Arduino_Initial.v8 == 1f && Arduino_Initial.v9 == 1f)
        {
            s = 1;
            myVDO[0].Stop();
            myVDO[2].Stop();
            myVDO[3].Stop();
            myVDO[4].Stop();
            myVDO[5].Stop();
            myVDO[6].Stop();
            myVDO[7].Stop();
            myVDO[8].Stop();
            myVDO[1].Play();

        }
        else if (Arduino_Initial.v3 == 0f && Arduino_Initial.v1 == 1f && Arduino_Initial.v2 == 1f && Arduino_Initial.v4 == 1f && Arduino_Initial.v5 == 1f && Arduino_Initial.v6 == 1f && Arduino_Initial.v7 == 1f && Arduino_Initial.v8 == 1f && Arduino_Initial.v9 == 1f)
        {
            s = 2;
            myVDO[0].Stop();
            myVDO[1].Stop();
            myVDO[2].Stop();
            myVDO[3].Stop();
            myVDO[4].Stop();
            myVDO[5].Stop();
            myVDO[6].Stop();
            myVDO[7].Stop();
            myVDO[2].Play();

        }
        else if (Arduino_Initial.v4 == 0f && Arduino_Initial.v1 == 1f && Arduino_Initial.v2 == 1f && Arduino_Initial.v3 == 1f && Arduino_Initial.v5 == 1f && Arduino_Initial.v6 == 1f && Arduino_Initial.v7 == 1f && Arduino_Initial.v8 == 1f && Arduino_Initial.v9 == 1f)
        {
            s = 3;
            myVDO[0].Stop();
            myVDO[1].Stop();
            myVDO[2].Stop();
            myVDO[4].Stop();
            myVDO[5].Stop();
            myVDO[6].Stop();
            myVDO[7].Stop();
            myVDO[8].Stop();
            myVDO[3].Play();

        }
        else if (Arduino_Initial.v5 == 0f && Arduino_Initial.v1 == 1f && Arduino_Initial.v2 == 1f && Arduino_Initial.v3 == 1f && Arduino_Initial.v4 == 1f && Arduino_Initial.v6 == 1f && Arduino_Initial.v7 == 1f && Arduino_Initial.v8 == 1f && Arduino_Initial.v9 == 1f)
        {
            s = 4;
            myVDO[0].Stop();
            myVDO[1].Stop();
            myVDO[2].Stop();
            myVDO[3].Stop();
            myVDO[5].Stop();
            myVDO[6].Stop();
            myVDO[7].Stop();
            myVDO[8].Stop();
            myVDO[4].Play();

        }
        else if (Arduino_Initial.v6 == 0f && Arduino_Initial.v1 == 1f && Arduino_Initial.v2 == 1f && Arduino_Initial.v3 == 1f && Arduino_Initial.v4 == 1f && Arduino_Initial.v5 == 1f && Arduino_Initial.v7 == 1f && Arduino_Initial.v8 == 1f && Arduino_Initial.v9 == 1f)
        {
            s = 5;
            myVDO[0].Stop();
            myVDO[1].Stop();
            myVDO[2].Stop();
            myVDO[3].Stop();
            myVDO[4].Stop();
            myVDO[6].Stop();
            myVDO[7].Stop();
            myVDO[8].Stop();
            myVDO[5].Play();

        }
        else if (Arduino_Initial.v7 == 0f && Arduino_Initial.v1 == 1f && Arduino_Initial.v2 == 1f && Arduino_Initial.v3 == 1f && Arduino_Initial.v4 == 1f && Arduino_Initial.v5 == 1f && Arduino_Initial.v6 == 1f && Arduino_Initial.v8 == 1f && Arduino_Initial.v9 == 1f)
        {
            s = 6;
            myVDO[0].Stop();
            myVDO[1].Stop();
            myVDO[2].Stop();
            myVDO[3].Stop();
            myVDO[4].Stop();
            myVDO[6].Stop();
            myVDO[7].Stop();
            myVDO[8].Stop();
            myVDO[6].Play();

        }
        else if (Arduino_Initial.v8 == 0f && Arduino_Initial.v1 == 1f && Arduino_Initial.v2 == 1f && Arduino_Initial.v3 == 1f && Arduino_Initial.v4 == 1f && Arduino_Initial.v5 == 1f && Arduino_Initial.v6 == 1f && Arduino_Initial.v7 == 1f && Arduino_Initial.v9 == 1f)
        {
            s = 7;
            myVDO[0].Stop();
            myVDO[1].Stop();
            myVDO[2].Stop();
            myVDO[3].Stop();
            myVDO[4].Stop();
            myVDO[5].Stop();
            myVDO[8].Stop();
            myVDO[7].Play();

        }
        else if (Arduino_Initial.v9 == 0f && Arduino_Initial.v1 == 1f && Arduino_Initial.v2 == 1f && Arduino_Initial.v3 == 1f && Arduino_Initial.v4 == 1f && Arduino_Initial.v5 == 1f && Arduino_Initial.v6 == 1f && Arduino_Initial.v7 == 1f && Arduino_Initial.v8 == 1f)
        {
            s = 8;
            myVDO[0].Stop();
            myVDO[1].Stop();
            myVDO[2].Stop();
            myVDO[3].Stop();
            myVDO[4].Stop();
            myVDO[5].Stop();
            myVDO[6].Stop();
            myVDO[7].Stop();
            myVDO[8].Play();

        }
        else if(s1 == 1)
        {
            s = 0;
            myVDO[0].Play();
        }
        else
        {
            s = 10;
            myVDO[0].Stop();
            myVDO[1].Stop();
            myVDO[2].Stop();
            myVDO[3].Stop();
            myVDO[4].Stop();
            myVDO[5].Stop();
            myVDO[6].Stop();
            myVDO[7].Stop();
            myVDO[8].Stop();
        }
        GetComponent<Renderer>().material.mainTexture = myVDO[s] as MovieTexture;
        mysound = GetComponent<AudioSource>();
    }
}
