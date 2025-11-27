using UnityEngine;
using TMPro;

public class FirstSceneDialogue : MonoBehaviour
{
    public GameObject DialoguePanel;
    public TextMeshProUGUI CharacterText;
    public GameObject CharacterImage;

    public int DialogueNumber;
    public bool SupervisorTalking = false;

    public PlayerCollision PC;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DialogueNumber = 0;
        DialoguePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && PC.CanTalk)
        {
            DialoguePanel.SetActive(true);
            SupervisorTalking = true;
        }

        SuperVisorSpeech();
    }

    void SuperVisorSpeech()
    {
        if(SupervisorTalking && Input.GetKeyDown(KeyCode.Space))
        {
            DialogueNumber++;
        }

        switch(DialogueNumber)
        {
            case 1:
                CharacterText.text = "Alright maggots, listen up!";
                break;

            case 2:
                CharacterText.text = "Operation Full Measure has just been approved!";
                break;

            case 3:
                CharacterText.text = "And we've been assigned to clear the way for the heavy machinery!";
                break;

            case 4:
                CharacterText.text = "I don't wanna see anyone stop until all the trees in our way are gone!";
                break;

            case 5:
                CharacterText.text = "Is that understood?!";
                break;

            case 6:
                DialoguePanel.SetActive(false);
                SupervisorTalking = false;
                PC.CanTalk = false;
                DialogueNumber = 0;
                break;
        }
    }
}
