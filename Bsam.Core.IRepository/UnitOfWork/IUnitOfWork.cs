using SqlSugar;

namespace Bsam.Core.IRepository.UnitOfWork
{
    /// <summary>
    /// 操作单元：保证代码操作原子性提交
    /// </summary>
    public interface IUnitOfWork
    {
        SqlSugarClient GetDbClient();

        void BeginTran();

        void CommitTran();
        void RollbackTran();
    }
}
