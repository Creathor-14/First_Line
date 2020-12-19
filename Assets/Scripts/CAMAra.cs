using UnityEngine;

public class CAMAra : MonoBehaviour
{
    private SpriteRenderer sprite;
    //faltan colocar los limites de hasta donde puede llegar el personaje(14:31)
    //static Vector Limits = new Vector2();

    public float speed= 4f;


    void Update()
    {
        Vector3 mov = new Vector3(4, 0,0);
        transform.position = Vector3.MoveTowards(transform.position, transform.position + mov, Time.deltaTime * speed);

    }
}