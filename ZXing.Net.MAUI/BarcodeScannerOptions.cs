namespace ZXing.Net.Maui
{
	public record BarcodeReaderOptions

	{
		public bool AutoRotate { get; set; }
		public bool TryHarder { get; set; }

		public BarcodeFormat Formats { get; set; }

		public bool Multiple { get; set; }

	}
}
