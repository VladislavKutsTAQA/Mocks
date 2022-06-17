using MockServices.Idp.Entities;
using MockServices.Idp.Requests;

namespace MockServices.Idp.Manager
{
    public class IdpManager
    {
        private IdpModel IdpModel;
        private readonly IIdp _idp;

        public IdpManager(IIdp idp)
        {
            _idp = idp;
        }

        public IdpModel GetModel()
        {
            if (IdpModel is null)
            {
                IdpModel = _idp.Get().Result;
            }
            
            var idpClone = IdpModel.Clone();
            IdpModel = null;

            return idpClone;
        }

        public void SetModel(IdpModel idpModel)
        {
            IdpModel = idpModel;
        }
    }
}