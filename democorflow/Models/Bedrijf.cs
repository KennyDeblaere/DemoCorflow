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
	[Table("Bedrijf")]
	public class Bedrijf : BaseModel
	{
		public Bedrijf()
		{
			//Don't fire notfications by default, since
			//they make editing the properties difficult.
			this.NotifyIfPropertiesChange = false;
		}


		[PrimaryKey]
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
		[Column("btwnr")]
		public string btwnr 
		{ 
			get { return btwnr_private; }
			set { SetProperty(btwnr_private, value, (val) => { btwnr_private = val; }, btwnr_PropertyName); }
		}
		public static string btwnr_PropertyName = "btwnr";
		private string btwnr_private;
		
		


        [NotNull]
		[Column("bedrijfsnaam")]
		public string bedrijfsnaam 
		{ 
			get { return bedrijfsnaam_private; }
			set { SetProperty(bedrijfsnaam_private, value, (val) => { bedrijfsnaam_private = val; }, bedrijfsnaam_PropertyName); }
		}
		public static string bedrijfsnaam_PropertyName = "bedrijfsnaam";
		private string bedrijfsnaam_private;
		
		



		[Column("naamcode")]
		public string naamcode 
		{ 
			get { return naamcode_private; }
			set { SetProperty(naamcode_private, value, (val) => { naamcode_private = val; }, naamcode_PropertyName); }
		}
		public static string naamcode_PropertyName = "naamcode";
		private string naamcode_private;
		
		


        [NotNull]
		[Column("straatnaam")]
		public string straatnaam 
		{ 
			get { return straatnaam_private; }
			set { SetProperty(straatnaam_private, value, (val) => { straatnaam_private = val; }, straatnaam_PropertyName); }
		}
		public static string straatnaam_PropertyName = "straatnaam";
		private string straatnaam_private;
		
		


        [NotNull]
		[Column("nummer")]
		public string nummer 
		{ 
			get { return nummer_private; }
			set { SetProperty(nummer_private, value, (val) => { nummer_private = val; }, nummer_PropertyName); }
		}
		public static string nummer_PropertyName = "nummer";
		private string nummer_private;
		
		


        [NotNull]
		[Column("stadid")]
		public int stadid 
		{ 
			get { return stadid_private; }
			set { SetProperty(stadid_private, value, (val) => { stadid_private = val; }, stadid_PropertyName); }
		}
		public static string stadid_PropertyName = "stadid";
		private int stadid_private;
		
		


		public override string ToString() 
		{
			StringBuilder sb = new StringBuilder();

			sb.Append(bedrijfsid.ToString());

			sb.Append("|");

			sb.Append(btwnr.ToString());

			sb.Append("|");

			sb.Append(bedrijfsnaam.ToString());

			sb.Append("|");

			if (naamcode != null)
			{
				sb.Append(naamcode.ToString());
			}
			sb.Append("|");

			sb.Append(straatnaam.ToString());

			sb.Append("|");

			sb.Append(nummer.ToString());

			sb.Append("|");

			sb.Append(stadid.ToString());

			sb.Append("|");

			return sb.ToString();
		}
	}
}