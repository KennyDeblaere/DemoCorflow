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
	[Table("Verbruikartikel")]
	public class Verbruikartikel : BaseModel
	{
		public Verbruikartikel()
		{
			//Don't fire notfications by default, since
			//they make editing the properties difficult.
			this.NotifyIfPropertiesChange = false;
		}


		[PrimaryKey]
        [NotNull]
		[Column("artikelid")]
		public int artikelid 
		{ 
			get { return artikelid_private; }
			set { SetProperty(artikelid_private, value, (val) => { artikelid_private = val; }, artikelid_PropertyName); }
		}
		public static string artikelid_PropertyName = "artikelid";
		private int artikelid_private;
		
		


        [NotNull]
		[Column("aantalGebruikt")]
		public int aantalGebruikt 
		{ 
			get { return aantalGebruikt_private; }
			set { SetProperty(aantalGebruikt_private, value, (val) => { aantalGebruikt_private = val; }, aantalGebruikt_PropertyName); }
		}
		public static string aantalGebruikt_PropertyName = "aantalGebruikt";
		private int aantalGebruikt_private;
		
		


        [NotNull]
		[Column("opdrachtid")]
		public int opdrachtid 
		{ 
			get { return opdrachtid_private; }
			set { SetProperty(opdrachtid_private, value, (val) => { opdrachtid_private = val; }, opdrachtid_PropertyName); }
		}
		public static string opdrachtid_PropertyName = "opdrachtid";
		private int opdrachtid_private;
		
		


		public override string ToString() 
		{
			StringBuilder sb = new StringBuilder();

			sb.Append(artikelid.ToString());

			sb.Append("|");

			sb.Append(aantalGebruikt.ToString());

			sb.Append("|");

			sb.Append(opdrachtid.ToString());

			sb.Append("|");

			return sb.ToString();
		}
	}
}