namespace Docflow.Application.Services.Communicators;

public static class CommunicatorHelper
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
