//// ----------------------------------------------------------------------------
//// Título:    Create
////
//// Fecha:     02/03/2013
//// Autor:    Alex Solé
//// ----------------------------------------------------------------------------


using Entities;
using System;
using System.Data.Entity.Core;

namespace HelperMVC {

	/// <summary>
	/// Helper CRUD
	/// </summary>
	public partial class HelperCRUD {

		/// <summary>
		/// CRUD Create EF 6.0
		/// </summary>
		/// <returns></returns>
		public static bool Create( )
		{
			try {
				using( FactoryDTTEntities db = new FactoryDTTEntities( ) ) {

					CRUD oCrud = new CRUD( );
					oCrud.Nombre = "CrudCreate";
					oCrud.ID = 0;
					oCrud.Direccion = "Dirección create";
					oCrud.Altura = 123;
					oCrud.Edat = 10;
					oCrud.Fecha = DateTime.Now;

					db.CRUD.Add( oCrud );
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

