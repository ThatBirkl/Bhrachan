using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b_WorldObject : MonoBehaviour
{
    [SerializeField]
    protected GameObject player;


    protected bool _visible_;
    protected bool _col_;

	protected virtual void Start ()
    {
        _col_ = true;
        DeactivateCollider();
        gameObject.GetComponent<SpriteRenderer>().color = new Color(
                gameObject.GetComponent<SpriteRenderer>().color.r,
                gameObject.GetComponent<SpriteRenderer>().color.g,
                gameObject.GetComponent<SpriteRenderer>().color.b,
                0f);
        _visible_ = false;
    }

	protected virtual void Update ()
    {
        HandleVisibilityAndCollision();
    }

    protected virtual void HandleVisibilityAndCollision()
    {
        if (PlayerOnSamePlane)
        {
            ActivateCollider();
            Display();
        }
        else if (PlayerAbove)
        {
            DeactivateCollider();
            Display();
        }
        else
        {
            DeactivateCollider();
            Hide();
        }
    }

    private bool PlayerOnSamePlane
    {
        get
        {
            return (player.transform.position.z == transform.position.z);
        }
    }

    private bool PlayerAbove
    {
        get
        {
            //since up is in the negative direction this has to be smaller meaning if z is smaller its higher up
            return (player.transform.position.z < transform.position.z);
        }
    }

    private void Display()
    {
        if (!_visible_)
        {
            _visible_ = true;
            StartCoroutine(FadeIn());
            StopCoroutine(FadeOut());
        }
    }

    private void Hide()
    {
        if (_visible_)
        {

            _visible_ = false;
            StartCoroutine(FadeOut());
            StopCoroutine(FadeIn());
        }
    }

    private void ActivateCollider()
    {
        if (!_col_)
        {
            _col_ = true;
            //gameObject.GetComponent<Collider2D>().enabled = true;
            Collider2D[] cols = gameObject.GetComponents<Collider2D>();

            foreach (Collider2D x in cols)
            {
                x.enabled = true;
            }
        }
    }

    private void DeactivateCollider()
    {
        if (_col_)
        {
            _col_ = false;
            //gameObject.GetComponent<Collider2D>().enabled = false;
            Collider2D[] cols = gameObject.GetComponents<Collider2D>();

            foreach (Collider2D x in cols)
            {
                x.enabled = false;
            }
        }
    }

    private IEnumerator FadeIn()
    {
        while (gameObject.GetComponent<SpriteRenderer>().color.a < 1)
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(
                gameObject.GetComponent<SpriteRenderer>().color.r,
                gameObject.GetComponent<SpriteRenderer>().color.g,
                gameObject.GetComponent<SpriteRenderer>().color.b,
                gameObject.GetComponent<SpriteRenderer>().color.a + 0.05f);
            yield return new WaitForSeconds(0.01f);
        }
    }

    private IEnumerator FadeOut()
    {
        while (gameObject.GetComponent<SpriteRenderer>().color.a > 0)
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(
                gameObject.GetComponent<SpriteRenderer>().color.r,
                gameObject.GetComponent<SpriteRenderer>().color.g,
                gameObject.GetComponent<SpriteRenderer>().color.b,
                gameObject.GetComponent<SpriteRenderer>().color.a - 0.05f);
            yield return new WaitForSeconds(0.01f);
        }
    }
}
