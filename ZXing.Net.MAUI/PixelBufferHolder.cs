using Microsoft.Maui.Graphics;

namespace ZXing.Net.Maui.Readers
{
	public record PixelBufferHolder
	{
		public Size Size { get; set; }

		public

#if ANDROID
		Java.Nio.ByteBuffer
#elif IOS || MACCATALYST
		CoreVideo.CVPixelBuffer
#else
		byte[]
#endif

		Data { get; set; }
	}
}
