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
	[Table("Stad")]
	public class Stad : BaseModel
	{
		public Stad()
		{
			//Don't fire notfications by default, since
			//they make editing the properties difficult.
			this.NotifyIfPropertiesChange = false;
		}


		[PrimaryKey]
        [NotNull]
		[Column("stadid")]
		public int stadid 
		{ 
			get { return stadid_private; }
			set { SetProperty(stadid_private, value, (val) => { stadid_private = val; }, stadid_PropertyName); }
		}
		public static string stadid_PropertyName = "stadid";
		private int stadid_private;
		
		


        [NotNull]
		[Column("postcode")]
		public string postcode 
		{ 
			get { return postcode_private; }
			set { SetProperty(postcode_private, value, (val) => { postcode_private = val; }, postcode_PropertyName); }
		}
		public static string postcode_PropertyName = "postcode";
		private string postcode_private;
		
		


        [NotNull]
		[Column("stad")]
		public string stad 
		{ 
			get { return stad_private; }
			set { SetProperty(stad_private, value, (val) => { stad_private = val; }, stad_PropertyName); }
		}
		public static string stad_PropertyName = "stad";
		private string stad_private;
		
		


		public override string ToString() 
		{
			StringBuilder sb = new StringBuilder();

			sb.Append(stadid.ToString());

			sb.Append("|");

			sb.Append(postcode.ToString());

			sb.Append("|");

			sb.Append(stad.ToString());

			sb.Append("|");

			return sb.ToString();
		}
	}
}