//// ----------------------------------------------------------------------------
//// T�tulo:    ApplyCurrentValues
////
//// Fecha:     02/03/2013
//// Autor:    Alex Sol�
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
//            //TODO: Gesti�n de excepciones. De momento se sube a las capas superiores la excepci�n.
//            throw new Exception(dbEx.Message);
//        }
//        finally
//        {
//            context.Dispose();
//        }
//    }
//}
