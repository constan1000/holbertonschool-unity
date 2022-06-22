using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goUrl : MonoBehaviour
{
    public void ToGithub() {
        Application.OpenURL ("https://github.com/constan1000");
    }
    public void ToTwitter() {
        Application.OpenURL ("https://twitter.com/Mejdi.hrairi");
    }
    public void ToMail() {
        Application.OpenURL ("hrairimejdi99@gmail.com");
    }
    public void ToLinkedin() {
        Application.OpenURL ("https://www.linkedin.com/in/mejdi.hrairi.99/");
    }
}
