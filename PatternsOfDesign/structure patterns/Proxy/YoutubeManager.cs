using System.Collections.Generic;

namespace PatternsOfDesign.structure_patterns.Proxy
{
    class YoutubeManager
    {
        private IYoutubeLib _service;
        private List<CachedYoutubeClass> _list;
        public YoutubeManager(IYoutubeLib service)
        {
            _service = service;
        }

        public object RenderVideoPage(int id)
        {
            var info = _service.GetVideoInfo(id);
            return info;
        }

        public void RenderListPanel()
        {
            _list = _service.ListVideos();
        }

        public void ReactOnUserInput(int videoInfoId)
        {
            RenderVideoPage(videoInfoId);
            RenderListPanel();
        }

        public List<CachedYoutubeClass> GetList => _list;

    }
}
