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
		public SkillSystem SkillSystem { get; set; }

		public SkillSummaryViewModel() {

			const string DataPath = @"C:\Users\robertsona\Documents\Visual Studio 2013\Projects\MabiMaster\MabiMaster\SkillSystem.xml";
			
			XmlSerializer serializer = new XmlSerializer(typeof(SkillSystem));

			FileStream fs = new FileStream(DataPath, FileMode.Open);

			SkillSystem = (SkillSystem)serializer.Deserialize(fs);

			fs.Close();
		}
	}
}

