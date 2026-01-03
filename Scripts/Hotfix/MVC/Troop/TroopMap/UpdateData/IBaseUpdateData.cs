using PureMVC.Interfaces;

namespace Hotfix
{
    // id 为obectid
    public interface IBaseUpdateData
    {
        void UpdateAttackTargetId(int id, int targetId);
        void UpdateMovePath(INotification data);
        void UpdateHp(int id, int hp);
        void UpdateBuff(int id, object buff);
        void ClearMovePath(int id);
    }
}