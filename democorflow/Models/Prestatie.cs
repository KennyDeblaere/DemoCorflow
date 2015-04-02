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
	[Table("Prestatie")]
	public class Prestatie : BaseModel
	{
		public Prestatie()
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
		
		



		[Column("aanvang")]

		// The actual column definition, as seen in SQLite
		public string aanvang_raw { get; set; }

		public static string aanvang_PropertyName = "aanvang";
		
		// A helper definition that will not be saved to SQLite directly.
		// This property reads and writes to the _raw property.
		[Ignore]
		public Nullable<DateTime> aanvang { 
			// Watch out for time zones, as they are not encoded into
			// the database. Here, I make no assumptions about time
			// zones.
			get { return aanvang_raw != null ? (Nullable<DateTime>)DateTime.Parse(aanvang_raw) : (Nullable<DateTime>)null; }
			set { SetProperty(aanvang_raw, aanvang_ConvertToString(value), (val) => { aanvang_raw = val; }, aanvang_PropertyName); }
		}

		// This static method is helpful when you need to query
		// on the raw value.
		public static string aanvang_ConvertToString(Nullable<DateTime> date)
		{
			if (!date.HasValue)
				return null;
			else
	
			return date.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");
		
		}

		



		[Column("duur")]

		// The actual column definition, as seen in SQLite
		public Nullable<long> duur_raw { get; set; }

		// This is the static scaling factor that will be applied to convert
		// from long to decimal. 
		private static long _duur_scale = (long)Math.Pow(10, 0);

		public static string duur_PropertyName = "duur";
		
		// A helper definition that will not be saved to SQLite directly.
		// This property reads and writes to the _raw property.
		[Ignore]
		public Nullable<decimal> duur { 
			get { return duur_raw.HasValue ? (Nullable<decimal>)((decimal)duur_raw / (decimal)_duur_scale) : null; }
			set { SetProperty(duur_raw, duur_ConvertToInt(value), (val) => { duur_raw = val; }, duur_PropertyName); }
		}

		// This static method is helpful when you need to query
		// on the raw value.
		public static Nullable<long> duur_ConvertToInt(Nullable<decimal> arg_duur)
		{
			if (!arg_duur.HasValue)
				return null;
			else
				return (long)Math.Floor((double)(arg_duur.Value * (decimal)_duur_scale));
		}

		


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
		[Column("prestatiesoortid")]
		public int prestatiesoortid 
		{ 
			get { return prestatiesoortid_private; }
			set { SetProperty(prestatiesoortid_private, value, (val) => { prestatiesoortid_private = val; }, prestatiesoortid_PropertyName); }
		}
		public static string prestatiesoortid_PropertyName = "prestatiesoortid";
		private int prestatiesoortid_private;
		
		


		public override string ToString() 
		{
			StringBuilder sb = new StringBuilder();

			sb.Append(prestatieid.ToString());

			sb.Append("|");

			if (aanvang != null)
			{
				sb.Append(aanvang_ConvertToString(aanvang));
			}
			sb.Append("|");

			if (duur.HasValue)
			{
				sb.Append(duur.ToString());
			}
			sb.Append("|");

			sb.Append(opdrachtid.ToString());

			sb.Append("|");

			sb.Append(prestatiesoortid.ToString());

			sb.Append("|");

			return sb.ToString();
		}
	}
}