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
	[Table("Bedrijf_Contact")]
	public class Bedrijf_Contact : BaseModel
	{
		public Bedrijf_Contact()
		{
			//Don't fire notfications by default, since
			//they make editing the properties difficult.
			this.NotifyIfPropertiesChange = false;
		}



        [NotNull]
		[Column("bedrijfsid")]
		public int bedrijfsid 
		{ 
			get { return bedrijfsid_private; }
			set { SetProperty(bedrijfsid_private, value, (val) => { bedrijfsid_private = val; }, bedrijfsid_PropertyName); }
		}
		public static string bedrijfsid_PropertyName = "bedrijfsid";
		private int bedrijfsid_private;
		
		


        [NotNull]
		[Column("contactid")]
		public int contactid 
		{ 
			get { return contactid_private; }
			set { SetProperty(contactid_private, value, (val) => { contactid_private = val; }, contactid_PropertyName); }
		}
		public static string contactid_PropertyName = "contactid";
		private int contactid_private;
		
		

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

			sb.Append(bedrijfsid.ToString());

			sb.Append("|");

			sb.Append(contactid.ToString());

			sb.Append("|");

			sb.Append(id.ToString());

			sb.Append("|");

			return sb.ToString();
		}
	}
}