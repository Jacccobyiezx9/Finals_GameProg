using System.Collections;
using UnityEngine;
using TMPro; // Using TextMeshPro for better text rendering

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI dialogueText; // Reference to the TextMeshProUGUI component
    public float displayTime = 2f; // Time the message is displayed

    private Coroutine currentCoroutine;

    // Method to display dialogue
    public void ShowDialogue(string message)
    {
        if (currentCoroutine != null)
        {
            StopCoroutine(currentCoroutine);
        }
        currentCoroutine = StartCoroutine(DisplayDialogue(message));
    }

    private IEnumerator DisplayDialogue(string message)
    {
        dialogueText.text = message;
        dialogueText.gameObject.SetActive(true);

        yield return new WaitForSeconds(displayTime);

        dialogueText.gameObject.SetActive(false);
        dialogueText.text = "";
    }
}
