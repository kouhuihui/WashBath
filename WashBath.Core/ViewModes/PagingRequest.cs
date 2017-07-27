namespace WashBath.Core.ViewModes
{
    public class PagingRequest
    {
        public PagingRequest()
        {

        }

        public int PageIndex { get; set; }

        public int PageSize { get; set; }

        public int Start
        {
            get
            {
                if (PageIndex > 0)
                    return PageSize * (PageIndex - 1);
                return 0;
            }
        }
    }
}
