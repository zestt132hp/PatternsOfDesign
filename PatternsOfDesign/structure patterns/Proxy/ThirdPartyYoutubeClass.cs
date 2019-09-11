
using System.Collections.Generic;

namespace PatternsOfDesign.structure_patterns.Proxy
{
    class ThirdPartyYoutubeClass:IYoutubeLib
    {
        public List<CachedYoutubeClass> ListVideos()
        {
            throw new System.NotImplementedException();
        }

        public object GetVideoInfo(int id)
        {
            throw new System.NotImplementedException();
        }

        public object DownloadVideo(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
