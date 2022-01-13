using Abp.Domain.Entities.Auditing;

namespace fengye.bookList.BookListManagement
{
    /// <summary>
    /// 书籍(CreationAuditedEntity)
    /// IHasCreationTime, IHasModificationTime, ICreationAudited<long>, IModificationAudited<long>, IDeletionAudited
    /// </summary>
    public class Book : CreationAuditedEntity<long>
    {
        /// <summary>
        /// 书名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        ///简介
        /// </summary>
        public string Intro { get; set; }

        /// <summary>
        /// 购买链接
        /// </summary>
        public string PriceUrl { get; set; }

        /// <summary>
        /// 封面名字
        /// </summary>
        public string ImgStrUrl { get; set; }
    }
}
