// Decompiled with JetBrains decompiler
// Type: UniWebViewInterface
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
[Token(Token = "0x2000317")]
public class UniWebViewInterface
{
  [Token(Token = "0x4000CC2")]
  [FieldOffset(Offset = "0x0")]
  private static bool alreadyLoggedWarning;

  [Token(Token = "0x6001015")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void SetLogLevel(int level)
  {
  }

  [Token(Token = "0x6001016")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void Init(string name, int x, int y, int width, int height)
  {
  }

  [Token(Token = "0x6001017")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void Destroy(string name)
  {
  }

  [Token(Token = "0x6001018")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void Load(string name, string url, bool skipEncoding, string readAccessURL)
  {
  }

  [Token(Token = "0x6001019")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void LoadHTMLString(string name, string html, string baseUrl, bool skipEncoding)
  {
  }

  [Token(Token = "0x600101A")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void Reload(string name)
  {
  }

  [Token(Token = "0x600101B")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void Stop(string name)
  {
  }

  [Token(Token = "0x600101C")]
  [Address(RVA = "0x12AB3C0", Offset = "0x12AA1C0", VA = "0x112AB3C0")]
  public static string GetUrl(string name) => (string) null;

  [Token(Token = "0x600101D")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void SetFrame(string name, int x, int y, int width, int height)
  {
  }

  [Token(Token = "0x600101E")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void SetPosition(string name, int x, int y)
  {
  }

  [Token(Token = "0x600101F")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void SetSize(string name, int width, int height)
  {
  }

  [Token(Token = "0x6001020")]
  [Address(RVA = "0x12AB2C0", Offset = "0x12AA0C0", VA = "0x112AB2C0")]
  public static bool Show(string name, bool fade, int edge, float duration, string identifier)
  {
    return new bool();
  }

  [Token(Token = "0x6001021")]
  [Address(RVA = "0x12AB2C0", Offset = "0x12AA0C0", VA = "0x112AB2C0")]
  public static bool Hide(string name, bool fade, int edge, float duration, string identifier)
  {
    return new bool();
  }

  [Token(Token = "0x6001022")]
  [Address(RVA = "0x12AB2C0", Offset = "0x12AA0C0", VA = "0x112AB2C0")]
  public static bool AnimateTo(
    string name,
    int x,
    int y,
    int width,
    int height,
    float duration,
    float delay,
    string identifier)
  {
    return new bool();
  }

  [Token(Token = "0x6001023")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void AddJavaScript(string name, string jsString, string identifier)
  {
  }

  [Token(Token = "0x6001024")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void EvaluateJavaScript(string name, string jsString, string identifier)
  {
  }

  [Token(Token = "0x6001025")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void AddUrlScheme(string name, string scheme)
  {
  }

  [Token(Token = "0x6001026")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void RemoveUrlScheme(string name, string scheme)
  {
  }

  [Token(Token = "0x6001027")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void AddSslExceptionDomain(string name, string domain)
  {
  }

  [Token(Token = "0x6001028")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void RemoveSslExceptionDomain(string name, string domain)
  {
  }

  [Token(Token = "0x6001029")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void SetHeaderField(string name, string key, string value)
  {
  }

  [Token(Token = "0x600102A")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void SetUserAgent(string name, string userAgent)
  {
  }

  [Token(Token = "0x600102B")]
  [Address(RVA = "0x12AB3F0", Offset = "0x12AA1F0", VA = "0x112AB3F0")]
  public static string GetUserAgent(string name) => (string) null;

  [Token(Token = "0x600102C")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void SetAllowAutoPlay(bool flag)
  {
  }

  [Token(Token = "0x600102D")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void SetAllowInlinePlay(bool flag)
  {
  }

  [Token(Token = "0x600102E")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void SetAllowJavaScriptOpenWindow(bool flag)
  {
  }

  [Token(Token = "0x600102F")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void SetJavaScriptEnabled(bool flag)
  {
  }

  [Token(Token = "0x6001030")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void CleanCache(string name)
  {
  }

  [Token(Token = "0x6001031")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void ClearCookies()
  {
  }

  [Token(Token = "0x6001032")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void SetCookie(string url, string cookie, bool skipEncoding)
  {
  }

  [Token(Token = "0x6001033")]
  [Address(RVA = "0x12AB390", Offset = "0x12AA190", VA = "0x112AB390")]
  public static string GetCookie(string url, string key, bool skipEncoding) => (string) null;

  [Token(Token = "0x6001034")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void ClearHttpAuthUsernamePassword(string host, string realm)
  {
  }

  [Token(Token = "0x6001035")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void SetBackgroundColor(string name, float r, float g, float b, float a)
  {
  }

  [Token(Token = "0x6001036")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void SetWebViewAlpha(string name, float alpha)
  {
  }

  [Token(Token = "0x6001037")]
  [Address(RVA = "0x12AB420", Offset = "0x12AA220", VA = "0x112AB420")]
  public static float GetWebViewAlpha(string name) => new float();

  [Token(Token = "0x6001038")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void SetShowSpinnerWhileLoading(string name, bool show)
  {
  }

  [Token(Token = "0x6001039")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void SetSpinnerText(string name, string text)
  {
  }

  [Token(Token = "0x600103A")]
  [Address(RVA = "0x12AB2C0", Offset = "0x12AA0C0", VA = "0x112AB2C0")]
  public static bool CanGoBack(string name) => new bool();

  [Token(Token = "0x600103B")]
  [Address(RVA = "0x12AB2C0", Offset = "0x12AA0C0", VA = "0x112AB2C0")]
  public static bool CanGoForward(string name) => new bool();

  [Token(Token = "0x600103C")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void GoBack(string name)
  {
  }

  [Token(Token = "0x600103D")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void GoForward(string name)
  {
  }

  [Token(Token = "0x600103E")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void SetOpenLinksInExternalBrowser(string name, bool flag)
  {
  }

  [Token(Token = "0x600103F")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void SetHorizontalScrollBarEnabled(string name, bool enabled)
  {
  }

  [Token(Token = "0x6001040")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void SetVerticalScrollBarEnabled(string name, bool enabled)
  {
  }

  [Token(Token = "0x6001041")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void SetBouncesEnabled(string name, bool enabled)
  {
  }

  [Token(Token = "0x6001042")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void SetZoomEnabled(string name, bool enabled)
  {
  }

  [Token(Token = "0x6001043")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void SetShowToolbar(
    string name,
    bool show,
    bool animated,
    bool onTop,
    bool adjustInset)
  {
  }

  [Token(Token = "0x6001044")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void SetToolbarDoneButtonText(string name, string text)
  {
  }

  [Token(Token = "0x6001045")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void SetWebContentsDebuggingEnabled(bool enabled)
  {
  }

  [Token(Token = "0x6001046")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void SetAllowHTTPAuthPopUpWindow(string name, bool flag)
  {
  }

  [Token(Token = "0x6001047")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void Print(string name)
  {
  }

  [Token(Token = "0x6001048")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void SetCalloutEnabled(string name, bool flag)
  {
  }

  [Token(Token = "0x6001049")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void SetSupportMultipleWindows(string name, bool flag)
  {
  }

  [Token(Token = "0x600104A")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void SetDragInteractionEnabled(string name, bool flag)
  {
  }

  [Token(Token = "0x600104B")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void ScrollTo(string name, int x, int y, bool animated)
  {
  }

  [Token(Token = "0x600104C")]
  [Address(RVA = "0x12AB2D0", Offset = "0x12AA0D0", VA = "0x112AB2D0")]
  public static void CheckPlatform()
  {
  }

  [Token(Token = "0x600104D")]
  [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
  public UniWebViewInterface()
  {
  }
}
