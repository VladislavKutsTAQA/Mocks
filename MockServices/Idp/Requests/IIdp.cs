using System.Threading.Tasks;
using MockServices.Idp.Entities;
using Refit;

namespace MockServices.Idp.Requests
{
    public interface IIdp
    {
        [Get("/content/34")]
        public Task<IdpModel> Get();
    }
}