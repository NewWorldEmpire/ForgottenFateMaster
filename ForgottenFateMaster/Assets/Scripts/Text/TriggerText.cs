using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TriggerText : MonoBehaviour {

    public GameObject player;
    public GameObject canvas;
    public Text text;
    public Image face;
    public Sprite NPCImage;
    public GameObject target;
    
    public string[] dialogue;
    string[] temp;
    int dialogueLength;

    public GameObject[] targetArray;
    public int index = 0;

    void Start()
    {
                
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D col)
    {
        Debug.Log(gameObject);
        Debug.Log(target);

        if (index >= targetArray.Length)
        {
            canvas.SetActive(false);
        }
        else
        {
            if (ConversationScript.convoDone == false && Input.GetKeyDown("e"))                                             //this activates when the player enters the collider and presses e
            {
                face.sprite = NPCImage;
                ConversationScript.conversation = dialogue;
                canvas.SetActive(true);
                player.GetComponent<PlayerMovement>().enabled = false;
                player.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            }
            else if (ConversationScript.convoDone && (Input.GetKeyDown("e") || (Input.GetMouseButtonDown(0))))              //this runs when the dialogue is done
            {
                canvas.SetActive(false);
                text.GetComponent<ConversationScript>().convIndex = 0;
                player.GetComponent<PlayerMovement>().enabled = true;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (index >= targetArray.Length)
        {
            index = 0;
        }

        if (index <= targetArray.Length)
        {
            target = targetArray[index];
            dialogue = target.GetComponent<DialogueHandler>().dialogue;
            temp = new string[dialogue.Length];
        }        
    }

    void OnTriggerExit2D(Collider2D col)
    {
        index = index + 1;
        dialogue = temp;        
        ConversationScript.convoDone = false;
    }
}
