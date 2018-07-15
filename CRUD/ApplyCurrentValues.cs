//// ----------------------------------------------------------------------------
//// Título:    ApplyCurrentValues
////
//// Fecha:     02/03/2013
//// Autor:    Alex Solé
//// ----------------------------------------------------------------------------

//public void Update(FormativeAction pEntity)
//{
//    using (WSigeDataModel context = new WSigeDataModel())
//    {
//        try
//        {
//            context.FormativeAction.Attach(pEntity);
//            context.ObjectStateManager.ChangeObjectState(pEntity, EntityState.Modified);
//            context.FormativeAction.ApplyCurrentValues(pEntity);
//            context.SaveChanges();

//        }
//        catch (EntityException dbEx)
//        {
//            //TODO: Gestión de excepciones. De momento se sube a las capas superiores la excepción.
//            throw new Exception(dbEx.Message);
//        }
//        finally
//        {
//            context.Dispose();
//        }
//    }
//}
