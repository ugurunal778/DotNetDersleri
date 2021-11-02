using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Dto;
using WcfService;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class WcfService : BaseWcfService, IWcfService
    {
        
        #region Content
        public void CreateContent(int catId, string title, string desc, string fileTitle, string fileUrl, string imageUrl) => ContentFacade.CreateContent(catId, title, desc, fileTitle, fileUrl, imageUrl);

        public bool DeleteItemContent(int contentId) => ContentFacade.DeleteItemContent(contentId);

        public IList<ContentDto> GetAllByCategoryIdContent(int catId, bool? isActive) => ContentFacade.GetAllByCategoryIdContent(catId, isActive);

        public ContentBannerDto GetBannerLocaleByContentIdContent(int id) => ContentFacade.GetBannerLocaleByContentIdContent(id);

        public ContentBannerDto GetBannerLocaleByIdContent(int id) => ContentFacade.GetBannerLocaleByIdContent(id);

        public IList<ContentBannerDto> GetBannerLocalesByIdContent(int id) => ContentFacade.GetBannerLocalesByIdContent(id);

        public ContentDto GetLocaleByIdContent(int id) => ContentFacade.GetLocaleByIdContent(id);

        public IList<ContentDto> GetLocalesByContentIdContent(int contentId) => ContentFacade.GetLocalesByContentIdContent(contentId);

        public int GetMaxOrderContent(int catId) => ContentFacade.GetMaxOrderContent(catId);

        public void UpdateActiveContent(int contentId) => ContentFacade.UpdateActiveContent(contentId);

        public void UpdateBannerContent(int id, string imageUrl) => ContentFacade.UpdateBannerContent(id, imageUrl);

        public void UpdateContent(int id, string title, string content, string fileTitle, string fileUrl, string imageUrl) => ContentFacade.UpdateContent(id, title, content, fileTitle, fileUrl, imageUrl);

        public bool UpdateOrderContent(int contentId, bool isDown) => ContentFacade.UpdateOrderContent(contentId, isDown);

        #endregion


        #region News
        public void CreateImageNews(int newsId, string imageUrl) => NewsFacade.CreateImageNews(newsId, imageUrl);

        public void CreateNews(string title, string content, DateTime date) => NewsFacade.CreateNews(title, content, date);

        public bool DeleteImageNews(int imageId) => NewsFacade.DeleteImageNews(imageId);

        public bool DeleteItemNews(int newsId) => NewsFacade.DeleteItemNews(newsId);

        public IList<NewsImageDto> GetAllImagesNews() => NewsFacade.GetAllImagesNews();

        public IList<NewsDto> GetAllNews(bool? isActive) => NewsFacade.GetAllNews(isActive);

        public NewsDto GetByIdNews(int id, bool? isActive) => NewsFacade.GetByIdNews(id, isActive);

        public NewsImageDto GetImageByIdNews(int id) => NewsFacade.GetImageByIdNews(id);

        public IList<NewsImageDto> GetImagesByIdNews(int id) => NewsFacade.GetImagesByIdNews(id);

        public NewsDto GetLocaleByIdNews(int id) => NewsFacade.GetLocaleByIdNews(id);

        public IList<NewsDto> GetLocalesByIdNews(int id) => NewsFacade.GetLocalesByIdNews(id);

        public int GetMaxOrderNews() => NewsFacade.GetMaxOrderNews();

        public void UpdateActiveNews(int newsId) => NewsFacade.UpdateActiveNews(newsId);

        public void UpdateImageNews(int id, string imageUrl) => NewsFacade.UpdateImageNews(id, imageUrl);

        public void UpdateNews(int id, string title, string content, DateTime date) => NewsFacade.UpdateNews(id, title, content, date);

        public bool UpdateOrderNews(int newsId, bool isDown) => NewsFacade.UpdateOrderNews(newsId, isDown);

        #endregion


        #region Page
        public void CreateFilePage(int pageId, string fileUrl, string title) => pageFacade.CreateFilePage(pageId, fileUrl, title);

        public void CreatePage(int parentId, string title, string content, string imageUrl) => pageFacade.CreatePage(parentId, title, content, imageUrl);

        public bool DeleteFilePage(int fileId) => pageFacade.DeleteFilePage(fileId);

        public bool DeleteItemPage(int pageId) => pageFacade.DeleteItemPage(pageId);

        public IList<PageDto> GetAllByParentIdPage(int parentId, bool? isActive) => pageFacade.GetAllByParentIdPage(parentId, isActive);

        public PageDto GetByIdPage(int id) => pageFacade.GetByIdPage(id);

        public PageDto GetByPermalinkPage(string permalink) => pageFacade.GetByPermalinkPage(permalink);

        public PageFileDto GetFileLocaleByIdPage(int id) => pageFacade.GetFileLocaleByIdPage(id);

        public IList<PageFileDto> GetFileLocalesByIdPage(int fileId) => pageFacade.GetFileLocalesByIdPage(fileId);

        public IList<PageFileDto> GetFilesByIdPage(int pageId) => pageFacade.GetFilesByIdPage(pageId);

        public PageDto GetFirstByParentIdPage(int parentId) => pageFacade.GetFirstByParentIdPage(parentId);

        public PageDto GetLocaleByIdPage(int id) => pageFacade.GetLocaleByIdPage(id);

        public IList<PageDto> GetLocalesByPageIdPage(int pageId) => pageFacade.GetLocalesByPageIdPage(pageId);

        public int GetMaxFileOrderPage(int pageId) => pageFacade.GetMaxFileOrderPage(pageId);

        public int GetMaxOrderPage(int parentId) => pageFacade.GetMaxOrderPage(parentId);

        public string GetOtherCulturePermalinkPage(string permalink) => pageFacade.GetOtherCulturePermalinkPage(permalink);

        public IList<PageDto> GetPageLinksByParentIdPage(int parentId, bool? isActive) => pageFacade.GetPageLinksByParentIdPage(parentId, isActive);

        public bool HasSubLinksPage(int parentId) => pageFacade.HasSubLinksPage(parentId);

        public List<PageDto> GetProductsPage(bool isDurer) => pageFacade.GetProductsPage(isDurer);

        public string RemoveAccentPage(string txt) => pageFacade.RemoveAccentPage(txt);

        public void UpdateActivePage(int pageId) => pageFacade.UpdateActivePage(pageId);

        public bool UpdateFileOrderPage(int fileId, bool isDown) => pageFacade.UpdateFileOrderPage(fileId, isDown);

        public void UpdateFilePage(int id, string fileUrl, string title) => pageFacade.UpdateFilePage(id, fileUrl, title);

        public bool UpdateOrderPage(int pageId, bool isDown) => pageFacade.UpdateOrderPage(pageId, isDown);

        public void UpdatePage(int id, string title, string content, string imageUrl) => pageFacade.UpdatePage(id, title, content, imageUrl);

        #endregion


        public bool CheckLoginUser(string username, string pass) => UserFacade.CheckLoginUser(username, pass);

        public void SendMail(string body, string fullName, string title) => MailFacade.SendMail(body, fullName, title);
    }
}
