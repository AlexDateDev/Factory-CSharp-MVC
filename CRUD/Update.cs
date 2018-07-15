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

namespace HelperMVC
{

	/// <summary>
	/// Helper CRUD
	/// </summary>
	public partial class HelperCRUD
	{

		/// <summary>
		/// CRUD Update EF 6.0 de todo una entidad
		/// </summary>
		/// <returns></returns>
		public static bool Upate( )
		{
			try {
				using( FactoryDTTEntities db = new FactoryDTTEntities( ) ) {

					CRUD oCrud = db.CRUD.FirstOrDefault( p => p.ID == 1 );
					oCrud.Direccion = "Dirección updates";
					oCrud.Altura = 34;
					oCrud.Edat = 99;
					oCrud.Fecha = DateTime.Now;

					db.CRUD.Attach( oCrud );
					db.Entry( oCrud ).State = EntityState.Modified;
					db.SaveChanges( );
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
