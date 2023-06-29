using AngleSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos.Streams;

namespace Module18_YoutubeExplode
{
    class CommandOne : Command
    {
        Receiver receiver;
        string videoUrl; //= "https://www.youtube.com/watch?v=bk6i4IQ3b54";
        

        public CommandOne (Receiver receiver)
        {
            this.receiver = receiver;
        }
        //Получить Инфо
        public async override void GetInfo(string videoUrl)
        {
            //var video = await client.Videos.GetAsync("https://www.youtube.com/watch?v=bk6i4IQ3b54");
            var youtube = new YoutubeClient();
            var track = await youtube.Videos.GetAsync(videoUrl);
            receiver.Operation();
        }
        //Скачать
        public async override void Download(string videoUrl)
        {

            var youtube = new YoutubeClient();
            var track = await youtube.Videos.GetAsync(videoUrl);
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(videoUrl);
            var streamInfo = streamManifest.GetVideoOnlyStreams().Where(s => s.Container == Container.Mp4).GetWithHighestVideoQuality();
            await youtube.Videos.Streams.DownloadAsync(streamInfo, $"video.{streamInfo.Container}");
            receiver.Operation();
        }
    }
}
