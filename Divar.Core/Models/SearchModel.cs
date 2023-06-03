
using Newtonsoft.Json;

namespace Divar.Core.Models
{
    public class SearchModel
    {
        public class Action
        {
            public string type { get; set; }
            public Payload payload { get; set; }
            public string fallback_link { get; set; }
            public bool page_pop_link { get; set; }
        }

        public class ActionLog
        {
            public ServerSideInfo server_side_info { get; set; }
            public bool enabled { get; set; }
        }

        public class BreadCrumb
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Category
        {
            public string value { get; set; }
            public bool additionalProperties { get; set; }
            public Properties properties { get; set; }
            public string title { get; set; }
            public string type { get; set; }

            [JsonProperty("ui:field")]
            public string uifield { get; set; }

            [JsonProperty("ui:options")]
            public UiOptions uioptions { get; set; }
            public Urischema urischema { get; set; }
        }

        public class Child
        {
            public string @enum { get; set; }
            public string enumName { get; set; }
            public List<object> tags { get; set; }
        }

        public class Cities
        {
            public List<string> @default { get; set; }
            public Items items { get; set; }
            public string type { get; set; }

            [JsonProperty("ui:options")]
            public UiOptions uioptions { get; set; }

            [JsonProperty("ui:widget")]
            public string uiwidget { get; set; }
        }

        public class Data
        {
            public List<Child> children { get; set; }
            public string @enum { get; set; }
            public string enumName { get; set; }

            [JsonProperty("@type")]
            public string type { get; set; }
            public string title { get; set; }
            public string image_url { get; set; }
            public Icon icon { get; set; }
            public Action action { get; set; }
            public List<Suggestion> suggestions { get; set; }
            public int? image_count { get; set; }
            public bool? has_chat { get; set; }
            public string top_description_text { get; set; }
            public string middle_description_text { get; set; }
            public string bottom_description_text { get; set; }
            public string red_text { get; set; }
            public bool? checkable { get; set; }
            public string label { get; set; }
            public string label_color { get; set; }
            public string note { get; set; }
            public List<object> tags { get; set; }
            public string standard_label_color { get; set; }
            public bool? is_checked { get; set; }
            public bool? has_divider { get; set; }
            public bool? padded { get; set; }
            public string token { get; set; }
        }

        public class Display
        {
            public List<string> CCTV { get; set; }
            public List<string> ROOT { get; set; }
            public List<string> accessories { get; set; }

            [JsonProperty("accounting-and-finance")]
            public List<string> accountingandfinance { get; set; }

            [JsonProperty("accounting-finance-legal")]
            public List<string> accountingfinancelegal { get; set; }

            [JsonProperty("administration-and-hr")]
            public List<string> administrationandhr { get; set; }

            [JsonProperty("air-conditioning-fan-coil")]
            public List<string> airconditioningfancoil { get; set; }
            public List<string> animals { get; set; }

            [JsonProperty("antiques-and-art")]
            public List<string> antiquesandart { get; set; }

            [JsonProperty("apartment-rent")]
            public List<string> apartmentrent { get; set; }

            [JsonProperty("apartment-sell")]
            public List<string> apartmentsell { get; set; }
            public List<string> appliance { get; set; }

            [JsonProperty("artificial-flower")]
            public List<string> artificialflower { get; set; }

            [JsonProperty("audio-video")]
            public List<string> audiovideo { get; set; }

            [JsonProperty("baby-and-toys")]
            public List<string> babyandtoys { get; set; }

            [JsonProperty("ball-sports")]
            public List<string> ballsports { get; set; }

            [JsonProperty("barbershop-and-beautysalon")]
            public List<string> barbershopandbeautysalon { get; set; }
            public List<string> batch { get; set; }

            [JsonProperty("bathroom-accessories")]
            public List<string> bathroomaccessories { get; set; }

            [JsonProperty("bathroom-wc-sauna")]
            public List<string> bathroomwcsauna { get; set; }
            public List<string> bathrooms { get; set; }

            [JsonProperty("beauty-and-haircare")]
            public List<string> beautyandhaircare { get; set; }

            [JsonProperty("bed-pillow-blanket")]
            public List<string> bedpillowblanket { get; set; }

            [JsonProperty("bed-service")]
            public List<string> bedservice { get; set; }

            [JsonProperty("bed-sheet")]
            public List<string> bedsheet { get; set; }

            [JsonProperty("beds-bedroom")]
            public List<string> bedsbedroom { get; set; }
            public List<string> bicycle { get; set; }
            public List<string> birds { get; set; }
            public List<string> boat { get; set; }

            [JsonProperty("book-student-literature")]
            public List<string> bookstudentliterature { get; set; }

            [JsonProperty("bookcase-shelf")]
            public List<string> bookcaseshelf { get; set; }

            [JsonProperty("buffet-showcases")]
            public List<string> buffetshowcases { get; set; }

            [JsonProperty("building-and-garden")]
            public List<string> buildingandgarden { get; set; }

            [JsonProperty("building-equipment")]
            public List<string> buildingequipment { get; set; }

            [JsonProperty("bus-metro-train")]
            public List<string> busmetrotrain { get; set; }
            public List<string> businesses { get; set; }

            [JsonProperty("cafe-and-restaurant")]
            public List<string> cafeandrestaurant { get; set; }

            [JsonProperty("camera-camcoders")]
            public List<string> cameracamcoders { get; set; }

            [JsonProperty("camping-outdoor")]
            public List<string> campingoutdoor { get; set; }

            [JsonProperty("car-and-motor")]
            public List<string> carandmotor { get; set; }

            [JsonProperty("care-health-beauty")]
            public List<string> carehealthbeauty { get; set; }
            public List<string> carpet { get; set; }

            [JsonProperty("carpet-moquette")]
            public List<string> carpetmoquette { get; set; }
            public List<string> carpets { get; set; }
            public List<string> cars { get; set; }
            public List<string> cat { get; set; }
            public List<string> catering { get; set; }

            [JsonProperty("chair-bench")]
            public List<string> chairbench { get; set; }
            public List<string> chandeliers { get; set; }

            [JsonProperty("child-car-seat")]
            public List<string> childcarseat { get; set; }

            [JsonProperty("childrens-clothing-and-shoe")]
            public List<string> childrensclothingandshoe { get; set; }

            [JsonProperty("childrens-furniture")]
            public List<string> childrensfurniture { get; set; }
            public List<string> classic { get; set; }
            public List<string> cleaning { get; set; }

            [JsonProperty("cleaning-supplies")]
            public List<string> cleaningsupplies { get; set; }

            [JsonProperty("clothes-rack")]
            public List<string> clothesrack { get; set; }
            public List<string> clothing { get; set; }

            [JsonProperty("clothing-and-shoes")]
            public List<string> clothingandshoes { get; set; }

            [JsonProperty("coin-stamp")]
            public List<string> coinstamp { get; set; }

            [JsonProperty("commercial-rent")]
            public List<string> commercialrent { get; set; }

            [JsonProperty("commercial-sell")]
            public List<string> commercialsell { get; set; }
            public List<string> community { get; set; }

            [JsonProperty("computer-and-it")]
            public List<string> computerandit { get; set; }

            [JsonProperty("computer-and-mobile")]
            public List<string> computerandmobile { get; set; }
            public List<string> computers { get; set; }
            public List<string> concert { get; set; }

            [JsonProperty("conference-meeting")]
            public List<string> conferencemeeting { get; set; }

            [JsonProperty("construction-craft")]
            public List<string> constructioncraft { get; set; }

            [JsonProperty("container-organizers")]
            public List<string> containerorganizers { get; set; }
            public List<string> containers { get; set; }

            [JsonProperty("cooking-utensils")]
            public List<string> cookingutensils { get; set; }

            [JsonProperty("cookware-tableware")]
            public List<string> cookwaretableware { get; set; }
            public List<string> crafts { get; set; }
            public List<string> craftsmen { get; set; }

            [JsonProperty("curtains-table-cover")]
            public List<string> curtainstablecover { get; set; }
            public List<string> decoration { get; set; }
            public List<string> desk { get; set; }
            public List<string> desktops { get; set; }

            [JsonProperty("detergent-tissue")]
            public List<string> detergenttissue { get; set; }

            [JsonProperty("dining-table")]
            public List<string> diningtable { get; set; }
            public List<string> dishwasher { get; set; }

            [JsonProperty("diving-watersports")]
            public List<string> divingwatersports { get; set; }
            public List<string> dog { get; set; }

            [JsonProperty("drink-maker")]
            public List<string> drinkmaker { get; set; }

            [JsonProperty("drums-percussion")]
            public List<string> drumspercussion { get; set; }
            public List<string> education { get; set; }
            public List<string> educational { get; set; }

            [JsonProperty("electronic-devices")]
            public List<string> electronicdevices { get; set; }
            public List<string> entertainment { get; set; }

            [JsonProperty("equipments-and-machinery")]
            public List<string> equipmentsandmachinery { get; set; }
            public List<string> @event { get; set; }

            [JsonProperty("events-sports")]
            public List<string> eventssports { get; set; }

            [JsonProperty("fan-ventilator-humidifier")]
            public List<string> fanventilatorhumidifier { get; set; }

            [JsonProperty("farm-animals")]
            public List<string> farmanimals { get; set; }
            public List<string> figurines { get; set; }
            public List<string> fish { get; set; }
            public List<string> fishing { get; set; }

            [JsonProperty("food-and-drink")]
            public List<string> foodanddrink { get; set; }

            [JsonProperty("food-mill")]
            public List<string> foodmill { get; set; }

            [JsonProperty("for-sale")]
            public List<string> forsale { get; set; }

            [JsonProperty("for-the-home")]
            public List<string> forthehome { get; set; }
            public List<string> furniture { get; set; }

            [JsonProperty("furniture-and-home-decore")]
            public List<string> furnitureandhomedecore { get; set; }

            [JsonProperty("furniture-wood")]
            public List<string> furniturewood { get; set; }

            [JsonProperty("game-consoles-and-video-games")]
            public List<string> gameconsolesandvideogames { get; set; }

            [JsonProperty("garden-and-landscaping")]
            public List<string> gardenandlandscaping { get; set; }

            [JsonProperty("garden-and-patio")]
            public List<string> gardenandpatio { get; set; }

            [JsonProperty("garden-tools")]
            public List<string> gardentools { get; set; }

            [JsonProperty("gift-certificate")]
            public List<string> giftcertificate { get; set; }

            [JsonProperty("guitar-bass-amplifier")]
            public List<string> guitarbassamplifier { get; set; }

            [JsonProperty("health-beauty")]
            public List<string> healthbeauty { get; set; }
            public List<string> heavy { get; set; }
            public List<string> historical { get; set; }

            [JsonProperty("historical-objects")]
            public List<string> historicalobjects { get; set; }

            [JsonProperty("hobby-collectibles")]
            public List<string> hobbycollectibles { get; set; }

            [JsonProperty("home-catering")]
            public List<string> homecatering { get; set; }

            [JsonProperty("home-kitchen")]
            public List<string> homekitchen { get; set; }

            [JsonProperty("home-lighting")]
            public List<string> homelighting { get; set; }

            [JsonProperty("horses-equestrian")]
            public List<string> horsesequestrian { get; set; }

            [JsonProperty("house-villa-rent")]
            public List<string> housevillarent { get; set; }

            [JsonProperty("house-villa-sell")]
            public List<string> housevillasell { get; set; }
            public List<string> industrial { get; set; }

            [JsonProperty("industrial-machinery")]
            public List<string> industrialmachinery { get; set; }

            [JsonProperty("industrial-technology")]
            public List<string> industrialtechnology { get; set; }

            [JsonProperty("industry-agriculture-business-rent")]
            public List<string> industryagriculturebusinessrent { get; set; }

            [JsonProperty("industry-agriculture-business-sell")]
            public List<string> industryagriculturebusinesssell { get; set; }

            [JsonProperty("instrument-cleaning-tailoring")]
            public List<string> instrumentcleaningtailoring { get; set; }

            [JsonProperty("janitorial-cleaning")]
            public List<string> janitorialcleaning { get; set; }
            public List<string> jewelry { get; set; }

            [JsonProperty("jewelry-and-watches")]
            public List<string> jewelryandwatches { get; set; }
            public List<string> jobs { get; set; }
            public List<string> juicers { get; set; }
            public List<string> kitchen { get; set; }

            [JsonProperty("kitchen-utensils")]
            public List<string> kitchenutensils { get; set; }
            public List<string> lamps { get; set; }
            public List<string> lampshade { get; set; }
            public List<string> laptops { get; set; }

            [JsonProperty("leisure-hobbies")]
            public List<string> leisurehobbies { get; set; }

            [JsonProperty("leisure-hobbies-toys")]
            public List<string> leisurehobbiestoys { get; set; }
            public List<string> light { get; set; }
            public List<string> lighting { get; set; }
            public List<string> literary { get; set; }

            [JsonProperty("lost-and-found")]
            public List<string> lostandfound { get; set; }

            [JsonProperty("lost-animals")]
            public List<string> lostanimals { get; set; }

            [JsonProperty("lost-things")]
            public List<string> lostthings { get; set; }

            [JsonProperty("lumbar-pillow")]
            public List<string> lumbarpillow { get; set; }
            public List<string> magazines { get; set; }
            public List<string> mat { get; set; }
            public List<string> mattress { get; set; }

            [JsonProperty("media-advertising")]
            public List<string> mediaadvertising { get; set; }

            [JsonProperty("medical-equipment")]
            public List<string> medicalequipment { get; set; }

            [JsonProperty("microwave-stove")]
            public List<string> microwavestove { get; set; }
            public List<string> mirror { get; set; }

            [JsonProperty("mobile-phones")]
            public List<string> mobilephones { get; set; }

            [JsonProperty("mobile-tablet")]
            public List<string> mobiletablet { get; set; }

            [JsonProperty("mobile-tablet-accessories")]
            public List<string> mobiletabletaccessories { get; set; }

            [JsonProperty("modem-and-network-equipment")]
            public List<string> modemandnetworkequipment { get; set; }
            public List<string> moquette { get; set; }
            public List<string> motorcycles { get; set; }

            [JsonProperty("movies-and-music")]
            public List<string> moviesandmusic { get; set; }

            [JsonProperty("mp3-player")]
            public List<string> mp3player { get; set; }

            [JsonProperty("musical-instruments")]
            public List<string> musicalinstruments { get; set; }

            [JsonProperty("natural-plants")]
            public List<string> naturalplants { get; set; }

            [JsonProperty("office-decoration")]
            public List<string> officedecoration { get; set; }

            [JsonProperty("office-rent")]
            public List<string> officerent { get; set; }

            [JsonProperty("office-sell")]
            public List<string> officesell { get; set; }
            public List<string> offices { get; set; }

            [JsonProperty("other-appliances")]
            public List<string> otherappliances { get; set; }

            [JsonProperty("oven-baking-appliances")]
            public List<string> ovenbakingappliances { get; set; }

            [JsonProperty("paintings-picture")]
            public List<string> paintingspicture { get; set; }
            public List<string> partnership { get; set; }

            [JsonProperty("parts-accessories")]
            public List<string> partsaccessories { get; set; }

            [JsonProperty("parts-and-accessories")]
            public List<string> partsandaccessories { get; set; }
            public List<string> personal { get; set; }

            [JsonProperty("personal-toys")]
            public List<string> personaltoys { get; set; }
            public List<string> phone { get; set; }

            [JsonProperty("phone-desk")]
            public List<string> phonedesk { get; set; }

            [JsonProperty("piano-keyboard")]
            public List<string> pianokeyboard { get; set; }

            [JsonProperty("pictorial-carpet")]
            public List<string> pictorialcarpet { get; set; }

            [JsonProperty("plot-old")]
            public List<string> plotold { get; set; }

            [JsonProperty("pot-kettle")]
            public List<string> potkettle { get; set; }
            public List<string> presell { get; set; }

            [JsonProperty("printer-scaner-copier")]
            public List<string> printerscanercopier { get; set; }

            [JsonProperty("range-hood")]
            public List<string> rangehood { get; set; }

            [JsonProperty("real-estate")]
            public List<string> realestate { get; set; }

            [JsonProperty("real-estate-services")]
            public List<string> realestateservices { get; set; }

            [JsonProperty("refrigerator-freezer")]
            public List<string> refrigeratorfreezer { get; set; }
            public List<string> religious { get; set; }
            public List<string> rental { get; set; }

            [JsonProperty("repair-tool")]
            public List<string> repairtool { get; set; }
            public List<string> reptile { get; set; }
            public List<string> research { get; set; }

            [JsonProperty("residential-rent")]
            public List<string> residentialrent { get; set; }

            [JsonProperty("residential-sell")]
            public List<string> residentialsell { get; set; }
            public List<string> rhinestones { get; set; }

            [JsonProperty("rodents-rabbits")]
            public List<string> rodentsrabbits { get; set; }

            [JsonProperty("rubber-carpet")]
            public List<string> rubbercarpet { get; set; }

            [JsonProperty("rugs-woolen-cloth")]
            public List<string> rugswoolencloth { get; set; }

            [JsonProperty("sales-marketing")]
            public List<string> salesmarketing { get; set; }
            public List<string> services { get; set; }

            [JsonProperty("sewing-accessories")]
            public List<string> sewingaccessories { get; set; }

            [JsonProperty("sewing-knitting")]
            public List<string> sewingknitting { get; set; }

            [JsonProperty("sewing-machine")]
            public List<string> sewingmachine { get; set; }

            [JsonProperty("shoe-rack-drawer")]
            public List<string> shoerackdrawer { get; set; }

            [JsonProperty("shoes-belt-bag")]
            public List<string> shoesbeltbag { get; set; }

            [JsonProperty("shop-and-cash")]
            public List<string> shopandcash { get; set; }

            [JsonProperty("shop-rent")]
            public List<string> shoprent { get; set; }

            [JsonProperty("shop-restaurant")]
            public List<string> shoprestaurant { get; set; }

            [JsonProperty("shop-sell")]
            public List<string> shopsell { get; set; }

            [JsonProperty("sim-card")]
            public List<string> simcard { get; set; }

            [JsonProperty("sleep-goods")]
            public List<string> sleepgoods { get; set; }

            [JsonProperty("sofa-armchair")]
            public List<string> sofaarmchair { get; set; }
            public List<string> sport { get; set; }

            [JsonProperty("sport-leisure")]
            public List<string> sportleisure { get; set; }
            public List<string> stationery { get; set; }

            [JsonProperty("steam-iron")]
            public List<string> steamiron { get; set; }

            [JsonProperty("stereo-surround")]
            public List<string> stereosurround { get; set; }
            public List<string> storage { get; set; }

            [JsonProperty("stove-and-heating")]
            public List<string> stoveandheating { get; set; }

            [JsonProperty("stoves-heaters-fireplaces")]
            public List<string> stovesheatersfireplaces { get; set; }

            [JsonProperty("strollers-and-accessories")]
            public List<string> strollersandaccessories { get; set; }

            [JsonProperty("suite-apartment")]
            public List<string> suiteapartment { get; set; }
            public List<string> tablecloths { get; set; }

            [JsonProperty("tables-and-chairs")]
            public List<string> tablesandchairs { get; set; }
            public List<string> tablet { get; set; }
            public List<string> teaching { get; set; }

            [JsonProperty("temporary-rent")]
            public List<string> temporaryrent { get; set; }

            [JsonProperty("textile-ornaments")]
            public List<string> textileornaments { get; set; }

            [JsonProperty("theatre-and-cinema")]
            public List<string> theatreandcinema { get; set; }
            public List<string> ticket { get; set; }

            [JsonProperty("tickets-sports")]
            public List<string> ticketssports { get; set; }
            public List<string> toolbox { get; set; }

            [JsonProperty("tools-materials-equipment")]
            public List<string> toolsmaterialsequipment { get; set; }
            public List<string> traditional { get; set; }
            public List<string> training { get; set; }
            public List<string> transport { get; set; }
            public List<string> transportation { get; set; }

            [JsonProperty("travel-packages")]
            public List<string> travelpackages { get; set; }

            [JsonProperty("tv-projector")]
            public List<string> tvprojector { get; set; }

            [JsonProperty("tv-stand")]
            public List<string> tvstand { get; set; }

            [JsonProperty("utensils-and-appliances")]
            public List<string> utensilsandappliances { get; set; }
            public List<string> utility { get; set; }

            [JsonProperty("vacuums-cleaner")]
            public List<string> vacuumscleaner { get; set; }
            public List<string> vehicles { get; set; }

            [JsonProperty("ventilation-cooling-heating")]
            public List<string> ventilationcoolingheating { get; set; }

            [JsonProperty("video-dvdplayer")]
            public List<string> videodvdplayer { get; set; }
            public List<string> villa { get; set; }
            public List<string> violins { get; set; }
            public List<string> volunteers { get; set; }

            [JsonProperty("wall-clock")]
            public List<string> wallclock { get; set; }

            [JsonProperty("washer-dryer")]
            public List<string> washerdryer { get; set; }

            [JsonProperty("washing-cleaning")]
            public List<string> washingcleaning { get; set; }

            [JsonProperty("washing-machines")]
            public List<string> washingmachines { get; set; }
            public List<string> watches { get; set; }

            [JsonProperty("water-cooler")]
            public List<string> watercooler { get; set; }

            [JsonProperty("water-cooler-refinery")]
            public List<string> watercoolerrefinery { get; set; }

            [JsonProperty("water-heater-package-radiator")]
            public List<string> waterheaterpackageradiator { get; set; }

            [JsonProperty("wc-accessories")]
            public List<string> wcaccessories { get; set; }
            public List<string> wind { get; set; }

            [JsonProperty("winter-sports")]
            public List<string> wintersports { get; set; }

            [JsonProperty("work-equipment")]
            public List<string> workequipment { get; set; }
            public List<string> workspace { get; set; }

            [JsonProperty("yarn-lights")]
            public List<string> yarnlights { get; set; }
            public List<string> all { get; set; }
            public List<string> marketplace { get; set; }
        }

        public class Districts
        {
            public bool additionalProperties { get; set; }
            public Properties properties { get; set; }
            public List<string> required { get; set; }
            public string title { get; set; }
            public string type { get; set; }

            [JsonProperty("ui:field")]
            public string uifield { get; set; }

            [JsonProperty("ui:options")]
            public UiOptions uioptions { get; set; }
            public Urischema urischema { get; set; }
            public Vacancies vacancies { get; set; }
        }

        public class ExtraData
        {
            [JsonProperty("@type")]
            public string type { get; set; }
            public Jli jli { get; set; }
            public object last_post_sort_date { get; set; }
            public bool no_cat_page { get; set; }
        }

        public class Filters
        {
            [JsonProperty("goods-business-type")]
            public GoodsBusinessType goodsbusinesstype { get; set; }
            public string query { get; set; }
            public Category category { get; set; }
        }

        public class GoodsBusinessType
        {
            public string value { get; set; }
            public bool additionalProperties { get; set; }
            public Properties properties { get; set; }
            public string title { get; set; }
            public string type { get; set; }

            [JsonProperty("ui:options")]
            public UiOptions uioptions { get; set; }

            [JsonProperty("ui:widget")]
            public string uiwidget { get; set; }
            public Urischema urischema { get; set; }
        }

        public class HasPhoto
        {
            public string title { get; set; }
            public string type { get; set; }

            [JsonProperty("ui:options")]
            public UiOptions uioptions { get; set; }

            [JsonProperty("ui:widget")]
            public string uiwidget { get; set; }
        }

        public class Icon
        {
            public string image_url_dark { get; set; }
            public string image_url_light { get; set; }
            public string icon_name { get; set; }
            public string icon_color { get; set; }
        }

        public class ImageUrl
        {
            public string src { get; set; }
            public string type { get; set; }
        }

        public class Info
        {
            [JsonProperty("@type")]
            public string type { get; set; }
            public string campagign_name { get; set; }
            public string phone_number { get; set; }
            public string post_token { get; set; }
            public int index { get; set; }
            public string post_type { get; set; }
            public string list_type { get; set; }
            public string source_page { get; set; }
            public ExtraData extra_data { get; set; }
        }

        public class InputSuggestion
        {
            public JsonSchema json_schema { get; set; }
            public UiSchema ui_schema { get; set; }
        }

        public class Items
        {
            public List<string> @enum { get; set; }
            public List<string> enumNames { get; set; }
            public string type { get; set; }
        }

        public class ItemType
        {
            public string type { get; set; }
        }

        public class Jli
        {
            public Category category { get; set; }

            [JsonProperty("goods-business-type")]
            public GoodsBusinessType goodsbusinesstype { get; set; }
            public string query { get; set; }
            public List<string> cities { get; set; }
        }

        public class JsonSchema
        {
            public Properties properties { get; set; }
            public string type { get; set; }
            public bool additionalProperties { get; set; }
        }

        public class Max
        {
            public int multipleOf { get; set; }
            public string type { get; set; }
            public List<int> @enum { get; set; }
            public List<string> enumNames { get; set; }

            [JsonProperty("ui:options")]
            public UiOptions uioptions { get; set; }

            [JsonProperty("ui:placeholder")]
            public string uiplaceholder { get; set; }

            [JsonProperty("ui:widget")]
            public string uiwidget { get; set; }
        }

        public class MetaRobots
        {
            public bool follow { get; set; }
            public bool index { get; set; }
        }

        public class Min
        {
            public int minimum { get; set; }
            public int multipleOf { get; set; }
            public string type { get; set; }
            public List<int> @enum { get; set; }
            public List<string> enumNames { get; set; }

            [JsonProperty("ui:options")]
            public UiOptions uioptions { get; set; }

            [JsonProperty("ui:placeholder")]
            public string uiplaceholder { get; set; }

            [JsonProperty("ui:widget")]
            public string uiwidget { get; set; }
        }

        public class NearVacancies
        {
            public string title { get; set; }
            public string type { get; set; }
        }

        public class Payload
        {
            [JsonProperty("@type")]
            public string type { get; set; }
            public Jli jli { get; set; }
            public string web_url { get; set; }
            public bool no_cat_page { get; set; }
            public string source_view { get; set; }
            public string tooltip { get; set; }
            public string token { get; set; }
            public WebInfo web_info { get; set; }
            public VerticalInfo vertical_info { get; set; }
        }

        public class PostList
        {
            public string widget_type { get; set; }
            public Data data { get; set; }
            public ActionLog action_log { get; set; }
        }

        public class Price
        {
            public bool additionalProperties { get; set; }
            public Properties properties { get; set; }
            public string title { get; set; }
            public string type { get; set; }
            public Max max { get; set; }
            public Min min { get; set; }

            [JsonProperty("ui:field")]
            public string uifield { get; set; }

            [JsonProperty("ui:options")]
            public UiOptions uioptions { get; set; }

            [JsonProperty("ui:order")]
            public List<string> uiorder { get; set; }
        }

        public class Properties
        {
            public Districts districts { get; set; }

            [JsonProperty("near-vacancies")]
            public NearVacancies nearvacancies { get; set; }
            public Vacancies vacancies { get; set; }
            public Category category { get; set; }
            public Cities cities { get; set; }

            [JsonProperty("goods-business-type")]
            public GoodsBusinessType goodsbusinesstype { get; set; }

            [JsonProperty("has-photo")]
            public HasPhoto hasphoto { get; set; }
            public Price price { get; set; }
            public Query query { get; set; }
            public Urgent urgent { get; set; }
            public Value value { get; set; }
            public Max max { get; set; }
            public Min min { get; set; }
        }

        public class Query
        {
            public string type { get; set; }

            [JsonProperty("ui:options")]
            public UiOptions uioptions { get; set; }

            [JsonProperty("ui:widget")]
            public string uiwidget { get; set; }
        }

        public class SearchRoot
        {
            public TabList tab_list { get; set; }
            public List<object> suggestion_list { get; set; }
            public InputSuggestion input_suggestion { get; set; }
            public string title { get; set; }
            public string subtitle { get; set; }
            public SeoDetails seo_details { get; set; }
            public object internal_link_sections { get; set; }
            public long last_post_date { get; set; }
            public long first_post_date { get; set; }
            public WebWidgets web_widgets { get; set; }
            public List<object> banners { get; set; }
            public Schema schema { get; set; }
            public Jli jli { get; set; }
        }

        public class Schema
        {
            public JsonSchema json_schema { get; set; }
            public UiSchema ui_schema { get; set; }
        }

        public class SeoDetails
        {
            public string title { get; set; }
            public string description { get; set; }
            public string headline { get; set; }
            public MetaRobots meta_robots { get; set; }
            public List<BreadCrumb> bread_crumbs { get; set; }
            public string next { get; set; }
            public string web_url { get; set; }
            public string android_url { get; set; }
            public string canonical { get; set; }
            public string prev { get; set; }
            public List<object> meta_tags { get; set; }
            public string schema { get; set; }
            public string content { get; set; }
        }

        public class ServerSideInfo
        {
            public Info info { get; set; }
            public ItemType item_type { get; set; }
        }

        public class Status
        {
            public string title { get; set; }

            [JsonProperty("ui:order")]
            public List<string> uiorder { get; set; }
        }

        public class Suggestion
        {
            public string query_title { get; set; }
            public string category { get; set; }
            public string count { get; set; }
            public bool has_divider { get; set; }
            public Filters filters { get; set; }
        }

        public class Tab
        {
            public int type { get; set; }
            public string text { get; set; }
            public Filters filters { get; set; }
        }

        public class TabList
        {
            public int current_tab { get; set; }
            public List<Tab> tabs { get; set; }
            public Tooltip tooltip { get; set; }
        }

        public class Toolbox
        {
            public string widget_type { get; set; }
            public Data data { get; set; }
            public ActionLog action_log { get; set; }
        }

        public class Tooltip
        {
            public string text { get; set; }
            public string identifier { get; set; }
        }

        public class UiGroup
        {
            public Status status { get; set; }
        }

        public class UiOptions
        {
            [JsonProperty("active-internal-links")]
            public bool activeinternallinks { get; set; }

            [JsonProperty("display-text-format")]
            public string displaytextformat { get; set; }
            public string icon { get; set; }

            [JsonProperty("is-advanced")]
            public bool isadvanced { get; set; }
            public string label { get; set; }

            [JsonProperty("parent-category-slug")]
            public string parentcategoryslug { get; set; }

            [JsonProperty("post-set-label")]
            public string postsetlabel { get; set; }

            [JsonProperty("manual-input-button-label")]
            public string manualinputbuttonlabel { get; set; }

            [JsonProperty("not-set-value")]
            public string notsetvalue { get; set; }

            [JsonProperty("postfix-label")]
            public string postfixlabel { get; set; }

            [JsonProperty("overlay-label")]
            public string overlaylabel { get; set; }
            public Data data { get; set; }

            [JsonProperty("default-text")]
            public string defaulttext { get; set; }
        }

        public class UiSchema
        {
            public Districts districts { get; set; }
            public Category category { get; set; }
            public Cities cities { get; set; }

            [JsonProperty("goods-business-type")]
            public GoodsBusinessType goodsbusinesstype { get; set; }

            [JsonProperty("has-photo")]
            public HasPhoto hasphoto { get; set; }
            public Price price { get; set; }
            public Query query { get; set; }

            [JsonProperty("ui:group")]
            public UiGroup uigroup { get; set; }

            [JsonProperty("ui:order")]
            public List<string> uiorder { get; set; }
            public Urgent urgent { get; set; }
        }

        public class Urgent
        {
            public string title { get; set; }
            public string type { get; set; }

            [JsonProperty("ui:options")]
            public UiOptions uioptions { get; set; }

            [JsonProperty("ui:widget")]
            public string uiwidget { get; set; }
        }

        public class Urischema
        {
            public int order { get; set; }
            public Display display { get; set; }
        }

        public class Vacancies
        {
            public Items items { get; set; }
            public int minItems { get; set; }
            public string title { get; set; }
            public string type { get; set; }

            [JsonProperty("ui:options")]
            public UiOptions uioptions { get; set; }
        }

        public class Value
        {
            public string type { get; set; }
            public List<string> @enum { get; set; }
            public List<string> enumNames { get; set; }

            [JsonProperty("ui:options")]
            public UiOptions uioptions { get; set; }
        }

        public class VerticalInfo
        {
            [JsonProperty("@type")]
            public string type { get; set; }
            public int vertical_type { get; set; }
        }

        public class WebInfo
        {
            public string title { get; set; }
            public string district_persian { get; set; }
            public string city_persian { get; set; }
            public string category_slug_persian { get; set; }
        }

        public class WebWidgets
        {
            public List<Toolbox> toolbox { get; set; }
            public List<object> left_toolbox { get; set; }
            public List<PostList> post_list { get; set; }
        }


    }
}
