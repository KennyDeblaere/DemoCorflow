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
	[Table("Artikel")]
	public class Artikel : BaseModel
	{
		public Artikel()
		{
			//Don't fire notfications by default, since
			//they make editing the properties difficult.
			this.NotifyIfPropertiesChange = false;
		}


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
		
		


        [NotNull]
		[Column("omschrijving")]
		public string omschrijving 
		{ 
			get { return omschrijving_private; }
			set { SetProperty(omschrijving_private, value, (val) => { omschrijving_private = val; }, omschrijving_PropertyName); }
		}
		public static string omschrijving_PropertyName = "omschrijving";
		private string omschrijving_private;
		
		


        [NotNull]
		[Column("barcode")]
		public string barcode 
		{ 
			get { return barcode_private; }
			set { SetProperty(barcode_private, value, (val) => { barcode_private = val; }, barcode_PropertyName); }
		}
		public static string barcode_PropertyName = "barcode";
		private string barcode_private;
		
		


		public override string ToString() 
		{
			StringBuilder sb = new StringBuilder();

			sb.Append(id.ToString());

			sb.Append("|");

			sb.Append(omschrijving.ToString());

			sb.Append("|");

			sb.Append(barcode.ToString());

			sb.Append("|");

			return sb.ToString();
		}
	}
}