using UnityEngine;
using UnityEngine.UI; //Allows UI elements to be called
using System.Collections;

//Menu Scripts controlling settings & basic functionality
//SID: 1221628


public class menuScript : MonoBehaviour
{
    //Definition of all UI elements
    public Canvas quitMenu;
    public Canvas settingsOptions;
    public Button playGame;
    public Button settingsMenu;
    public Button exitText;
    public Button returnTo;
    public Slider volumeControl;
    private float volume = 1.0f;



    
    public void Start()
    {

        quitMenu = quitMenu.GetComponent<Canvas>();
        settingsOptions = settingsOptions.GetComponent<Canvas>();
        playGame = playGame.GetComponent<Button>();
        settingsMenu = settingsMenu.GetComponent<Button>();
        exitText = exitText.GetComponent<Button>();
        quitMenu.enabled = false;
        settingsOptions.enabled = false;
    }

    public void ExitPress() //On Exit press the following is true;
    {

        quitMenu.enabled = true;
        playGame.enabled = false;
        settingsMenu.enabled = false;
        exitText.enabled = false;

    }

    public void NoPress() //When pressing no on the exit pop up the following is true;
    {
        quitMenu.enabled = false;
        playGame.enabled = true;
        settingsMenu.enabled = true;
        exitText.enabled = true;

    }

    public void SettingsPress() //On Settings press the following is true;
    {

        settingsOptions.enabled = true;
        playGame.enabled = false;
        settingsMenu.enabled = false;
        exitText.enabled = false;

    }

    public void ReturnPress() //When pressing return on the settings pop up the following is true;
    {
        settingsOptions.enabled = false;
        playGame.enabled = true;
        settingsMenu.enabled = true;
        exitText.enabled = true;

    }

    public void Update()

    {
        returnTo = returnTo.GetComponent<Button>();
        volumeControl = volumeControl.GetComponent<Slider>();
        returnTo.enabled = true;
    }

    public void VolumeControl()
    {
        volumeControl.value = Mathf.MoveTowards(volumeControl.value, 1.0f, 0.0f);
        AudioListener.volume = volume;

    }

    public void StartGame() //Loads the vehicle selection screen
    {
        Application.LoadLevel("Vehicle Selection");
    }

    public void ExitGame() //Exits the game
    {
        Application.Quit();

    }

    
}
