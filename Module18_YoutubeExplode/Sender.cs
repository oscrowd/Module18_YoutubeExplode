using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18_YoutubeExplode
{
    class Sender
    {
        Command _command;
        string _url;
        public void SetCommand(Command command)
        { 
            _command = command;
        }
        //Получить инфо
        public void GetInfo(string _url)
        { 
            _command.GetInfo(_url);
        }
        //Скачать
        public void Download(string _url)
        { 
            _command.Download(_url);
        }

    }
}
