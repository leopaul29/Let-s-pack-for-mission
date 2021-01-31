using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManageLife : MonoBehaviour
{
    public Image coeur1;
    public Image coeur2;
    public Image coeur3;

    public Health Health;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Health.CurrentHealth < 3)
        {
            coeur3.enabled = false;
        }
        if (Health.CurrentHealth < 2)
        {
            coeur2.enabled = false;
        }
        if (Health.CurrentHealth < 1)
        {
            coeur1.enabled = false;
        }
    }
}
