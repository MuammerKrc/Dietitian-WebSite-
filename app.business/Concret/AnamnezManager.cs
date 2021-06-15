using System.Threading.Tasks;
using app.business.Abstract;
using app.data.Abstract;
using app.data.Concret;
using app.entity;

namespace app.business.Concret
{
    public class AnamnezManager : IAnamnezFormService
    {
        private IUnitOfWork work;
        public AnamnezManager(IUnitOfWork _work)
        {
            work = _work;
        }
        public Task<OprationResult> CreateAsync(AnamnezForm entity)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ReturnedClass<AnamnezForm>> CreateWithRuturned(AnamnezForm anamnez)
        {
            try
            {
                if (anamnez == null)
                {
                    return new ReturnedClass<AnamnezForm>(OprationResult.canceled);
                }
                var result = await work.AnamnezForm.CreateWithRuturned(anamnez);

                if (!ManagerHelper.OperationControl(result.oprationResult))
                {
                    result.oprationResult = OprationResult.canceled;
                    return result;
                }

                var SaveResult = await work.SaveAsync();
                if (!ManagerHelper.OperationControl(SaveResult))
                {
                    result.oprationResult = OprationResult.canceled;
                    return result;
                }

                result.oprationResult = OprationResult.ok;
                return result;
            }
            catch (System.Exception)
            {
                return new ReturnedClass<AnamnezForm>(OprationResult.canceled);
            }
        }

        public OprationResult DeleteAsync(AnamnezForm entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<ReturnedClass<AnamnezForm>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<ReturnedClass<AnamnezForm>> GetByEntityAsync(AnamnezForm entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<ReturnedClass<AnamnezForm>> GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }


        public async Task<OprationResult> UpdateAsync(AnamnezForm entity)
        {
            try
            {
                var DataResult = work.AnamnezForm.UpdateAsync(entity);
                if (!ManagerHelper.OperationControl(DataResult))
                {
                    return OprationResult.canceled;
                }
                var SaveResult = await work.SaveAsync();
                if (!ManagerHelper.OperationControl(SaveResult))
                {
                    return OprationResult.canceled;
                }
                return OprationResult.ok;
            }
            catch (System.Exception)
            {
                return OprationResult.canceled;
            }
        }
    }
}