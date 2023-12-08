using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class Goals : MonoBehaviour
{

    public EventTrigger.TriggerEvent scoreTrigger;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Paddle paddle = collision.gameObject.GetComponent<Paddle>();

        if (paddle != null)
        {
            BaseEventData eventData = new BaseEventData(EventSystem.current);

            this.scoreTrigger.Invoke(eventData);
        }
    }
}
