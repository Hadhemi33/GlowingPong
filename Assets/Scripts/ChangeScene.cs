using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour
{
    public void MoveToScene (int sceneID)
    {
        
        //we are loading the Id of the scene which we want to move to
        SceneManager.LoadScene (sceneID); 


    }

    public void Quit()
    {
        //Quit the app when the user click the quit button
        Application.Quit ();
    }
}
