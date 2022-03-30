using BusinessLogic.Core;
using Data;
using Data.Entities;
using Presentation;
using Presentation.View;

namespace BusinessLogic.Commands
{
    class SavePayment
    {
        public void Execute()
        {
            InputData data = new SavePaymentView().RequestData();
            Consumption entity = new Consumption();
            entity.MemberID = int.Parse(data.fields["CodigoSocio"]);
            entity.Paid = true;
            new ConsumptionRepository().Save(entity);
        }
    }
}
