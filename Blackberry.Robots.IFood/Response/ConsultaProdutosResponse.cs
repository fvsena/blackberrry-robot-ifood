using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Blackberry.Robots.IFood.Response
{
    public partial class ConsultaProdutosResponse
    {
        [JsonProperty("props")]
        public Props Props { get; set; }

        [JsonProperty("page")]
        public string Page { get; set; }

        [JsonProperty("query")]
        public Query Query { get; set; }

        [JsonProperty("buildId")]
        public string BuildId { get; set; }

        [JsonProperty("dynamicIds")]
        public List<string> DynamicIds { get; set; }
    }

    public partial class Props
    {
        [JsonProperty("isServer")]
        public bool IsServer { get; set; }

        [JsonProperty("initialState")]
        public InitialState InitialState { get; set; }

        [JsonProperty("initialProps")]
        public InitialProps InitialProps { get; set; }
    }

    public partial class InitialProps
    {
        [JsonProperty("pageProps")]
        public PageProps PageProps { get; set; }

        [JsonProperty("query")]
        public Query Query { get; set; }

        [JsonProperty("currentUrl")]
        public string CurrentUrl { get; set; }
    }

    public partial class PageProps
    {
        [JsonProperty("uuid")]
        public Guid Uuid { get; set; }
    }

    public partial class Query
    {
        [JsonProperty("UTM_Medium")]
        public string UtmMedium { get; set; }

        [JsonProperty("citySlug")]
        public string CitySlug { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("uuid")]
        public Guid Uuid { get; set; }
    }

    public partial class InitialState
    {
        [JsonProperty("account")]
        public Account Account { get; set; }

        [JsonProperty("accountUpdate")]
        public Account AccountUpdate { get; set; }

        [JsonProperty("address")]
        public InitialStateAddress Address { get; set; }

        [JsonProperty("addressModal")]
        public AddressModal AddressModal { get; set; }

        [JsonProperty("addressSearch")]
        public AddressSearch AddressSearch { get; set; }

        [JsonProperty("checkout")]
        public Checkout Checkout { get; set; }

        [JsonProperty("checkToken")]
        public CheckToken CheckToken { get; set; }

        [JsonProperty("configs")]
        public InitialStateConfigs Configs { get; set; }

        [JsonProperty("contextCard")]
        public ContextCard ContextCard { get; set; }

        [JsonProperty("customerPlaces")]
        public CustomerPlaces CustomerPlaces { get; set; }

        [JsonProperty("discovery")]
        public Discovery Discovery { get; set; }

        [JsonProperty("discoverySortable")]
        public DiscoverySortable DiscoverySortable { get; set; }

        [JsonProperty("dishModal")]
        public DishModal DishModal { get; set; }

        [JsonProperty("downloadAppModal")]
        public DownloadAppModal DownloadAppModal { get; set; }

        [JsonProperty("group")]
        public InitialStateGroup Group { get; set; }

        [JsonProperty("lastRestaurants")]
        public LastRestaurants LastRestaurants { get; set; }

        [JsonProperty("loopSchedule")]
        public LoopSchedule LoopSchedule { get; set; }

        [JsonProperty("orderCheckout")]
        public OrderCheckout OrderCheckout { get; set; }

        [JsonProperty("orders")]
        public Orders Orders { get; set; }

        [JsonProperty("statuses")]
        public Statuses Statuses { get; set; }

        [JsonProperty("overviewOrders")]
        public OverviewOrders OverviewOrders { get; set; }

        [JsonProperty("promotion")]
        public Promotion Promotion { get; set; }

        [JsonProperty("restaurant")]
        public Restaurant Restaurant { get; set; }

        [JsonProperty("restaurantsByCity")]
        public RestaurantsByCity RestaurantsByCity { get; set; }

        [JsonProperty("restaurantsSearch")]
        public RestaurantsSearch RestaurantsSearch { get; set; }

        [JsonProperty("filter")]
        public Filter Filter { get; set; }

        [JsonProperty("router")]
        public Router Router { get; set; }

        [JsonProperty("search")]
        public InitialStateSearch Search { get; set; }

        [JsonProperty("searchHistory")]
        public List<object> SearchHistory { get; set; }

        [JsonProperty("session")]
        public Checkout Session { get; set; }

        [JsonProperty("signIn")]
        public SignIn SignIn { get; set; }

        [JsonProperty("signUp")]
        public SignUp SignUp { get; set; }

        [JsonProperty("states")]
        public InitialStateStates States { get; set; }

        [JsonProperty("toastr")]
        public Toastr Toastr { get; set; }

        [JsonProperty("wallet")]
        public Wallet Wallet { get; set; }

        [JsonProperty("voucherWallet")]
        public VoucherWallet VoucherWallet { get; set; }

        [JsonProperty("floatingBox")]
        public Checkout FloatingBox { get; set; }

        [JsonProperty("oauth")]
        public Oauth Oauth { get; set; }

        [JsonProperty("loopDeliveryInfo")]
        public LoopDeliveryInfo LoopDeliveryInfo { get; set; }

        [JsonProperty("cartShuffleModal")]
        public CartShuffleModal CartShuffleModal { get; set; }
    }

    public partial class Account
    {
        [JsonProperty("isLoading")]
        public bool IsLoading { get; set; }
    }

    public partial class InitialStateAddress
    {
        [JsonProperty("location")]
        public AddressLocation Location { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("coords")]
        public Checkout Coords { get; set; }

        [JsonProperty("isLoading")]
        public bool IsLoading { get; set; }
    }

    public partial class Checkout
    {
    }

    public partial class AddressLocation
    {
        [JsonProperty("initialLoad")]
        public bool InitialLoad { get; set; }
    }

    public partial class AddressModal
    {
        [JsonProperty("open")]
        public bool Open { get; set; }

        [JsonProperty("keepCurrentPageAfterSelect")]
        public bool KeepCurrentPageAfterSelect { get; set; }
    }

    public partial class AddressSearch
    {
        [JsonProperty("search")]
        public AddressSearchSearch Search { get; set; }

        [JsonProperty("customer")]
        public Customer Customer { get; set; }

        [JsonProperty("states")]
        public AddressSearchStates States { get; set; }

        [JsonProperty("addressSetForConfirmation")]
        public object AddressSetForConfirmation { get; set; }

        [JsonProperty("geolocation")]
        public object Geolocation { get; set; }
    }

    public partial class Customer
    {
        [JsonProperty("isLoading")]
        public bool IsLoading { get; set; }

        [JsonProperty("addresses")]
        public List<object> Addresses { get; set; }
    }

    public partial class AddressSearchSearch
    {
        [JsonProperty("isLoading")]
        public bool IsLoading { get; set; }

        [JsonProperty("isLoadingSelected")]
        public bool IsLoadingSelected { get; set; }

        [JsonProperty("isLoadingEditing")]
        public bool IsLoadingEditing { get; set; }

        [JsonProperty("results")]
        public List<object> Results { get; set; }

        [JsonProperty("coords")]
        public Checkout Coords { get; set; }

        [JsonProperty("isEditing")]
        public bool IsEditing { get; set; }
    }

    public partial class AddressSearchStates
    {
        [JsonProperty("options")]
        public List<object> Options { get; set; }

        [JsonProperty("cities")]
        public Checkout Cities { get; set; }

        [JsonProperty("isLoadingStates")]
        public bool IsLoadingStates { get; set; }
    }

    public partial class CartShuffleModal
    {
        [JsonProperty("isOpen")]
        public bool IsOpen { get; set; }

        [JsonProperty("newCart")]
        public Checkout NewCart { get; set; }
    }

    public partial class CheckToken
    {
        [JsonProperty("isLoading")]
        public bool IsLoading { get; set; }

        [JsonProperty("reauth")]
        public bool Reauth { get; set; }
    }

    public partial class InitialStateConfigs
    {
        [JsonProperty("pwa")]
        public Pwa Pwa { get; set; }

        [JsonProperty("restaurant")]
        public Checkout Restaurant { get; set; }

        [JsonProperty("testUser")]
        public Checkout TestUser { get; set; }

        [JsonProperty("experience")]
        public Experience Experience { get; set; }
    }

    public partial class Experience
    {
        [JsonProperty("marketHintView")]
        public bool MarketHintView { get; set; }
    }

    public partial class Pwa
    {
        [JsonProperty("tableauProduct")]
        public string TableauProduct { get; set; }
    }

    public partial class ContextCard
    {
        [JsonProperty("address")]
        public CheckoutClass Address { get; set; }

        [JsonProperty("checkout")]
        public CheckoutClass Checkout { get; set; }
    }

    public partial class CheckoutClass
    {
        [JsonProperty("isOpened")]
        public bool IsOpened { get; set; }
    }

    public partial class CustomerPlaces
    {
        [JsonProperty("places")]
        public List<object> Places { get; set; }

        [JsonProperty("isLoading")]
        public bool IsLoading { get; set; }

        [JsonProperty("loadingPlaces")]
        public List<object> LoadingPlaces { get; set; }
    }

    public partial class Discovery
    {
        [JsonProperty("highlights")]
        public List<object> Highlights { get; set; }

        [JsonProperty("cuisines")]
        public List<object> Cuisines { get; set; }

        [JsonProperty("groceriesListId")]
        public string GroceriesListId { get; set; }

        [JsonProperty("isLoading")]
        public bool IsLoading { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("loopHome")]
        public Checkout LoopHome { get; set; }

        [JsonProperty("metadata")]
        public Checkout Metadata { get; set; }

        [JsonProperty("variant")]
        public string Variant { get; set; }

        [JsonProperty("discoveries")]
        public List<object> Discoveries { get; set; }

        [JsonProperty("requestStatus")]
        public string RequestStatus { get; set; }
    }

    public partial class DiscoverySortable
    {
        [JsonProperty("isLoading")]
        public bool IsLoading { get; set; }

        [JsonProperty("isCuisine")]
        public bool IsCuisine { get; set; }

        [JsonProperty("items")]
        public List<object> Items { get; set; }
    }

    public partial class DishModal
    {
        [JsonProperty("isOpen")]
        public bool IsOpen { get; set; }

        [JsonProperty("restaurantSlug")]
        public Checkout RestaurantSlug { get; set; }
    }

    public partial class DownloadAppModal
    {
        [JsonProperty("isOpen")]
        public bool IsOpen { get; set; }
    }

    public partial class Filter
    {
        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("isLoading")]
        public bool IsLoading { get; set; }

        [JsonProperty("facets")]
        public Checkout Facets { get; set; }

        [JsonProperty("current")]
        public Current Current { get; set; }

        [JsonProperty("isMobileFilterModalOpen")]
        public bool IsMobileFilterModalOpen { get; set; }
    }

    public partial class Current
    {
        [JsonProperty("categories")]
        public List<object> Categories { get; set; }

        [JsonProperty("paymentTypes")]
        public List<object> PaymentTypes { get; set; }

        [JsonProperty("delivery")]
        public Delivery Delivery { get; set; }

        [JsonProperty("sort")]
        public string Sort { get; set; }
    }

    public partial class Delivery
    {
        [JsonProperty("deliveryFeeFrom")]
        public long DeliveryFeeFrom { get; set; }

        [JsonProperty("deliveryFeeTo")]
        public long DeliveryFeeTo { get; set; }

        [JsonProperty("deliveryTimeFrom")]
        public long DeliveryTimeFrom { get; set; }

        [JsonProperty("deliveryTimeTo")]
        public long DeliveryTimeTo { get; set; }
    }

    public partial class InitialStateGroup
    {
        [JsonProperty("isLoading")]
        public bool IsLoading { get; set; }

        [JsonProperty("addressOutOfRange")]
        public bool AddressOutOfRange { get; set; }
    }

    public partial class LastRestaurants
    {
        [JsonProperty("list")]
        public List<object> List { get; set; }

        [JsonProperty("requestStatus")]
        public string RequestStatus { get; set; }
    }

    public partial class LoopDeliveryInfo
    {
        [JsonProperty("isLoading")]
        public bool IsLoading { get; set; }

        [JsonProperty("countDownInformation")]
        public object CountDownInformation { get; set; }
    }

    public partial class LoopSchedule
    {
        [JsonProperty("dishCode")]
        public object DishCode { get; set; }

        [JsonProperty("restaurantId")]
        public object RestaurantId { get; set; }

        [JsonProperty("deliveryWindows")]
        public object DeliveryWindows { get; set; }

        [JsonProperty("deliveryDay")]
        public object DeliveryDay { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }
    }

    public partial class Oauth
    {
        [JsonProperty("isLoading")]
        public bool IsLoading { get; set; }

        [JsonProperty("hasError")]
        public bool HasError { get; set; }
    }

    public partial class OrderCheckout
    {
        [JsonProperty("orderCheckout")]
        public Checkout OrderCheckoutOrderCheckout { get; set; }

        [JsonProperty("isLoading")]
        public bool IsLoading { get; set; }
    }

    public partial class Orders
    {
        [JsonProperty("requestStatus")]
        public string RequestStatus { get; set; }

        [JsonProperty("requestStatusOrderDetails")]
        public string RequestStatusOrderDetails { get; set; }

        [JsonProperty("ordersList")]
        public List<object> OrdersList { get; set; }

        [JsonProperty("withDetails")]
        public bool WithDetails { get; set; }
    }

    public partial class OverviewOrders
    {
        [JsonProperty("hasOnGoingOrders")]
        public long HasOnGoingOrders { get; set; }
    }

    public partial class Promotion
    {
        [JsonProperty("isPromotion")]
        public Checkout IsPromotion { get; set; }

        [JsonProperty("violation")]
        public Violation Violation { get; set; }
    }

    public partial class Violation
    {
        [JsonProperty("violationCodes")]
        public List<object> ViolationCodes { get; set; }
    }

    public partial class Restaurant
    {
        [JsonProperty("menu")]
        public List<Menu> Menu { get; set; }

        [JsonProperty("uuid")]
        public Guid Uuid { get; set; }

        [JsonProperty("evaluations")]
        public Evaluations Evaluations { get; set; }

        [JsonProperty("details")]
        public Details Details { get; set; }

        [JsonProperty("paymentTypes")]
        public List<object> PaymentTypes { get; set; }

        [JsonProperty("deliveryFee")]
        public Checkout DeliveryFee { get; set; }

        [JsonProperty("deliveryInfo")]
        public DeliveryInfo DeliveryInfo { get; set; }

        [JsonProperty("isLoading")]
        public ErrorStatusCode IsLoading { get; set; }

        [JsonProperty("errorStatusCode")]
        public ErrorStatusCode ErrorStatusCode { get; set; }

        [JsonProperty("cache")]
        public Cache Cache { get; set; }
    }

    public partial class Cache
    {
        [JsonProperty("52e40f9d-52f4-4fe7-aabe-d63282c89c3f")]
        public CacheProperty CacheProperty { get; set; }
    }

    public partial class CacheProperty
    {
        [JsonProperty("menu")]
        public List<Menu> Menu { get; set; }

        [JsonProperty("uuid")]
        public Guid Uuid { get; set; }

        [JsonProperty("evaluations")]
        public Evaluations Evaluations { get; set; }

        [JsonProperty("details")]
        public Details Details { get; set; }

        [JsonProperty("paymentTypes")]
        public List<object> PaymentTypes { get; set; }

        [JsonProperty("deliveryFee")]
        public Checkout DeliveryFee { get; set; }

        [JsonProperty("deliveryInfo")]
        public DeliveryInfo DeliveryInfo { get; set; }

        [JsonProperty("isLoading")]
        public ErrorStatusCode IsLoading { get; set; }

        [JsonProperty("errorStatusCode")]
        public ErrorStatusCode ErrorStatusCode { get; set; }

        [JsonProperty("cache")]
        public Checkout Cache { get; set; }
    }

    public partial class DeliveryInfo
    {
        [JsonProperty("deliversAtLocation")]
        public object DeliversAtLocation { get; set; }
    }

    public partial class Details
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("shortId")]
        public long ShortId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("companyCode")]
        public string CompanyCode { get; set; }

        [JsonProperty("address")]
        public DetailsAddress Address { get; set; }

        [JsonProperty("resources")]
        public List<Resource> Resources { get; set; }

        [JsonProperty("takeoutTime")]
        public long TakeoutTime { get; set; }

        [JsonProperty("deliveryTime")]
        public long DeliveryTime { get; set; }

        [JsonProperty("minimumOrderValue")]
        public long MinimumOrderValue { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("phoneIf")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long PhoneIf { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        [JsonProperty("merchantChain")]
        public Checkout MerchantChain { get; set; }

        [JsonProperty("groups")]
        public List<GroupElement> Groups { get; set; }

        [JsonProperty("shifts")]
        public List<Shift> Shifts { get; set; }

        [JsonProperty("priceRange")]
        public string PriceRange { get; set; }

        [JsonProperty("mainCategory")]
        public MainCategory MainCategory { get; set; }

        [JsonProperty("categories")]
        public List<object> Categories { get; set; }

        [JsonProperty("features")]
        public List<string> Features { get; set; }

        [JsonProperty("configs")]
        public DetailsConfigs Configs { get; set; }

        [JsonProperty("userRatingCount")]
        public long UserRatingCount { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("avgPrice")]
        public long AvgPrice { get; set; }

        [JsonProperty("wsv3Address")]
        public Wsv3Address Wsv3Address { get; set; }

        [JsonProperty("telephone")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Telephone { get; set; }

        [JsonProperty("restaurantShortId")]
        public long RestaurantShortId { get; set; }

        [JsonProperty("nextOpeningHour")]
        public NextOpeningHour NextOpeningHour { get; set; }

        [JsonProperty("supportsSchedule")]
        public bool SupportsSchedule { get; set; }

        [JsonProperty("closed")]
        public bool Closed { get; set; }

        [JsonProperty("evaluationAverage")]
        public long EvaluationAverage { get; set; }

        [JsonProperty("recent")]
        public bool Recent { get; set; }

        [JsonProperty("charging")]
        public string Charging { get; set; }

        [JsonProperty("isDocumentRequired")]
        public bool IsDocumentRequired { get; set; }

        [JsonProperty("superRestaurant")]
        public bool SuperRestaurant { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("isLoop")]
        public bool IsLoop { get; set; }
    }

    public partial class DetailsAddress
    {
        [JsonProperty("district")]
        public string District { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("zipCode")]
        public string ZipCode { get; set; }

        [JsonProperty("streetName")]
        public string StreetName { get; set; }

        [JsonProperty("streetNumber")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long StreetNumber { get; set; }
    }

    public partial class DetailsConfigs
    {
        [JsonProperty("orderNoteLength")]
        public long OrderNoteLength { get; set; }

        [JsonProperty("chargeDifferentToppingsMode")]
        public string ChargeDifferentToppingsMode { get; set; }
    }

    public partial class GroupElement
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class MainCategory
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("friendlyName")]
        public string FriendlyName { get; set; }
    }

    public partial class NextOpeningHour
    {
        [JsonProperty("dayOfWeek")]
        public string DayOfWeek { get; set; }

        [JsonProperty("openingTime")]
        public long OpeningTime { get; set; }

        [JsonProperty("closingTime")]
        public long ClosingTime { get; set; }
    }

    public partial class Resource
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }
    }

    public partial class Shift
    {
        [JsonProperty("dayOfWeek")]
        public string DayOfWeek { get; set; }

        [JsonProperty("start")]
        public DateTimeOffset Start { get; set; }

        [JsonProperty("duration")]
        public long Duration { get; set; }
    }

    public partial class Wsv3Address
    {
        [JsonProperty("streetNumber")]
        public long StreetNumber { get; set; }

        [JsonProperty("location")]
        public Wsv3AddressLocation Location { get; set; }
    }

    public partial class Wsv3AddressLocation
    {
        [JsonProperty("locationId")]
        public long LocationId { get; set; }

        [JsonProperty("zipCode")]
        public long ZipCode { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("dependentAddress")]
        public string DependentAddress { get; set; }

        [JsonProperty("district")]
        public string District { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lon")]
        public double Lon { get; set; }

        [JsonProperty("requireCompl")]
        public bool RequireCompl { get; set; }
    }

    public partial class ErrorStatusCode
    {
        [JsonProperty("menu")]
        public bool? Menu { get; set; }

        [JsonProperty("details")]
        public bool? Details { get; set; }

        [JsonProperty("paymentTypes")]
        public bool? PaymentTypes { get; set; }

        [JsonProperty("deliveryInfo")]
        public bool? DeliveryInfo { get; set; }

        [JsonProperty("evaluations")]
        public bool? Evaluations { get; set; }

        [JsonProperty("uuid")]
        public bool? Uuid { get; set; }
    }

    public partial class Evaluations
    {
        [JsonProperty("ratings")]
        public List<Rating> Ratings { get; set; }

        [JsonProperty("uuid")]
        public Guid Uuid { get; set; }

        [JsonProperty("shortId")]
        public long ShortId { get; set; }

        [JsonProperty("page")]
        public long Page { get; set; }

        [JsonProperty("hasNextPage")]
        public bool HasNextPage { get; set; }
    }

    public partial class Rating
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rate")]
        public long Rate { get; set; }

        [JsonProperty("userEvaluation")]
        public string UserEvaluation { get; set; }

        [JsonProperty("restaurantAnswer")]
        public string RestaurantAnswer { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("orderNumber")]
        public long OrderNumber { get; set; }
    }

    public partial class Menu
    {
        [JsonProperty("code")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("itens")]
        public List<Item> Itens { get; set; }

        [JsonProperty("order")]
        public long Order { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }

    public partial class Item
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("code")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Code { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("taxonomyName")]
        public string TaxonomyName { get; set; }

        [JsonProperty("needChoices")]
        public bool NeedChoices { get; set; }

        [JsonProperty("choices")]
        public List<object> Choices { get; set; }

        [JsonProperty("unitPrice")]
        public double UnitPrice { get; set; }

        [JsonProperty("unitMinPrice")]
        public double UnitMinPrice { get; set; }

        [JsonProperty("order")]
        public long Order { get; set; }

        [JsonProperty("availability")]
        public Availability Availability { get; set; }

        [JsonProperty("openingHours")]
        public List<string> OpeningHours { get; set; }

        [JsonProperty("discoveryTags")]
        public List<string> DiscoveryTags { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        [JsonProperty("operationModes")]
        public List<OperationMode> OperationModes { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("unitOriginalPrice", NullValueHandling = NullValueHandling.Ignore)]
        public double? UnitOriginalPrice { get; set; }

        public override string ToString()
        {
            return this.Description;
        }
    }

    public partial class RestaurantsByCity
    {
        [JsonProperty("list")]
        public List<object> List { get; set; }

        [JsonProperty("isLoading")]
        public bool IsLoading { get; set; }

        [JsonProperty("hasMore")]
        public bool HasMore { get; set; }
    }

    public partial class RestaurantsSearch
    {
        [JsonProperty("isLoading")]
        public bool IsLoading { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("page")]
        public long Page { get; set; }

        [JsonProperty("restaurants")]
        public List<object> Restaurants { get; set; }

        [JsonProperty("hasMore")]
        public bool HasMore { get; set; }
    }

    public partial class Router
    {
        [JsonProperty("previousRoute")]
        public string PreviousRoute { get; set; }

        [JsonProperty("nextChangeIsGoBack")]
        public bool NextChangeIsGoBack { get; set; }

        [JsonProperty("listUrl")]
        public List<object> ListUrl { get; set; }

        [JsonProperty("currentRoute")]
        public string CurrentRoute { get; set; }
    }

    public partial class InitialStateSearch
    {
        [JsonProperty("merchants")]
        public CatalogItems Merchants { get; set; }

        [JsonProperty("catalogItems")]
        public CatalogItems CatalogItems { get; set; }

        [JsonProperty("currentSearchValue")]
        public string CurrentSearchValue { get; set; }

        [JsonProperty("lastSearchValue")]
        public string LastSearchValue { get; set; }

        [JsonProperty("showSuggestion")]
        public bool ShowSuggestion { get; set; }

        [JsonProperty("elementIdFocus")]
        public long ElementIdFocus { get; set; }
    }

    public partial class CatalogItems
    {
        [JsonProperty("isLoading")]
        public bool IsLoading { get; set; }

        [JsonProperty("data")]
        public List<object> Data { get; set; }
    }

    public partial class SignIn
    {
        [JsonProperty("signin")]
        public Signin Signin { get; set; }

        [JsonProperty("isLoading")]
        public IsLoading IsLoading { get; set; }

        [JsonProperty("otpToken")]
        public OtpToken OtpToken { get; set; }
    }

    public partial class IsLoading
    {
        [JsonProperty("createOtp")]
        public bool CreateOtp { get; set; }

        [JsonProperty("provider")]
        public bool Provider { get; set; }

        [JsonProperty("signin")]
        public bool Signin { get; set; }
    }

    public partial class OtpToken
    {
        [JsonProperty("isLoadingToken")]
        public bool IsLoadingToken { get; set; }

        [JsonProperty("isLoadingChallenge")]
        public bool IsLoadingChallenge { get; set; }

        [JsonProperty("isLoadingOtpKey")]
        public bool IsLoadingOtpKey { get; set; }

        [JsonProperty("signup")]
        public bool Signup { get; set; }
    }

    public partial class Signin
    {
        [JsonProperty("user")]
        public Checkout User { get; set; }

        [JsonProperty("signup")]
        public bool Signup { get; set; }
    }

    public partial class SignUp
    {
        [JsonProperty("isLoading")]
        public bool IsLoading { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }
    }

    public partial class InitialStateStates
    {
        [JsonProperty("list")]
        public Checkout List { get; set; }

        [JsonProperty("isLoading")]
        public bool IsLoading { get; set; }
    }

    public partial class Statuses
    {
        [JsonProperty("ordersStatuses")]
        public Checkout OrdersStatuses { get; set; }

        [JsonProperty("requestStatus")]
        public string RequestStatus { get; set; }
    }

    public partial class Toastr
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("timeout")]
        public long Timeout { get; set; }
    }

    public partial class VoucherWallet
    {
        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("isLoading")]
        public bool IsLoading { get; set; }

        [JsonProperty("vouchers")]
        public List<object> Vouchers { get; set; }

        [JsonProperty("active")]
        public Checkout Active { get; set; }

        [JsonProperty("inactive")]
        public Checkout Inactive { get; set; }

        [JsonProperty("isCheckoutListOpen")]
        public bool IsCheckoutListOpen { get; set; }
    }

    public partial class Wallet
    {
        [JsonProperty("currentCard")]
        public Checkout CurrentCard { get; set; }
    }

    public enum Availability { Available };

    public enum OperationMode { Delivery };

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }

    internal class AvailabilityConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Availability) || t == typeof(Availability?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "AVAILABLE")
            {
                return Availability.Available;
            }
            throw new Exception("Cannot unmarshal type Availability");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Availability)untypedValue;
            if (value == Availability.Available)
            {
                serializer.Serialize(writer, "AVAILABLE");
                return;
            }
            throw new Exception("Cannot marshal type Availability");
        }

        public static readonly AvailabilityConverter Singleton = new AvailabilityConverter();
    }

    internal class OperationModeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(OperationMode) || t == typeof(OperationMode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "DELIVERY")
            {
                return OperationMode.Delivery;
            }
            throw new Exception("Cannot unmarshal type OperationMode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (OperationMode)untypedValue;
            if (value == OperationMode.Delivery)
            {
                serializer.Serialize(writer, "DELIVERY");
                return;
            }
            throw new Exception("Cannot marshal type OperationMode");
        }

        public static readonly OperationModeConverter Singleton = new OperationModeConverter();
    }
}
