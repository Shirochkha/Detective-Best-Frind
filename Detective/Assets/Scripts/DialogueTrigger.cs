using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogueTrigger : MonoBehaviour
{

    private bool nearTheNPC = false;
    public string fileName; // указываем имя файла диалога
    public GameObject nextDoor;

    private void OnTriggerEnter(Collider other)
    {
        SetNearTheNPC(true);
    }
    private void OnTriggerStay(Collider collision)
    {
        SetNearTheNPC(true);
    }
    private void OnTriggerExit(Collider collision)
    {
        SetNearTheNPC(false);
    }

    void Update()
    {
        if (nearTheNPC && Input.GetKeyDown(KeyCode.E))
        {
            DialogueTrigger dt = GetComponent<DialogueTrigger>();
            DialogueManager.Internal.DialogueStart(dt.fileName);
            Destroy(nextDoor);
        }
        else if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Q))
        {
            DialogueManager.Internal.CloseDialogue();
        }
    }

    private void SetNearTheNPC(bool value)
    {
        nearTheNPC = value;
    }
}
