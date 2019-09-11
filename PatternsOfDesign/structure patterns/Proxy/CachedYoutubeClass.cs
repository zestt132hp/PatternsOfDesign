
using System.Collections.Generic;

namespace PatternsOfDesign.structure_patterns.Proxy
{
    class CachedYoutubeClass:IYoutubeLib
    {
        private readonly ThirdPartyYoutubeClass _service;
        private List<CachedYoutubeClass> _listCached;
        private object _videoList;
        private bool _needReset;
        public CachedYoutubeClass(ThirdPartyYoutubeClass service)
        {
            _service = service;
            _listCached = new List<CachedYoutubeClass>();
            _videoList = new List<object>();
        }
        public List<CachedYoutubeClass> ListVideos()
        {
            if (_needReset || _listCached.Count<1)
            {
                _listCached = _service.ListVideos();
            }

            return _listCached;
        }

        public object GetVideoInfo(int id)
        {
            if (_needReset || _videoList == null)
            {
                _videoList = _service.GetVideoInfo(id);
            }

            return _videoList;
        }

        public object DownloadVideo(int id)
        {
            return _service.DownloadVideo(id);
        }

        public void Reset() => _needReset = true;
    }
}
