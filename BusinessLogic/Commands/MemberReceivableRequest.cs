using BusinessLogic.Core;
using Data;
using Data.Entities;
using Presentation;
using Presentation.View;
using System.Collections.Generic;
using System;

namespace BusinessLogic.Commands
{
    public class MemberReceivableRequest: IWaterCommand
    {
        double WaterPrice = 8.5;
        public void Execute()
        {
            MemberRepository memberRepository = new MemberRepository();
            ConsumptionRepository consuptionRepositroy = new ConsumptionRepository();
            UserReceivableView view = new UserReceivableView();
            InputData data = view.RequestData();
            Member entity = new Member();
            if (memberRepository.GetMember(int.Parse(data.fields["CodigoSocio"])) != null)
            {
                entity = memberRepository.GetMember(int.Parse(data.fields["CodigoSocio"]));
            }
            else
            {
                entity.ID = int.Parse(data.fields["CodigoSocio"]);
            }

            List<Consumption> memberConsumptions = new ConsumptionRepository().GetConsumptionByMember(entity);

            int memberCode = entity.ID;
            string memberName = entity.FirstName + " " + entity.SecondName;
            int totalBuckets = consuptionRepositroy.GetConsumptionByMember(entity).Count;
            double amountDebt = this.CalculateTotalReceivable(memberConsumptions);

            view.ShowResult(memberCode, memberName, totalBuckets, amountDebt);
        }

        private double CalculateTotalReceivable(List<Consumption> memberConsumptions)
        {
            double total = 0;
            foreach(Consumption item in memberConsumptions)
            {
                if (item.Paid == false)
                {
                    total += item.Value * WaterPrice;
                }
            }
            return total;
        }
    }
}
