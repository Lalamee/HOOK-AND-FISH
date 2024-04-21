using UnityEngine;

public class LevelFinisher : MonoBehaviour
{
    private GoodEnd _goodEnd;

    private void Awake()
    {
        _goodEnd = FindObjectOfType<GoodEnd>();
        _goodEnd.TurnOffObject();
    }

    public void BadEnd()
    {

    }

    public void GoodEnd() 
    {
        if( _goodEnd == null)
        {
            Debug.Log("√ƒ≈ ¡Àﬂ“‹");
        }
        _goodEnd.TurnOnObject();
        End();
    }

    private void End()
    {
        Time.timeScale = 0;
    }
}
