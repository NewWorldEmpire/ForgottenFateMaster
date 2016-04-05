using UnityEngine;
using System.Collections;

public class ControlInitialization : MonoBehaviour {

    public bool interactChanged;
    public bool upChanged;
    public bool leftChanged;
    public bool downChanged;
    public bool rightChanged;
    public bool switchWeapChanged;
    public bool spell1Changed;
    public bool spell2Changed;
    public bool spell3Changed;
    public bool spell4Changed;

    // Use this for initialization
    void Start () {
        if(PlayerPrefs.GetString("Interact") == null)
        {
            PlayerPrefs.SetString("Interact", "e");
        }
        if (PlayerPrefs.GetString("MoveUp") == null)
        {
            PlayerPrefs.SetString("MoveUp", "w");
        }
        if (PlayerPrefs.GetString("MoveLeft") == null)
        {
            PlayerPrefs.SetString("MoveLeft", "a");
        }
        if (PlayerPrefs.GetString("MoveDown") == null)
        {
            PlayerPrefs.SetString("MoveDown", "s");
        }
        if (PlayerPrefs.GetString("MoveRight") == null)
        {
            PlayerPrefs.SetString("MoveRight", "d");
        }
        if (PlayerPrefs.GetString("SwitchWeap") == null)
        {
            PlayerPrefs.SetString("SwitchWeap", "q");
        }
        if (PlayerPrefs.GetString("Spell1") == null)
        {
            PlayerPrefs.SetString("Spell1", "1");
        }
        if (PlayerPrefs.GetString("Spell2") == null)
        {
            PlayerPrefs.SetString("Spell2", "2");
        }
        if (PlayerPrefs.GetString("Spell3") == null)
        {
            PlayerPrefs.SetString("Spell3", "3");
        }
        if (PlayerPrefs.GetString("Spell4") == null)
        {
            PlayerPrefs.SetString("Spell4", "4");
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
