using MabiMaster.Char;
using MabiMaster.Skill;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MabiMaster
{
	public class SkillSummaryViewModel
	{
		private static SkillSystem SkillSystem = LoadSkillSystem();

		public IEnumerable<RaceEnum> Races
		{
			get
			{
				return Enum.GetValues(typeof(RaceEnum)).Cast<RaceEnum>();
			}
		}

		public RaceEnum CharacterRace { get; set; }

		private Character character;

		public string CharName
		{
			get
			{
				return character.Name;
			}
			set
			{
				character.Name = value;
			}
		}
		public RaceEnum CharRace
		{
			get
			{
				return character.Race;
			}
			set
			{
				character.Race = value;
			}
		}

		public SkillSummaryViewModel()
		{
			character = new Character();
		}

		private static SkillSystem LoadSkillSystem()
		{
			const string DataPath = @"C:\Users\robertsona\Documents\Visual Studio 2013\Projects\MabiMaster\MabiMaster\SkillSystem.xml";

			using (FileStream fs = new FileStream(DataPath, FileMode.Open))
			{
				XmlSerializer serializer = new XmlSerializer(typeof(SkillSystem));
				SkillSystem SkillSystem = (SkillSystem)serializer.Deserialize(fs);
				return SkillSystem;
			}
		}
	}
}

