using System.Runtime.InteropServices;
using System.Text;

namespace VarispeedDemo.SoundTouch
{
    class SoundTouch : IDisposable
    {
        private IntPtr _handler;
        private string? versionString;
        private readonly bool is64Bit;
        public SoundTouch()
        {
            is64Bit = Marshal.SizeOf<IntPtr>() == 8;

            _handler = is64Bit ? SoundTouchInterop64.soundtouch_createInstance() :
                SoundTouchInterop32.soundtouch_createInstance();
        }

        public string VersionString
        {
            get
            {
                if (versionString is null)
                {
                    var s = new StringBuilder(100);
                    if (is64Bit)
                        SoundTouchInterop64.soundtouch_getVersionString2(s, s.Capacity);
                    else
                        SoundTouchInterop32.soundtouch_getVersionString2(s, s.Capacity);
                    versionString = s.ToString();
                }
                return versionString;
            }
        }

        public void SetPitchOctaves(float pitchOctaves)
        {
            if (is64Bit)
                SoundTouchInterop64.soundtouch_setPitchOctaves(_handler, pitchOctaves);
            else
                SoundTouchInterop32.soundtouch_setPitchOctaves(_handler, pitchOctaves);
        }

        public void SetSampleRate(int sampleRate)
        {
            if (is64Bit)
                SoundTouchInterop64.soundtouch_setSampleRate(_handler, (uint) sampleRate);
            else 
                SoundTouchInterop32.soundtouch_setSampleRate(_handler, (uint)sampleRate);
        }

        public void SetChannels(int channels)
        {
            if (is64Bit)
                SoundTouchInterop64.soundtouch_setChannels(_handler, (uint) channels);
            else
                SoundTouchInterop32.soundtouch_setChannels(_handler, (uint)channels);
        }

        private void DestroyInstance()
        {
            if (_handler != IntPtr.Zero)
            {
                if (is64Bit)
                    SoundTouchInterop64.soundtouch_destroyInstance(_handler);
                else
                    SoundTouchInterop32.soundtouch_destroyInstance(_handler);
                _handler = IntPtr.Zero;
            }
        }

        public void Dispose()
        {
            DestroyInstance();
            GC.SuppressFinalize(this);
        }

        ~SoundTouch()
        {
            DestroyInstance();
        }

        public void PutSamples(float[] samples, int numSamples)
        {
            if (is64Bit)
                SoundTouchInterop64.soundtouch_putSamples(_handler, samples, numSamples);
            else
                SoundTouchInterop32.soundtouch_putSamples(_handler, samples, numSamples);
        }

        public int ReceiveSamples(float[] outBuffer, int maxSamples)
        {
            if (is64Bit)
                return (int)SoundTouchInterop64.soundtouch_receiveSamples(_handler, outBuffer, (uint)maxSamples);
            return (int)SoundTouchInterop32.soundtouch_receiveSamples(_handler, outBuffer, (uint)maxSamples);
        }

        public bool IsEmpty
        {
            get
            {
                if (is64Bit)
                    return SoundTouchInterop64.soundtouch_isEmpty(_handler) != 0;
                return SoundTouchInterop32.soundtouch_isEmpty(_handler) != 0;
            }
        }

        public int NumberOfSamplesAvailable
        {
            get
            {
                if (is64Bit)
                   return (int)SoundTouchInterop64.soundtouch_numSamples(_handler);
                return (int)SoundTouchInterop32.soundtouch_numSamples(_handler);
            }
        }

        public int NumberOfUnprocessedSamples
        {
            get
            {
                if (is64Bit)
                    return SoundTouchInterop64.soundtouch_numUnprocessedSamples(_handler);
                return SoundTouchInterop32.soundtouch_numUnprocessedSamples(_handler);
            }
        }

        public void Flush()
        {
            if (is64Bit)
                SoundTouchInterop64.soundtouch_flush(_handler);
            else
                SoundTouchInterop32.soundtouch_flush(_handler);
        }

        public void Clear()
        {
            if (is64Bit)
                SoundTouchInterop64.soundtouch_clear(_handler);
            else
                SoundTouchInterop32.soundtouch_clear(_handler);
        }

        public void SetRate(float newRate)
        {
            if (is64Bit)
                SoundTouchInterop64.soundtouch_setRate(_handler, newRate);
            else
                SoundTouchInterop32.soundtouch_setRate(_handler, newRate);
        }

        public void SetTempo(float newTempo)
        {
            if (is64Bit)
                SoundTouchInterop64.soundtouch_setTempo(_handler, newTempo);
            else
                SoundTouchInterop32.soundtouch_setTempo(_handler, newTempo);
        }

        public int GetUseAntiAliasing()
        {
            if (is64Bit)
                return SoundTouchInterop64.soundtouch_getSetting(_handler, SoundTouchSettings.UseAaFilter);
            return SoundTouchInterop32.soundtouch_getSetting(_handler, SoundTouchSettings.UseAaFilter);
        }

        public void SetUseAntiAliasing(bool useAntiAliasing)
        {
            if (is64Bit)
                SoundTouchInterop64.soundtouch_setSetting(_handler, SoundTouchSettings.UseAaFilter, useAntiAliasing ? 1 : 0);
            else
                SoundTouchInterop32.soundtouch_setSetting(_handler, SoundTouchSettings.UseAaFilter, useAntiAliasing ? 1 : 0);
        }

        public void SetUseQuickSeek(bool useQuickSeek)
        {
            if (is64Bit)
                SoundTouchInterop64.soundtouch_setSetting(_handler, SoundTouchSettings.UseQuickSeek, useQuickSeek ? 1 : 0);
            else
                SoundTouchInterop32.soundtouch_setSetting(_handler, SoundTouchSettings.UseQuickSeek, useQuickSeek ? 1 : 0);
        }

        public int GetUseQuickSeek()
        {
            if (is64Bit)
                return SoundTouchInterop64.soundtouch_getSetting(_handler, SoundTouchSettings.UseQuickSeek);
            return SoundTouchInterop32.soundtouch_getSetting(_handler, SoundTouchSettings.UseQuickSeek);
        }
    }
}
