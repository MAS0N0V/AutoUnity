using UnityEngine;
using System.Collections;

public class check : MonoBehaviour {

    // Variables

    public bool showUpdateButton = true;
    public Rect UpdateButton = new Rect(0, 0, 0, 0);

    // the scene that it is redirected to
    public string UpdateScene = "";


    // Other stuff checked in other stuff

    public static bool update = false;
    public static string errorMessage = "You done goofed";




    private void OnGUI() 
    {
    if (showUpdateButton)
        if (GUI.Button(UpdateButton, "Check For Updates"))
        {
            // What happens if Check for Updates is clicked




            // Print "Checked for Update"
            print("Checked for Update");
        }   
    }
}

