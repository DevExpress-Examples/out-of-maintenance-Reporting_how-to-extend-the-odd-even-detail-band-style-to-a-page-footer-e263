using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;

namespace StylingWithFillEmptySpace {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        int detailCount = 0;

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            detailCount++;
        }

        private void XtraReport1_FillEmptySpace(object sender, BandEventArgs e) {
            int labelsCount = Convert.ToInt32(e.Band.Height / this.dummyDetailBandLabel.Height);
            Size targetSize = new Size((this.PageWidth - this.Margins.Left - this.Margins.Right), e.Band.Height);
            Size labelSize = new Size(this.dummyDetailBandLabel.Width, this.dummyDetailBandLabel.Height);
            Size targetSizeInPixels = XRConvert.Convert(targetSize, GraphicsDpi.HundredthsOfAnInch, GraphicsDpi.Pixel);
            Size labelSizeInPixels = XRConvert.Convert(labelSize, GraphicsDpi.HundredthsOfAnInch, GraphicsDpi.Pixel);
            
            Bitmap targetBitmap = new Bitmap(targetSizeInPixels.Width, targetSizeInPixels.Height);
            Graphics gr = Graphics.FromImage(targetBitmap);
            Point pt = new Point(0, 0);
            Size sz = new Size(targetSizeInPixels.Width, labelSizeInPixels.Height);

            for(int i = 0; i < labelsCount; i++) {
                if(i % 2 == 0)
                    gr.FillRectangle(Brushes.LightBlue, new Rectangle(pt, sz));
                else
                    gr.FillRectangle(Brushes.Khaki, new Rectangle(pt, sz));

                pt.Y += labelSizeInPixels.Height;
            }

            XRPictureBox pictureBox = new XRPictureBox();
            pictureBox.BackColor = Color.Transparent;
            pictureBox.Size = targetSize;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Image = targetBitmap;
            e.Band.Controls.Add(pictureBox);
        }
    }
}
