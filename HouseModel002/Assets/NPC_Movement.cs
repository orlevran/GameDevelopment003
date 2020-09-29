using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class NPC_Movement : MonoBehaviour
{
    public Transform[] Points;
    int index = 0;
    bool MoveForward = true;



    void Update()
    {
        Vector3 direction = Points[index].position - transform.position;
        transform.Translate(direction.normalized * 5f * Time.deltaTime, Space.World);
        transform.LookAt(Points[index]);

        if (MoveForward)
        {
            if (Vector3.Distance(transform.position, Points[index].position) <= 0.4f)
            {
                index++;
                if (index == Points.Length)
                {
                    index--;
                    MoveForward = false;
                    return;
                }
            }
        }
        else
        {
            if (Vector3.Distance(transform.position, Points[index].position) <= 0.4f)
            {
                index--;
                if (index == 0)
                {
                    MoveForward = true;
                }
            }
        }
    }

    void Go()
    {
        for (int i = 0; i < Points.Length; i++)
        {
            
        }
    }
}
