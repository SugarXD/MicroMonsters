using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

[XmlRoot("EventCollection")]
public class EventContainer {

	[XmlArray("Events")]
	[XmlArrayItem("Event")]
	public List<Event> events = new List<Event>();

	public static EventContainer Load(string path){
		TextAsset _xml = Resources.Load<TextAsset> (path);
		XmlSerializer serializer = new XmlSerializer (typeof(EventContainer));
		StringReader reader = new StringReader (_xml.text);
		EventContainer events = serializer.Deserialize (reader) as EventContainer;

		reader.Close();
		return events;
	}

	public Event getRandomEvent(){
		System.Random rand = new System.Random ();
		return events[rand.Next(0, 3)];

	}

}
