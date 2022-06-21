using MockServices.Idp.Entities;
using MockServices.Idp.Requests;

namespace MockServices.Idp.Manager
{
    public class IdpManager
    {
        private IdpModel _idpModel;
        private readonly IIdp _idp;

        public IdpManager(IIdp idp)
        {
            _idp = idp;
        }

        public IdpModel GetModel()
        {
            if (_idpModel is null)
            {
                _idpModel = _idp.Get().Result;
            }
            
            var idpClone = _idpModel.Clone();
            _idpModel = null;

            return idpClone;
        }

        public void SetModel(IdpModel idpModel)
        {
            _idpModel = idpModel;
        }
    }
}