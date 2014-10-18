#pragma strict
import UnityEngine.UI;

var burbuja1 : Canvas;
var burbuja2 : Canvas;
var burbuja3 : Canvas;
var tiempo : float;

function Start () {

tiempo = 0;
}

function Update () {

tiempo = tiempo + (1 * Time.deltaTime);

if (tiempo >= 0 && tiempo < 3)
	{
	burbuja1.enabled = true;
	burbuja1.SendMessage("DialogCreate", "vamonos chicos");
	}
else
	{
	if (tiempo > 3 && tiempo < 6)
		{
		burbuja1.SendMessage("DialogCreate", "partamos de casa");
		}
	else
		{
		burbuja1.enabled = false;
		if (tiempo > 6 && tiempo < 9)
			{
			burbuja2.enabled = true;
			burbuja2.SendMessage("DialogCreate", "ya somos grandes");			
			}
		else
			{
			if (tiempo > 9 && tiempo < 12)
				{                                     
				burbuja2.SendMessage("DialogCreate", "podemos vivir solos");
				}
			else
				{
				burbuja2.enabled = false;
				if (tiempo > 12 && tiempo < 15)
					{
					burbuja3.enabled = true;
					burbuja3.SendMessage("DialogCreate", "busquemos materiales");
					}			 
				else
					{
					if (tiempo > 15 && tiempo < 18) 
						{
						burbuja3.SendMessage("DialogCreate", "para hacer nuestras casas");
						}
					else
						{
						burbuja3.enabled = false;
						}
						
					}
				}
			}
		}
	}
}