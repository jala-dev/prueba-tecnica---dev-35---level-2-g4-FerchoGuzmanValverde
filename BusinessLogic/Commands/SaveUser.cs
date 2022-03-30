using BusinessLogic.Core;
using Data;
using Data.Entities;
using Presentation;
using Presentation.View;

namespace BusinessLogic.Commands
{
    class SaveUser
    {
        public void Execute()
        {
            InputData data = new SaveMemberView().RequestData();
            Member entity = new Member();
            entity.ID = int.Parse(data.fields["CodigoSocio"]);
            entity.FirstName = data.fields["PrimerNombre"];
            entity.SecondName = data.fields["SegundoNombre"];
            new MemberRepository().SaveMember(entity);
        }
    }
}
