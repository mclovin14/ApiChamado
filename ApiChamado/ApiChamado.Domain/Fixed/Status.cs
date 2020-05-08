using System.Runtime.Serialization;

namespace ApiChamado.Domain.Fixed
{
    public enum Status
    {
        [EnumMember(Value = "d")]
        Disponível,
        [EnumMember(Value = "a")]
        Alugado
    }
}
