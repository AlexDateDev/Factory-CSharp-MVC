// ----------------------------------------------------------------------------
// Título:    Detach
//
// Fecha:     02/03/2013
// Autor:    Alex Solé
// ----------------------------------------------------------------------------

// Necesito el IdAlumn del user
//Alumn a = context.Alumn.SingleOrDefault( p => p.IdUser == pre.IdUser );
// Hemos de eliminar las relaciones RelacionAlumnGroup
//context.RelationAlumnGroup.Where( p => p.IdGroup == pre.IdGroup &&
//                                            p.IdAlumn == a.IdAlumn &&
//                                            p.YearAcademic == pre.YearAcademic ).ToList<RelationAlumnGroup>( )
//                                                                                .ForEach( r => context.RelationAlumnGroup.DeleteObject( r ) );

//pre.IdGroup = null;
//pre.Admitted = null;
//context.Detach( a );
//context.SaveChanges( );
