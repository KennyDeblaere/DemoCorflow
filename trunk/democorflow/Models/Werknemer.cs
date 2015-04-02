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
	[Table("Werknemer")]
	public class Werknemer : BaseModel
	{
		public Werknemer()
		{
			//Don't fire notfications by default, since
			//they make editing the properties difficult.
			this.NotifyIfPropertiesChange = false;
		}


		[PrimaryKey]
        [NotNull]
		[Column("medewerkerid")]
		public int medewerkerid 
		{ 
			get { return medewerkerid_private; }
			set { SetProperty(medewerkerid_private, value, (val) => { medewerkerid_private = val; }, medewerkerid_PropertyName); }
		}
		public static string medewerkerid_PropertyName = "medewerkerid";
		private int medewerkerid_private;
		
		


        [NotNull]
		[Column("naam")]
		public string naam 
		{ 
			get { return naam_private; }
			set { SetProperty(naam_private, value, (val) => { naam_private = val; }, naam_PropertyName); }
		}
		public static string naam_PropertyName = "naam";
		private string naam_private;
		
		


        [NotNull]
		[Column("voornaam")]
		public string voornaam 
		{ 
			get { return voornaam_private; }
			set { SetProperty(voornaam_private, value, (val) => { voornaam_private = val; }, voornaam_PropertyName); }
		}
		public static string voornaam_PropertyName = "voornaam";
		private string voornaam_private;
		
		


        [NotNull]
		[Column("passwoord")]
		public string passwoord 
		{ 
			get { return passwoord_private; }
			set { SetProperty(passwoord_private, value, (val) => { passwoord_private = val; }, passwoord_PropertyName); }
		}
		public static string passwoord_PropertyName = "passwoord";
		private string passwoord_private;
		
		


        [NotNull]
		[Column("actief")]
		public bool actief 
		{ 
			get { return actief_private; }
			set { SetProperty(actief_private, value, (val) => { actief_private = val; }, actief_PropertyName); }
		}
		public static string actief_PropertyName = "actief";
		private bool actief_private;
		
		


		public override string ToString() 
		{
			StringBuilder sb = new StringBuilder();

			sb.Append(medewerkerid.ToString());

			sb.Append("|");

			sb.Append(naam.ToString());

			sb.Append("|");

			sb.Append(voornaam.ToString());

			sb.Append("|");

			sb.Append(passwoord.ToString());

			sb.Append("|");

			sb.Append(actief.ToString());

			sb.Append("|");

			return sb.ToString();
		}
	}
}