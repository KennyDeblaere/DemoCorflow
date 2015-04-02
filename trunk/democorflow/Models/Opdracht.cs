using System;
using System.Text;
using SQLite;

namespace democorflow
{

	/**
	 * This class presents a simple ORM over the Zumero-synced SQLite 
	 * table.  Some properties may require conversion from C# objects
	 * to the representation that Zumero requires in SQLite.  For more
	 * information on why some data types are converted when stored in 
	 * a Zumero-synced SQLite database, see: 
	 * http://zumero.com/docs/zumero_for_sql_server_manager.html#data_type_conversion_and_limitations
	 */
	[Table("Opdracht")]
	public class Opdracht : BaseModel
	{
		public Opdracht()
		{
			//Don't fire notfications by default, since
			//they make editing the properties difficult.
			this.NotifyIfPropertiesChange = false;
		}


		[PrimaryKey]
        [NotNull]
		[Column("opdrachtid")]
		public int opdrachtid 
		{ 
			get { return opdrachtid_private; }
			set { SetProperty(opdrachtid_private, value, (val) => { opdrachtid_private = val; }, opdrachtid_PropertyName); }
		}
		public static string opdrachtid_PropertyName = "opdrachtid";
		private int opdrachtid_private;
		
		


        [NotNull]
		[Column("locatie")]
		public string locatie 
		{ 
			get { return locatie_private; }
			set { SetProperty(locatie_private, value, (val) => { locatie_private = val; }, locatie_PropertyName); }
		}
		public static string locatie_PropertyName = "locatie";
		private string locatie_private;
		
		


        [NotNull]
		[Column("afgewerkt")]
		public bool afgewerkt 
		{ 
			get { return afgewerkt_private; }
			set { SetProperty(afgewerkt_private, value, (val) => { afgewerkt_private = val; }, afgewerkt_PropertyName); }
		}
		public static string afgewerkt_PropertyName = "afgewerkt";
		private bool afgewerkt_private;
		
		


        [NotNull]
		[Column("klantid")]
		public int klantid 
		{ 
			get { return klantid_private; }
			set { SetProperty(klantid_private, value, (val) => { klantid_private = val; }, klantid_PropertyName); }
		}
		public static string klantid_PropertyName = "klantid";
		private int klantid_private;
		
		


		public override string ToString() 
		{
			StringBuilder sb = new StringBuilder();

			sb.Append(opdrachtid.ToString());

			sb.Append("|");

			sb.Append(locatie.ToString());

			sb.Append("|");

			sb.Append(afgewerkt.ToString());

			sb.Append("|");

			sb.Append(klantid.ToString());

			sb.Append("|");

			return sb.ToString();
		}
	}
}