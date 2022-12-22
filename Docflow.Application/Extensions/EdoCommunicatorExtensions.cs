using Docflow.Domain.Models;

namespace Docflow.Application.Extensions;

internal static class EdoCommunicatorExtensions
{
    public static IEdoCommunicator FindOfEnum(this IEnumerable<IEdoCommunicator> source, EdoType type)
        => type switch
        {
            EdoType.Diadoc => source.OfType<DiadocCommunicator>().Single(),
            EdoType.Sbis => source.OfType<SbisCommunicator>().Single(),
            EdoType.Infotex => source.OfType<InfotexCommunicator>().Single(),
            _ => throw new InvalidOperationException()
        };
}
