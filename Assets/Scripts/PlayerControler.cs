using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerControler : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpforce;
    public float speed = 5;
    public Animator animator;
    private SpriteRenderer sprite;

    public float score = 0;
    public Text scoreText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Key"))
        {
            Destroy(collision.gameObject);
            score += 1;
            scoreText.text = score.ToString();
        }

        if (collision.CompareTag("Finish")&&score >= 2)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
    }
    

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }
    

    
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            animator.SetBool("isgoing", true);
            sprite.flipX = true;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            animator.SetBool("isgoing", true);
            sprite.flipX = false;
        }
        else
        {
            animator.SetBool("isgoing", false);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);
            
        }



    }
}

        



