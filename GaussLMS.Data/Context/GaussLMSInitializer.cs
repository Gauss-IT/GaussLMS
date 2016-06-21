using System.Collections.Generic;
using System.Data.Entity;
using GaussLMS.Data.Madrasah;


namespace GaussLMS.Data.Context
{
    class GaussLMSInitializer : CreateDatabaseIfNotExists<GaussLMSDBContext>
    {
            protected override void Seed(GaussLMSDBContext context)
            {
                var personalInformations = new List<PersonalInformation>{
                new PersonalInformation {  },
                new PersonalInformation {  },
                new PersonalInformation { },
            };

                personalInformations.ForEach(category => context.PersonalInformations.Add(category));
            }
    }
}
