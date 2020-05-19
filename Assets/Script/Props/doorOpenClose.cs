using UnityEngine;

public class doorOpenClose : MonoBehaviour
{
    public Sprite openDoor;
    public Sprite closedDoor;
    public Collider2D c2d;
    public Animator enemyAnim;

    private void Start()
    {
        c2d.enabled = false;
        this.gameObject.GetComponent<SpriteRenderer>().sprite = openDoor;
    }


    public void Open()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = openDoor;
    }

    public void Close()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = closedDoor;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            c2d.enabled = true;
            Close();
            enemyAnim.SetTrigger("OnRoomEnter");
        }
    }
}
