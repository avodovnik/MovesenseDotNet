using Com.Movesense.Mds;
using MdsLibrary.Model;

namespace MdsLibrary.Api
{
    public class GetAccInfo : ApiCallAsync<AccInfo>
    {
        private static string ACC_INFO_PATH = "/Meas/Acc/Info";

        public GetAccInfo(bool? cancelled, string deviceName) :
            base(cancelled, deviceName)
        {
        }

        protected override void performCall(Mds mds, string serial, IMdsResponseListener responseListener)
        {
            mds.Get(Mdx.SCHEME_PREFIX + serial + ACC_INFO_PATH, null, responseListener);
        }
    }
}
