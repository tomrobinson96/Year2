using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class VehicleSelector : MonoBehaviour
{
    //SID: 1221628
    //This class is used for selecting the vehicle and loading into the correct scene(level)
    //Each button represents a different scene (All levels are the same, just the vehicle changes between scenes)
    //For example - Button one loads the level with the vehicle present on screen - Button two would load the same level but with a different vehicle model present
    public Canvas VehicleSelection;
    public Button SelectVehicle1;
    public Button SelectVehicle2;
    public Button SelectVehicle3;
    public Button SelectVehicle4;



    public void SelectVehicleThis1 ()
    {
        Application.LoadLevel(2);
    }

    public void SelectVehicleThis2()
    {
        Application.LoadLevel(3);
    }

    public void SelectVehicleThis3()
    {
        Application.LoadLevel(4);
    }

    public void SelectVehicleThis4()
    {
        Application.LoadLevel(5);
    }
    
    
        

     
      
}
