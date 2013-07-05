using System;
using System.IO;
using System.Reflection;

using Xwt;
using Xwt.Drawing;
using NPlot;

namespace Samples
{
	public class PlotSample : VBox
	{
		protected PlotCanvas plotCanvas;
		protected string infoText = "";

		public PlotSample()
		{
			plotCanvas = new PlotCanvas ();

			// Set defaults for the sample plotCanvas
			plotCanvas.AutoScaleAutoGeneratedAxes = false;
			plotCanvas.AutoScaleTitle = false;
			plotCanvas.Legend = null;
			plotCanvas.Canvas.Name = "plotCanvas";
			plotCanvas.Title = "";
			plotCanvas.TitleFont = Font.FromName ("Ubuntu 14");

		}

	}
}

