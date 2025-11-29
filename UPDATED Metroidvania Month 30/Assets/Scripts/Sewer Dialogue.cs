using TMPro;
using UnityEngine;

public class SewerDialogue : MonoBehaviour
{
    public GameObject DialoguePanel;
    public TextMeshProUGUI CharacterText;
    public GameObject CharacterImage;

    public int DialogueNumber;
    public bool Nicole1Talking = false;
    public bool Nicole2Talking = false;
    public bool Nicole3Talking = false;

    public SewerCollision SC;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DialogueNumber = 0;
        DialoguePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && SC.Nicole1Talk)
        {
            DialoguePanel.SetActive(true);
            Nicole1Talking = true;
        }

        if (Input.GetKeyDown(KeyCode.Space) && SC.Nicole2Talk)
        {
            DialoguePanel.SetActive(true);
            Nicole2Talking = true;
        }

        if (Input.GetKeyDown(KeyCode.Space) && SC.Nicole3Talk)
        {
            DialoguePanel.SetActive(true);
            Nicole3Talking = true;
        }

        NicoleSpeech1();
    }

    void NicoleSpeech1()
    {
        if (Nicole1Talking && Input.GetKeyDown(KeyCode.Space))
        {
            DialogueNumber++;
        }

        switch (DialogueNumber)
        {
            case 1:
                CharacterText.text = "Hey, are you alright? That was a rough fall.";
                break;

            case 2:
                CharacterText.text = "Ugh, what happened?";
                break;

            case 3:
                CharacterText.text = "My guess is that you didn't land quite right and hit your head when you fell.";
                break;

            case 4:
                CharacterText.text = "No! I mean in general!";
                break;

            case 5:
                CharacterText.text = "Oh. Your guess is as good as mine, pal. I don't think anyone knows what the hell we just witnessed.";
                break;

            case 6:
                CharacterText.text = "So... We're lost?";
                break;

            case 7:
                CharacterText.text = "Totally. But the remains of our squad are gathered up ahead. Maybe we can figure SOMETHING out.";
                break;

            case 8:
                CharacterText.text = "Yeah... Okay.";
                break;

            case 9:
                CharacterText.text = "Name's Nicole by the way. I know they don't like us using anything but our ID numbers,";
                break;

            case 10:
                CharacterText.text = "But I think we're a little beyond company protocol at this point.";
                break;

            case 11:
                CharacterText.text = "Then you can call me Ray.";
                break;

            case 12:
                CharacterText.text = "Well then Ray, follow me. Our squad, or what's left of it, is just up ahead.";
                break;

            case 15:
                DialoguePanel.SetActive(false);
                Nicole1Talking = false;
                SC.Nicole1Talk = false;
                DialogueNumber = 0;
                break;
        }
    }
}
