using Microsoft.Maui.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXingFormat = ZXing.BarcodeFormat;

namespace ZXing.Net.Maui
{
	public record BarcodeResult
	{
		public byte[] Raw { get; set; }

		public string Value { get; set; }

		public BarcodeFormat Format { get; set; }

		public IReadOnlyDictionary<MetadataType, object> Metadata { get; set; }

		public PointF[] PointsOfInterest { get; set; }
	}
}
