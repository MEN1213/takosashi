using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gaoal : MonoBehaviour
{
    // public static bool goal;
    // Start is called before the first frame update
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag =="Player" )
        {
            Debug.Log("�S�[��");
            SceneManager.LoadScene("Reselt");
        }
    }
}
