using UnityEngine;
using UnityEngine.UI;
public class BarraVida : MonoBehaviour
{
    public Image Vida_Armadura;
    private float hp, maxHp = 100f;
    // Start is called before the first frame update
    void Start()
    {
        hp = maxHp;
    }

    public void Daño(float daño)
    {
        hp = Mathf.Clamp(hp = daño, 0f, maxHp);
        Vida_Armadura.transform.localScale=new Vector2(hp/maxHp,1);
    }
}
