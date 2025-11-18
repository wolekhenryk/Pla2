using Pla2.Domain.Entities.Base;

namespace Pla2.Domain.Entities;

public class Address : BasicDbEntity
{
    public string Street { get; set; }
    public string City { get; set; }
    public string PostalCode { get; set; }
}