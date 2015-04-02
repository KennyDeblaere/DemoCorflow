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
	[Table("Contactpersoon")]
	public class Contactpersoon : BaseModel
	{
		public Contactpersoon()
		{
			//Don't fire notfications by default, since
			//they make editing the properties difficult.
			this.NotifyIfPropertiesChange = false;
		}


		[PrimaryKey]
        [NotNull]
		[Column("persoonid")]
		public int persoonid 
		{ 
			get { return persoonid_private; }
			set { SetProperty(persoonid_private, value, (val) => { persoonid_private = val; }, persoonid_PropertyName); }
		}
		public static string persoonid_PropertyName = "persoonid";
		private int persoonid_private;
		
		


        [NotNull]
		[Column("email")]
		public string email 
		{ 
			get { return email_private; }
			set { SetProperty(email_private, value, (val) => { email_private = val; }, email_PropertyName); }
		}
		public static string email_PropertyName = "email";
		private string email_private;
		
		



		[Column("fax")]
		public string fax 
		{ 
			get { return fax_private; }
			set { SetProperty(fax_private, value, (val) => { fax_private = val; }, fax_PropertyName); }
		}
		public static string fax_PropertyName = "fax";
		private string fax_private;
		
		


        [NotNull]
		[Column("gsm")]
		public string gsm 
		{ 
			get { return gsm_private; }
			set { SetProperty(gsm_private, value, (val) => { gsm_private = val; }, gsm_PropertyName); }
		}
		public static string gsm_PropertyName = "gsm";
		private string gsm_private;
		
		


        [NotNull]
		[Column("telefoonwerk")]
		public string telefoonwerk 
		{ 
			get { return telefoonwerk_private; }
			set { SetProperty(telefoonwerk_private, value, (val) => { telefoonwerk_private = val; }, telefoonwerk_PropertyName); }
		}
		public static string telefoonwerk_PropertyName = "telefoonwerk";
		private string telefoonwerk_private;
		
		



		[Column("telefoonprive")]
		public string telefoonprive 
		{ 
			get { return telefoonprive_private; }
			set { SetProperty(telefoonprive_private, value, (val) => { telefoonprive_private = val; }, telefoonprive_PropertyName); }
		}
		public static string telefoonprive_PropertyName = "telefoonprive";
		private string telefoonprive_private;
		
		


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
		[Column("familienaam")]
		public string familienaam 
		{ 
			get { return familienaam_private; }
			set { SetProperty(familienaam_private, value, (val) => { familienaam_private = val; }, familienaam_PropertyName); }
		}
		public static string familienaam_PropertyName = "familienaam";
		private string familienaam_private;
		
		


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

			sb.Append(persoonid.ToString());

			sb.Append("|");

			sb.Append(email.ToString());

			sb.Append("|");

			if (fax != null)
			{
				sb.Append(fax.ToString());
			}
			sb.Append("|");

			sb.Append(gsm.ToString());

			sb.Append("|");

			sb.Append(telefoonwerk.ToString());

			sb.Append("|");

			if (telefoonprive != null)
			{
				sb.Append(telefoonprive.ToString());
			}
			sb.Append("|");

			sb.Append(voornaam.ToString());

			sb.Append("|");

			sb.Append(familienaam.ToString());

			sb.Append("|");

			sb.Append(actief.ToString());

			sb.Append("|");

			return sb.ToString();
		}
	}
}