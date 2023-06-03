namespace Divar.Core.Models
{
    public class PostInfoModel
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Breadcrumb
        {
            public List<Category> categories { get; set; }
            public string main_url { get; set; }
            public string base_url { get; set; }
        }

        public class BusinessData
        {
            public string business_type { get; set; }
            public object business_ref { get; set; }
            public object data { get; set; }
        }

        public class Category
        {
            public string slug { get; set; }
            public string title { get; set; }
            public string second_slug { get; set; }
        }

        public class Category2
        {
            public string icon_url { get; set; }
            public int old_meta_id { get; set; }
            public string parent_slug { get; set; }
            public string slug { get; set; }
            public string title { get; set; }
            public string second_slug { get; set; }
            public string relative_url { get; set; }
        }

        public class Contact
        {
            public string phone { get; set; }
            public int ab_mode { get; set; }
            public bool chat { get; set; }
        }

        public class Data
        {
            public Share share { get; set; }
            public string url { get; set; }
            public string description { get; set; }
            public string brand_model { get; set; }
            public string city { get; set; }
            public string district { get; set; }
        }

        public class Header
        {
            public string date { get; set; }
            public string subtitle { get; set; }
            public string title { get; set; }
            public string thumbnail { get; set; }
            public string place { get; set; }
            public object business_logo { get; set; }
        }

        public class Link
        {
            public string title { get; set; }
            public string url { get; set; }
            public string relative_url { get; set; }
        }

        public class ListDatum
        {
            public string title { get; set; }
            public string format { get; set; }
            public string value { get; set; }
        }

        public class Location
        {
            public string latitude { get; set; }
            public string longitude { get; set; }
            public string map_url { get; set; }
        }

        public class Note
        {
            public bool enable { get; set; }
        }

        public class PostInfoRoot
        {
            public Data data { get; set; }
            public Widgets widgets { get; set; }
            public string token { get; set; }
            public int error { get; set; }
        }

        public class Seo
        {
            public string title { get; set; }
            public string description { get; set; }
            public string url { get; set; }
            public string home_url { get; set; }
            public string android_package_name { get; set; }
            public string ios_app_id { get; set; }
            public string android_app_url { get; set; }
            public string ios_app_url { get; set; }
            public string thumbnail { get; set; }
        }

        public class Share
        {
            public string android_url { get; set; }
        }

        public class Suggestions
        {
            public bool suggestion_available { get; set; }
            public string title { get; set; }
            public List<object> posts { get; set; }
            public List<object> widget_list { get; set; }
            public List<object> post_suggestion_extra_logs { get; set; }
        }

        public class Warning
        {
            public string title { get; set; }
            public string link { get; set; }
        }

        public class Webengage
        {
            public string category { get; set; }
            public string token { get; set; }
            public string city { get; set; }
            public string brand_model { get; set; }
            public string business_type { get; set; }
            public object business_ref { get; set; }
            public object data { get; set; }
            public object price { get; set; }
            public object rent { get; set; }
            public object credit { get; set; }
        }

        public class Widgets
        {
            public string description { get; set; }
            public List<ListDatum> list_data { get; set; }
            public List<string> images { get; set; }

        }


    }
}
