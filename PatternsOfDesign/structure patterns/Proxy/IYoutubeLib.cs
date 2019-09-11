using System.Collections.Generic;

namespace PatternsOfDesign.structure_patterns.Proxy
{
    interface IYoutubeLib
    {
        List<CachedYoutubeClass> ListVideos();
        object GetVideoInfo(int id);
        object DownloadVideo(int id);
    }
}
