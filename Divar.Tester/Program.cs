using Divar.Core;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace Divar.Tester
{
    internal class Program
    {
        public static List<string> PostedAds { get; set; } = new List<string>();
        static void Main(string[] args)
        {
            var divarHandler = new DivarHandler();
            var bot = new TelegramBotClient("6198242141:AAG5yIsPqzAVZ4pbxeheV-ZJEv62JQxuuTw");
            long groupId = -1001787757983;

            Console.WriteLine("Bot Started ...!");
            while (true)
            {
                try
                {
                    var result = divarHandler.SearchWithUrlAsync("https://api.divar.ir/v8/web-search/qom/motorcycles?goods-business-type=all&q=%D9%85%D9%88%D8%AA%D9%88%D8%B1", "qom").GetAwaiter().GetResult();

                    foreach (var post in result.web_widgets.post_list)
                    {
                        if (PostedAds.Any(x => x == post.data.token))
                            continue;
                        var postInfo = divarHandler.GetPostInfoAsync(post.data.token).GetAwaiter().GetResult();

                        string yearOfMake = postInfo.widgets.list_data.SingleOrDefault(x => x.title == "سال ساخت")!.value;
                        string usedTime = postInfo.widgets.list_data.SingleOrDefault(x => x.title == "کارکرد")!.value;

                        string msg = $"""
                            ‼️ آگهی جدید موتورسیکلت

                            🔅 <b> {post.data.title} </b> 🔅

                            💰 قیمت : <b> {post.data.middle_description_text} </b>

                            📍 مکان و زمان : {post.data.bottom_description_text}

                            🖇 مدل : <b> {postInfo.data.brand_model} </b>

                            📋 کار کرد : <b> {usedTime} </b>

                            ⚒ سال ساخت : <b> {yearOfMake} </b>

                            🔍 توضیحات : 
                            {postInfo.data.description}

                            """;

                        InlineKeyboardMarkup inlineKeyboard = new(new[]
                            {
                                InlineKeyboardButton.WithUrl(
                                    text: "👀 مشاهده اگهی",
                                    url: postInfo.data.share.android_url)
                            });

                        if (postInfo.widgets.images.Count == 0)
                            continue;

                        bot.SendPhotoAsync(groupId, InputFile.FromUri(postInfo.widgets.images.First()), caption: msg, replyMarkup: inlineKeyboard, parseMode: ParseMode.Html).GetAwaiter().GetResult();

                        PostedAds.Add(postInfo.token);

                        Thread.Sleep(100);
                    }
                }
                catch ()
                {
                }
            }
        }
    }
}