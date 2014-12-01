using UnityEngine;
using System.Collections;
using System.Linq;

public class ChangeTexture : MonoBehaviour
{


		private UITexture myTexture;
		private float speed = 1f;
		private Texture2D[] textureResources;
		private int index = 0;
		public int effeciency = 25;
		private float count = 3f;
		private float temp = 0f;
		private bool ifPlay = false;

		void Start ()
		{
				myTexture = transform.GetComponent<UITexture> ();
				textureResources = (Texture2D[])Resources.LoadAll ("Texture/Traffic", typeof(Texture2D)).Cast<Texture2D> ().ToArray ();
				;
		}

		void Update ()
		{
				if (textureResources == null)
						return;
				if (!ifPlay)
						return;
				temp += Time.deltaTime;
		
				if (temp >= 1.0 / effeciency) {

						index++;
			
						temp = 0;

						if (index >= textureResources.Length - 1) {
								index = textureResources.Length - 1;
							
						}
				}

				myTexture.mainTexture = textureResources [index];
		}

		void OnGUI ()
		{
				if (GUILayout.Button ("Play")) {
						
								ifPlay = true;
				}
		}
	public void Event()
	{
		print ("Click !");
	}
}
