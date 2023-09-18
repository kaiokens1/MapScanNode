using Blockcore.Networks;

namespace MapScan.Networks
{
   public static class Networks
   {
      public static NetworksSelector MapScan
      {
         get
         {
            return new NetworksSelector(() => new MapScanMain(), () => new MapScanTest(), () => new MapScanRegTest());
         }
      }
   }
}
