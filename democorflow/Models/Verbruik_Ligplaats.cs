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
	[Table("Verbruik_Ligplaats")]
	public class Verbruik_Ligplaats : BaseModel
	{
		public Verbruik_Ligplaats()
		{
			//Don't fire notfications by default, since
			//they make editing the properties difficult.
			this.NotifyIfPropertiesChange = false;
		}



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
		[Column("ligplaatsid")]
		public int ligplaatsid 
		{ 
			get { return ligplaatsid_private; }
			set { SetProperty(ligplaatsid_private, value, (val) => { ligplaatsid_private = val; }, ligplaatsid_PropertyName); }
		}
		public static string ligplaatsid_PropertyName = "ligplaatsid";
		private int ligplaatsid_private;
		
		


        [NotNull]
		[Column("aantalStock")]
		public int aantalStock 
		{ 
			get { return aantalStock_private; }
			set { SetProperty(aantalStock_private, value, (val) => { aantalStock_private = val; }, aantalStock_PropertyName); }
		}
		public static string aantalStock_PropertyName = "aantalStock";
		private int aantalStock_private;
		
		

		[PrimaryKey]
        [NotNull]
		[Column("id")]
		public int id 
		{ 
			get { return id_private; }
			set { SetProperty(id_private, value, (val) => { id_private = val; }, id_PropertyName); }
		}
		public static string id_PropertyName = "id";
		private int id_private;
		
		


		public override string ToString() 
		{
			StringBuilder sb = new StringBuilder();

			sb.Append(artikelid.ToString());

			sb.Append("|");

			sb.Append(ligplaatsid.ToString());

			sb.Append("|");

			sb.Append(aantalStock.ToString());

			sb.Append("|");

			sb.Append(id.ToString());

			sb.Append("|");

			return sb.ToString();
		}
	}
}