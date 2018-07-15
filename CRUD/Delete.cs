//// ----------------------------------------------------------------------------
//// Título:    Delete
////
//// Fecha:     02/03/2013
//// Autor:    Alex Solé
//// ----------------------------------------------------------------------------

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
		/// CRUD Delete EF 6.0
		/// </summary>
		/// <returns></returns>
		public static bool Delete( )
		{
			try {
				using( FactoryDTTEntities db = new FactoryDTTEntities( ) ) {

					CRUD oCrud = db.CRUD.FirstOrDefault( p => p.ID == 1 );
					
					db.CRUD.Remove( oCrud );
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

//public void Delete(int id)
//{
//    try{
//        GridTable obj = this.db.GridTable.FirstOrDefault(p => p.id == id);
//        this.db.GridTable.DeleteObject(obj);
//        this.db.SaveChanges();
//    }
//    catch (EntityException dbEx){
//         throw new Exception(dbEx.Message);
//    }
//    finally {
//        }
//}werw

