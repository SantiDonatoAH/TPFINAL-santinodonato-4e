using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class spawncomida : MonoBehaviour
{

    public GameObject Empty;
    public GameObject[] comida;
    private int currentIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (comida.Length > 0)
        {
            DeactivateAll();
            comida[currentIndex].SetActive(true); 
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            DeactivateAll();
            currentIndex--;
            if (currentIndex < 0)
            {
                currentIndex = comida.Length - 1; 
            }
            comida[currentIndex].SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            DeactivateAll();
            currentIndex++;
            if (currentIndex >= comida.Length)
            {
                currentIndex = 0; 
            }
            comida[currentIndex].SetActive(true);
        }

    }


    public void DeactivateAll()
    {
        for (int i = 0; i < comida.Length; i++)
        {
            comida[i].SetActive(false);
        }

    }
}
