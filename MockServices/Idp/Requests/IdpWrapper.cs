using MockServices.Idp.Entities;

namespace MockServices.Idp.Requests
{
    public class IdpWrapper
    {
        private readonly IIdp _idp;
        
        public IdpWrapper(IIdp idp)
        {
            _idp = idp;
        }

        public IdpModel Get()
        {
            var response = _idp.Get();
            return response.Result;
        }
    }
}