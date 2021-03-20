using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenechanger : MonoBehaviour
{
   public void scene1()
    {
        SceneManager.LoadScene("Assistant");
    }
    public void scene2()
    {
        SceneManager.LoadScene("Main_Scenes");
    }
    
}
