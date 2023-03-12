using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public GameObject finish;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (finish.active == true)
        {
            tomenu();
        }
        
    }
    public void tomenu()
    {
        SceneManager.LoadScene(0);
    }
}
