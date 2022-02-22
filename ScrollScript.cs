using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollScript : MonoBehaviour
{
    public GameObject current_picture;
    public int picture_id;
    public int lever_pos;
    public int slow_counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lever_pos == 1)
        {
            StartCoroutine(SlowMoveForward)
        }
        else if (lever_pos == 2)
        {
            StartCoroutine(SlowMoveBack)
        }
        else (lever_pos == 0)
        {
            slow_counter = 0;
        }

    }

    IEnumerator SlowMoveForward()
    {
        while (lever_pos == 1)
        {
            if (slow_counter < 3)
            {
                picture_id++;
                yield return new WaitForSeconds(0.5);
                slow_counter++;
                return
            }
            else
            {
                yield return new WaitForSeconds(0.05);
                picture_id++;
            }


        }

    }

    IEnumerator SlowMoveBack()
    {
        while (lever_pos == 2)
        {
            if (slow_counter < 3)
            {
                picture_id--;
                yield return new WaitForSeconds(0.5);
                slow_counter++;
                return
            }
            else
            {
                yield return new WaitForSeconds(0.05);
                picture_id--;
            }


        }

    }
    
}
