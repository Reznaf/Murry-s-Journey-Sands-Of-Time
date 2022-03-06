using UnityEngine;

public class Chest_action : MonoBehaviour
{
    public GameObject Chest;
    public Animator anima;
    // Start is called before the first frame update
    void Start()
    {
        Chest.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        anima.SetBool("IsOpened", true);
    
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        anima.SetBool("IsOpened", false);
        
    }
    
}
