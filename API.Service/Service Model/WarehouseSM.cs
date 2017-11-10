namespace API.Service.Service_Model
{
    public class WarehouseSM
    {
        public string DSTRCT_CODE { get; set; }
        public string DSTRCT_NAME { get; set; }
        public string DSTRCT_SUBURB { get; set; }
        public string DSTRCT_STATE { get; set; }
        public string WHOUSE_ID { get; set; }
        public double DSTRCT_LAT { get; set; }
        public double DSTRCT_LON { get; set; }
        public double? ErrorByValue { get; set; }
        public double? ErrorByVolume { get; set; }
    }
}
