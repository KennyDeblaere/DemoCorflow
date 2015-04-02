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
	[Table("Opdracht_Werknemer")]
	public class Opdracht_Werknemer : BaseModel
	{
		public Opdracht_Werknemer()
		{
			//Don't fire notfications by default, since
			//they make editing the properties difficult.
			this.NotifyIfPropertiesChange = false;
		}



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
		[Column("werknemerid")]
		public int werknemerid 
		{ 
			get { return werknemerid_private; }
			set { SetProperty(werknemerid_private, value, (val) => { werknemerid_private = val; }, werknemerid_PropertyName); }
		}
		public static string werknemerid_PropertyName = "werknemerid";
		private int werknemerid_private;
		
		

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

			sb.Append(prestatieid.ToString());

			sb.Append("|");

			sb.Append(werknemerid.ToString());

			sb.Append("|");

			sb.Append(id.ToString());

			sb.Append("|");

			return sb.ToString();
		}
	}
}