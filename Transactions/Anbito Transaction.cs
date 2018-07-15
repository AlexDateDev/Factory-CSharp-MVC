//// ----------------------------------------------------------------------------
//// Título:    Anbito Transaction
////
//// Fecha:     02/03/2013
//// Autor:    Alex Solé
//// ----------------------------------------------------------------------------
//public void SaveNewsletter(Newsletter newsletter)
//{
//    if (newsletter == null)
//        throw new NullReferenceException("Item null");

//    _newsletterRepository.Add(newsletter);

//    using (TransactionScope trans = new TransactionScope()    )
//    {
//        try
//        {
//            _newsletterRepository.UnitOfWork.CommitAndRefreshChanges();
//            trans.Complete();
//        }
//        catch (Exception ex)
//        {
//            throw ex;
//        }
//        finally
//        {
//            trans.Dispose();
//        }
//    }
//}
