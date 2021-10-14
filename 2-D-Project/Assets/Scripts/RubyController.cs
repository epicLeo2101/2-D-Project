using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        //Gives data to the computer so it can move your character Left, right, up, and down.
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        //Shows the code logs in the play testing.
        Debug.Log(horizontal);
        Debug.Log(vertical);

        //This gives instructions on what the code should do
        Vector2 position = transform.position;

        /*Tis part of the code moves the character to the Y or X axis of your choosing.
         Keep in mind that the 10.0f are how fast they move. The higher the number the faster they go
        Time.deltaTime is making movement for each frame take to what number you place.*/
        position.x = position.x + 10.0f * horizontal * Time.deltaTime;
        position.y = position.y + 10.0f * vertical * Time.deltaTime;

        //This is like Console.ReadLine(); it tells the computer to comence the action.
        transform.position = position;
    }
}
