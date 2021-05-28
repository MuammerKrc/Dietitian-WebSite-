using System.Collections.Generic;
using app.entity;

namespace app.business.Concret
{
    public static class ManagerHelper
    {
        public static bool IdControlById(int id)
        {
            if (id <= 0)
            {
                return false;
            }
            return true;
        }

        public static bool IdControlByEntity<Y>(Y entity)where Y:BaseClass
        {
            if (entity.Id <= 0)
            {
                return false;
            }
            return true;
        }

        public static bool ValueControl<Y>(Y entity)where Y:BaseClass
        {
            if(entity==null)
            {
                return false;
            }
            else if(entity.Id<=0)
            {
                return false;
            }
            return true;
        }
        public static bool OperationControl(OprationResult result)
        {
            bool temp =false;
            switch (result)
            {
                case OprationResult.canceled:
                temp=false;
                break;
                case OprationResult.ineffective:
                temp= false;
                break;
                case OprationResult.InvalidId:
                temp= false;
                break;
                case OprationResult.NotFound:
                temp =false;
                break;
                case OprationResult.NotSaved:
                temp= false;
                break;
                case OprationResult.ok:
                temp =true;
                break;
                case OprationResult.Saved:
                temp= true;
                break;
                case OprationResult.successful:
                temp =true;
                break;
                default:
                temp =false;
                break;
            }
            return temp;
        }

        
    }
}