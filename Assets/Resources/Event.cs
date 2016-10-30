using UnityEngine;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;

public class Event{

	[XmlAttribute("name")]
	public string name;

	[XmlElement("Title")]
	public string title;

	[XmlElement("Description")]
	public string description;

	[XmlElement("Action")]
	public int action;

}
