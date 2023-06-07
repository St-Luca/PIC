using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIC
{
    internal class CatchingApplication
    {
        internal int Id { get; set; }
        internal DateTime RegistrationDate { get; set; }
        User User { get; set; }
        Locality LocalityOfCatching { get; set; }
        Locality LocalityOfLiving { get; set; }
        Animal Animal { get; set; }
        Organization OrderedOrganization { get; set; }
        List<string> AnimalDescription { get; set; }
        Organization JobOrganization { get; set; }
        DateTime Urgency { get; set; }

        public CatchingApplication() { } //потом удалить, нужен для первичной инфраструктуры
        public CatchingApplication(int id, DateTime registrationDate, User user, Locality localityOfCatching, Locality localityOfLiving,
                                   Animal animal, Organization orderedOrganization, DateTime urgency)
        { 
            Id = id;
            RegistrationDate = registrationDate;
            User = user;
            LocalityOfCatching = localityOfCatching;
            LocalityOfLiving = localityOfLiving;
            Animal = animal;
            AnimalDescription = Animal.GetDescription();
            OrderedOrganization = orderedOrganization;
            Urgency = urgency;
        }
    }
}
