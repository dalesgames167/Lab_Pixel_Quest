using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D.Sprites;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public string nextLevel = "Scene_2";

    private void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.tag)
        {
            case "Death":
                {
                    string thisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thisLevel);
                    break;
                }





            case "Finish":
                {
                    SceneManager.LoadScene(nextLevel);
                    break;
                }


        }
    }
}
