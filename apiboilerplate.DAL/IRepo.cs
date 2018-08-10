using apiboilerplate.DAL.Models;

namespace apiboilerplate.DAL
{
    public interface IRepo
    {
        User GetOne(int Id);
    }
}