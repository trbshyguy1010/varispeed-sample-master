using NAudio.Wave;
using NAudio.WaveFormRenderer;

namespace VarispeedDemo.e
{
    public class Waveform
    {
        public async Task<Image> SetWave(string audioFilePath)
        {
            var maxPeakProvider = new MaxPeakProvider();
            var rmsPeakProvider = new RmsPeakProvider(200); // e.g. 200
            var samplingPeakProvider = new SamplingPeakProvider(200); // e.g. 200
            var averagePeakProvider = new AveragePeakProvider(4); // e.g. 4
            var myRendererSettings = new StandardWaveFormRendererSettings();
            myRendererSettings.Width = 682;
            myRendererSettings.DecibelScale = false;
            myRendererSettings.TopHeight = 50;
            myRendererSettings.BottomHeight = 40;
            myRendererSettings.TopPeakPen = Pens.Green;
            myRendererSettings.BottomPeakPen = Pens.YellowGreen;
            var renderer = new WaveFormRenderer();

            using (WaveStream waveStream = WaveFormatConversionStream.CreatePcmStream(new Mp3FileReader(audioFilePath)))
                return await Task.Run(() => { return renderer.Render(waveStream, myRendererSettings); });
        }
    }
}
