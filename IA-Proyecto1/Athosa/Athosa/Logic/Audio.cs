using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Audio Library
using NAudio.Wave;
using System.IO;
// Google API
//Install-Package Google.Cloud.Speech.V1 -Version 1.0.0-beta08 -Pre
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Speech.V1;
using Grpc.Auth;

namespace Athosa.Logic
{
    public class Audio
    {
        private BufferedWaveProvider bwp;

        WaveIn waveIn;
        WaveOut waveOut;
        WaveFileWriter writer;
        WaveFileReader reader;
        string output = "audio.raw";

        public Audio()
        {

            waveOut = new WaveOut();
            waveIn = new WaveIn();

            waveIn.DataAvailable += new EventHandler<WaveInEventArgs>(waveIn_DataAvailable);
            waveIn.WaveFormat = new NAudio.Wave.WaveFormat(16000, 1);
            bwp = new BufferedWaveProvider(waveIn.WaveFormat);
            bwp.DiscardOnBufferOverflow = true;
        }

        public void waveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            bwp.AddSamples(e.Buffer, 0, e.BytesRecorded);

        }

        public void wave(object sender, EventArgs e)
        {
            if (NAudio.Wave.WaveIn.DeviceCount < 1)
            {
                Console.WriteLine("No microphone!");
                return;
            }

            waveIn.StartRecording();
        }

        public void save(object sender, EventArgs e)
        {
            waveIn.StopRecording();

            if (File.Exists("audio.raw"))
                File.Delete("audio.raw");

            writer = new WaveFileWriter(output, waveIn.WaveFormat);

            byte[] buffer = new byte[bwp.BufferLength];
            int offset = 0;
            int count = bwp.BufferLength;

            var read = bwp.Read(buffer, offset, count);
            if (count > 0)
            {
                writer.Write(buffer, offset, read);
            }

            waveIn.Dispose();
            waveIn = null;
            writer.Close();
            writer = null;

            reader = new WaveFileReader("audio.raw"); // (new MemoryStream(bytes));
            waveOut.Init(reader);
            waveOut.PlaybackStopped += new EventHandler<StoppedEventArgs>(waveOut_PlaybackStopped);
            waveOut.Play();
        }

        public void waveOut_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            waveOut.Stop();
            reader.Close();
            reader = null;
        }

        public void speech(object sender, EventArgs e)
        {
            string text;

            if (File.Exists("audio.raw"))
            {

                var speech = SpeechClient.Create();
                var response = speech.Recognize(new RecognitionConfig()
                {
                    Encoding = RecognitionConfig.Types.AudioEncoding.Linear16,
                    SampleRateHertz = 16000,
                    LanguageCode = "en",
                }, RecognitionAudio.FromFile("audio.raw"));


                text = "";

                foreach (var result in response.Results)
                {
                    foreach (var alternative in result.Alternatives)
                    {
                        text = text + " " + alternative.Transcript;
                    }
                }

                if (text.Length == 0)
                    text = "No Data ";

            }
            else
            {

                text = "Audio File Missing ";

            }


        }

        public void play(object sender, EventArgs e)
        {
            if (File.Exists("audio.raw"))
            {
                reader = new WaveFileReader("audio.raw");
                waveOut.Init(reader);
                waveOut.Play();
            }
            else
            {
                Console.WriteLine("No Audio File Found");
            }
        }
    }

}
