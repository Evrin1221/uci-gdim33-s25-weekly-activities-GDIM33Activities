using UnityEngine;
using Unity.VisualScripting;

public class DialogueAdvancer : MonoBehaviour
{
    [SerializeField] private DialogueNode nextLine;
    [SerializeField] private DialogueNode firstLine;


    // Button hooks up to this method
    public void ChooseDialogue ()
    {
        EventBus.Trigger(EventNames.NewDialogueEvent, nextLine);
    }

    public void PrintHello ()
    {
        Debug.Log("hello!");
    }

    private void Start()
    {
        EventBus.Trigger(EventNames.NewDialogueEvent, firstLine);
    }
}
