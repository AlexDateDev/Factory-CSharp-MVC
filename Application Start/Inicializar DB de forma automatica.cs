//// ----------------------------------------------------------------------------
//// Título:    Inicializar DB de forma automatica
////
//// Fecha:     11/12/2013
//// Autor:    Alex Solé
//// ----------------------------------------------------------------------------

using Entities;
using System;
using System.Data.Entity;

// --------------------------------------
// OK
// Global.asax.cs
// --------------------------------------

namespace Web.Controllers
{

	/**
		CreateDatabaseIfNotExists: 
			This is default initializer. As the name suggests, it will create the database if none exists as per the configuration. However, if you change the model class and then run the application with this initializer, then it will throw an exception.
		DropCreateDatabaseIfModelChanges: 
			This initializer drops an existing database and creates a new database, if your model classes (entity classes) have been changed. So you don't have to worry about maintaining your database schema, when your model classes change.
		DropCreateDatabaseAlways: 
			As the name suggests, this initializer drops an existing database every time you run the application, irrespective of whether your model classes have changed or not. This will be useful, when you want fresh database, every time you run the application, like while you are developing the application.
		Custom DB Initializer: 
			You can also create your own custom initializer, if any of the above doesn't satisfy your requirements or you want to do some other process that initializes the database using the above initializer.
	*/


	/// <summary>
	/// Se elimina y se crear de forma automática
	/// </summary>
	public class FactoryDTTDbInitializer : DropCreateDatabaseAlways<FactoryDTTEntities>
	{
		/// <summary>
		/// DB no se elimina, sólo se sobreescriben los datos con los de la semilla
		/// </summary>
		/// <param name="context"></param>
		protected override void Seed( FactoryDTTEntities context )
		{
			context.CRUD.Add( new CRUD
			{
				ID= 0,
				Altura = 1,
				Edat = 11,
				Nombre = "Nombre1",
				Direccion = "Direccion1",
				Fecha = DateTime.Now
			} );

			context.CRUD.Add( new CRUD
			{
				ID = 0,
				Altura = 2,
				Edat = 22,
				Nombre = "Nombre2",
				Direccion = "Direccion2",
				Fecha = DateTime.Now
			} );

			context.CRUD.Add( new CRUD
			{
				ID = 0,
				Altura = 3,
				Edat = 33,
				Nombre = "Nombre3",
				Direccion = "Direccion3",
				Fecha = DateTime.Now
			} );

			context.CRUD.Add( new CRUD
			{
				ID = 0,
				Altura = 4,
				Edat = 44,
				Nombre = "Nombre4",
				Direccion = "Direccion4",
				Fecha = DateTime.Now
			} );

			// Sobreescribimos los datos de la semilla
			base.Seed( context );

		}
	}
}