using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class script : MonoBehaviour
{
    // Start is called before the first frame update
    public void loadScene(string escena){
        SceneManager.LoadScene(escena);
        Debug.Log("hi");
    }
}
