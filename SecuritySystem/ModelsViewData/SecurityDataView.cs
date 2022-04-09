using SecurityDataModel;

namespace SecuritySystem.ModelsViewData
{
    public class SecurityDataView
    {
        public SecurityData SecurityData { get; set; }
        public List<StoresData> StoresDatas { get; set; }
        public List<OfficerData> OfficerDatas { get; set; }
    }
}
