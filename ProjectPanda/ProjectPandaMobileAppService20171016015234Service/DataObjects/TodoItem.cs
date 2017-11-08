using Microsoft.Azure.Mobile.Server;

namespace ProjectPandaMobileAppService20171016015234Service.DataObjects
{
    public class TodoItem : EntityData
    {
        public string Text { get; set; }

        public bool Complete { get; set; }
    }
}