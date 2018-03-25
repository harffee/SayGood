using SayGood.Controllers;
using System.Linq;

namespace SayGood.Abstract
{
    public interface IAccountRepo
    {
        //获取数据库中的实体
        //使用IQueryable<T>接口获取相应对象而不必说明数据如何存储，存储在哪里，
        //以及如何接收数据，使用这一接口的类，可以获取相应对象而不必知道他们来自哪里或
        //如何递交他们，这是存储库模式的本质
        IQueryable<Account> Accounts { get; }
        IQueryable<Detail> Details { get; }
    }
}
