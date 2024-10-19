using NovelBloom.CustomTypes;

namespace NovelBloom.Utils;

internal class StateContainer
{
    public readonly AutoRemoveDictionary<int, object> ObjectTunnel =
        new AutoRemoveDictionary<int, object>();
}
