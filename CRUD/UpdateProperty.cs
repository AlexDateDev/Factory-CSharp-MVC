//// ----------------------------------------------------------------------------
//// Título:    Create
////
//// Fecha:     02/03/2013
//// Autor:    Alex Solé
//// ----------------------------------------------------------------------------


using Entities;
using System;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Linq;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;

namespace HelperMVC
{

	/// <summary>
	/// Helper CRUD
	/// </summary>
	public partial class HelperCRUD
	{

		/// <summary>
		/// CRUD Update EF 6.0 de una sola propiedad del objeto
		/// </summary>
		/// <returns></returns>
		public static bool UpateProperty( )
		{
			try {
				using( FactoryDTTEntities db = new FactoryDTTEntities( ) ) {

					CRUD oCrud = db.CRUD.FirstOrDefault( p => p.ID == 2 );
					oCrud.Direccion = "Dirección update property";

					ObjectContext dbObjectContext = ( (IObjectContextAdapter) db ).ObjectContext;

					dbObjectContext.ObjectStateManager.GetObjectStateEntry( oCrud ).SetModifiedProperty("Direccion");
					dbObjectContext.SaveChanges();

				}
			} catch( EntityException dbEx ) {
				throw new Exception( dbEx.Message );

			} catch( Exception ex ) {
				throw new Exception( ex.Message );

			} finally {

			}
			return true;
		}
	}

}
