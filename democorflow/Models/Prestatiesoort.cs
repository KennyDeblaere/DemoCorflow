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
	[Table("Prestatiesoort")]
	public class Prestatiesoort : BaseModel
	{
		public Prestatiesoort()
		{
			//Don't fire notfications by default, since
			//they make editing the properties difficult.
			this.NotifyIfPropertiesChange = false;
		}


		[PrimaryKey]
        [NotNull]
		[Column("prestatieid")]
		public int prestatieid 
		{ 
			get { return prestatieid_private; }
			set { SetProperty(prestatieid_private, value, (val) => { prestatieid_private = val; }, prestatieid_PropertyName); }
		}
		public static string prestatieid_PropertyName = "prestatieid";
		private int prestatieid_private;
		
		


        [NotNull]
		[Column("omschrijving")]
		public string omschrijving 
		{ 
			get { return omschrijving_private; }
			set { SetProperty(omschrijving_private, value, (val) => { omschrijving_private = val; }, omschrijving_PropertyName); }
		}
		public static string omschrijving_PropertyName = "omschrijving";
		private string omschrijving_private;
		
		


		public override string ToString() 
		{
			StringBuilder sb = new StringBuilder();

			sb.Append(prestatieid.ToString());

			sb.Append("|");

			sb.Append(omschrijving.ToString());

			sb.Append("|");

			return sb.ToString();
		}
	}
}