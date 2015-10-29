using System.ComponentModel;
using System.Xml.Serialization;
namespace MabiMaster
{

	[XmlRoot]
	public partial class SkillSystem
	{
		[XmlArrayItem("Category")]
		public Category[] Categories { get; set; }
	}

	public partial class Category
	{
		[XmlElement("Skill")]
		public Skill[] Skills { get; set; }

		[XmlAttribute("name")]
		public string Name { get; set; }
	}

	public partial class Skill
	{
		[XmlElement]
		public Rank[] Rank { get; set; }

		[XmlAttribute("name")]
		public string Name { get; set; }

		[DefaultValue(true)]
		[XmlAttribute("elf")]
		public bool Elf { get; set; }

		[DefaultValue(true)]
		[XmlAttribute("human")]
		public bool Human { get; set; }
		
		[DefaultValue(true)]
		[XmlAttribute("giant")]
		public bool Giant { get; set; }

		public Skill()
		{
			Human = true;
			Elf = true;
			Giant = true;
		}
	}

	public partial class Rank
	{
		[XmlAttribute]
		public string l{get;set;}

		[DefaultValue((byte)0)]
		[XmlAttribute]
		public byte ap{get;set;}

		[DefaultValue((byte)0)]
		[XmlAttribute]
		public byte @int{get;set;}
		
		[DefaultValue((byte)0)]
		[XmlAttribute]
		public byte str{get;set;}

		[DefaultValue((byte)0)]
		[XmlAttribute]
		public byte dex{get;set;}
		
		[DefaultValue((byte)0)]
		[XmlAttribute]
		public byte will{get;set;}

		[DefaultValue((byte)0)]
		[XmlAttribute]
		public byte luck{get;set;}

		[DefaultValue((byte)0)]
		[XmlAttribute]
		public byte hp{get;set;}
		
		[DefaultValue((byte)0)]
		[XmlAttribute]
		public byte mp{get;set;}
		
		[DefaultValue((byte)0)]
		[XmlAttribute]
		public byte stam{get;set;}

		[DefaultValue(false)]
		[XmlAttribute]
		public bool disabled{get;set;}
	}
}
