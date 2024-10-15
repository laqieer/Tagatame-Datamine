// Decompiled with JetBrains decompiler
// Type: UniWebView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000318")]
public class UniWebView : MonoBehaviour
{
  [Token(Token = "0x4000CCB")]
  [FieldOffset(Offset = "0x2C")]
  private string id;
  [Token(Token = "0x4000CCC")]
  [FieldOffset(Offset = "0x30")]
  private UniWebViewNativeListener listener;
  [Token(Token = "0x4000CCD")]
  [FieldOffset(Offset = "0x34")]
  private bool isPortrait;
  [Token(Token = "0x4000CCE")]
  [FieldOffset(Offset = "0x38")]
  [SerializeField]
  private string urlOnStart;
  [Token(Token = "0x4000CCF")]
  [FieldOffset(Offset = "0x3C")]
  [SerializeField]
  private bool showOnStart;
  [Token(Token = "0x4000CD0")]
  [FieldOffset(Offset = "0x3D")]
  [SerializeField]
  private bool fullScreen;
  [Token(Token = "0x4000CD1")]
  [FieldOffset(Offset = "0x3E")]
  [SerializeField]
  private bool useToolbar;
  [Token(Token = "0x4000CD2")]
  [FieldOffset(Offset = "0x40")]
  [SerializeField]
  private UniWebViewToolbarPosition toolbarPosition;
  [Token(Token = "0x4000CD3")]
  [FieldOffset(Offset = "0x44")]
  private Dictionary<string, Action> actions;
  [Token(Token = "0x4000CD4")]
  [FieldOffset(Offset = "0x48")]
  private Dictionary<string, Action<UniWebViewNativeResultPayload>> payloadActions;
  [Token(Token = "0x4000CD5")]
  [FieldOffset(Offset = "0x4C")]
  [SerializeField]
  private Rect frame;
  [Token(Token = "0x4000CD6")]
  [FieldOffset(Offset = "0x5C")]
  [SerializeField]
  private RectTransform referenceRectTransform;
  [Token(Token = "0x4000CD7")]
  [FieldOffset(Offset = "0x60")]
  private bool started;
  [Token(Token = "0x4000CD8")]
  [FieldOffset(Offset = "0x64")]
  private Color backgroundColor;

  [Token(Token = "0x14000006")]
  public event UniWebView.PageStartedDelegate OnPageStarted
  {
    [Token(Token = "0x600104E"), Address(RVA = "0x12AE520", Offset = "0x12AD320", VA = "0x112AE520")] add
    {
    }
    [Token(Token = "0x600104F"), Address(RVA = "0x12AEAC0", Offset = "0x12AD8C0", VA = "0x112AEAC0")] remove
    {
    }
  }

  [Token(Token = "0x14000007")]
  public event UniWebView.PageFinishedDelegate OnPageFinished
  {
    [Token(Token = "0x6001050"), Address(RVA = "0x12AE4A0", Offset = "0x12AD2A0", VA = "0x112AE4A0")] add
    {
    }
    [Token(Token = "0x6001051"), Address(RVA = "0x12AEA40", Offset = "0x12AD840", VA = "0x112AEA40")] remove
    {
    }
  }

  [Token(Token = "0x14000008")]
  public event UniWebView.PageErrorReceivedDelegate OnPageErrorReceived
  {
    [Token(Token = "0x6001052"), Address(RVA = "0x12AE420", Offset = "0x12AD220", VA = "0x112AE420")] add
    {
    }
    [Token(Token = "0x6001053"), Address(RVA = "0x12AE9C0", Offset = "0x12AD7C0", VA = "0x112AE9C0")] remove
    {
    }
  }

  [Token(Token = "0x14000009")]
  public event UniWebView.MessageReceivedDelegate OnMessageReceived
  {
    [Token(Token = "0x6001054"), Address(RVA = "0x12AE2A0", Offset = "0x12AD0A0", VA = "0x112AE2A0")] add
    {
    }
    [Token(Token = "0x6001055"), Address(RVA = "0x12AE840", Offset = "0x12AD640", VA = "0x112AE840")] remove
    {
    }
  }

  [Token(Token = "0x1400000A")]
  public event UniWebView.ShouldCloseDelegate OnShouldClose
  {
    [Token(Token = "0x6001056"), Address(RVA = "0x12AE5A0", Offset = "0x12AD3A0", VA = "0x112AE5A0")] add
    {
    }
    [Token(Token = "0x6001057"), Address(RVA = "0x12AEB40", Offset = "0x12AD940", VA = "0x112AEB40")] remove
    {
    }
  }

  [Token(Token = "0x1400000B")]
  public event UniWebView.KeyCodeReceivedDelegate OnKeyCodeReceived
  {
    [Token(Token = "0x6001058"), Address(RVA = "0x12AE220", Offset = "0x12AD020", VA = "0x112AE220")] add
    {
    }
    [Token(Token = "0x6001059"), Address(RVA = "0x12AE7C0", Offset = "0x12AD5C0", VA = "0x112AE7C0")] remove
    {
    }
  }

  [Token(Token = "0x1400000C")]
  public event UniWebView.OrientationChangedDelegate OnOrientationChanged
  {
    [Token(Token = "0x600105A"), Address(RVA = "0x12AE3A0", Offset = "0x12AD1A0", VA = "0x112AE3A0")] add
    {
    }
    [Token(Token = "0x600105B"), Address(RVA = "0x12AE940", Offset = "0x12AD740", VA = "0x112AE940")] remove
    {
    }
  }

  [Token(Token = "0x1400000D")]
  public event UniWebView.OnWebContentProcessTerminatedDelegate OnWebContentProcessTerminated
  {
    [Token(Token = "0x600105C"), Address(RVA = "0x12AE620", Offset = "0x12AD420", VA = "0x112AE620")] add
    {
    }
    [Token(Token = "0x600105D"), Address(RVA = "0x12AEBC0", Offset = "0x12AD9C0", VA = "0x112AEBC0")] remove
    {
    }
  }

  [Token(Token = "0x170001DD")]
  public Rect Frame
  {
    [Token(Token = "0x600105E"), Address(RVA = "0x12AE740", Offset = "0x12AD540", VA = "0x112AE740")] get
    {
      return new Rect();
    }
    [Token(Token = "0x600105F"), Address(RVA = "0x12AEC80", Offset = "0x12ADA80", VA = "0x112AEC80")] set
    {
    }
  }

  [Token(Token = "0x170001DE")]
  public RectTransform ReferenceRectTransform
  {
    [Token(Token = "0x6001060"), Address(RVA = "0x288090", Offset = "0x286E90", VA = "0x10288090")] get
    {
      return (RectTransform) null;
    }
    [Token(Token = "0x6001061"), Address(RVA = "0x12AECA0", Offset = "0x12ADAA0", VA = "0x112AECA0")] set
    {
    }
  }

  [Token(Token = "0x170001DF")]
  public string Url
  {
    [Token(Token = "0x6001062"), Address(RVA = "0x12AE760", Offset = "0x12AD560", VA = "0x112AE760")] get
    {
      return (string) null;
    }
  }

  [Token(Token = "0x6001063")]
  [Address(RVA = "0x12AE000", Offset = "0x12ACE00", VA = "0x112AE000")]
  public void UpdateFrame()
  {
  }

  [Token(Token = "0x6001064")]
  [Address(RVA = "0x12AD740", Offset = "0x12AC540", VA = "0x112AD740")]
  private Rect NextFrameRect() => new Rect();

  [Token(Token = "0x6001065")]
  [Address(RVA = "0x12ACC80", Offset = "0x12ABA80", VA = "0x112ACC80")]
  private void Awake()
  {
  }

  [Token(Token = "0x6001066")]
  [Address(RVA = "0x12ADF40", Offset = "0x12ACD40", VA = "0x112ADF40")]
  private void Start()
  {
  }

  [Token(Token = "0x6001067")]
  [Address(RVA = "0x12AE090", Offset = "0x12ACE90", VA = "0x112AE090")]
  private void Update()
  {
  }

  [Token(Token = "0x6001068")]
  [Address(RVA = "0x12ADC70", Offset = "0x12ACA70", VA = "0x112ADC70")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x6001069")]
  [Address(RVA = "0x12ADBF0", Offset = "0x12AC9F0", VA = "0x112ADBF0")]
  private void OnDisable()
  {
  }

  [Token(Token = "0x600106A")]
  [Address(RVA = "0x12ACED0", Offset = "0x12ABCD0", VA = "0x112ACED0")]
  public void Load(string url, bool skipEncoding = false, string readAccessURL = null)
  {
  }

  [Token(Token = "0x600106B")]
  [Address(RVA = "0x12ACED0", Offset = "0x12ABCD0", VA = "0x112ACED0")]
  public void LoadHTMLString(string htmlString, string baseUrl, bool skipEncoding = false)
  {
  }

  [Token(Token = "0x600106C")]
  [Address(RVA = "0x12ACED0", Offset = "0x12ABCD0", VA = "0x112ACED0")]
  public void Reload()
  {
  }

  [Token(Token = "0x600106D")]
  [Address(RVA = "0x12ACED0", Offset = "0x12ABCD0", VA = "0x112ACED0")]
  public void Stop()
  {
  }

  [Token(Token = "0x170001E0")]
  public bool CanGoBack
  {
    [Token(Token = "0x600106E"), Address(RVA = "0x12AE700", Offset = "0x12AD500", VA = "0x112AE700")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x170001E1")]
  public bool CanGoForward
  {
    [Token(Token = "0x600106F"), Address(RVA = "0x12AE700", Offset = "0x12AD500", VA = "0x112AE700")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x6001070")]
  [Address(RVA = "0x12ACED0", Offset = "0x12ABCD0", VA = "0x112ACED0")]
  public void GoBack()
  {
  }

  [Token(Token = "0x6001071")]
  [Address(RVA = "0x12ACED0", Offset = "0x12ABCD0", VA = "0x112ACED0")]
  public void GoForward()
  {
  }

  [Token(Token = "0x6001072")]
  [Address(RVA = "0x12ACED0", Offset = "0x12ABCD0", VA = "0x112ACED0")]
  public void SetOpenLinksInExternalBrowser(bool flag)
  {
  }

  [Token(Token = "0x6001073")]
  [Address(RVA = "0x12ADEC0", Offset = "0x12ACCC0", VA = "0x112ADEC0")]
  public bool Show(
    bool fade = false,
    UniWebViewTransitionEdge edge = UniWebViewTransitionEdge.None,
    float duration = 0.4f,
    Action completionHandler = null)
  {
    return new bool();
  }

  [Token(Token = "0x6001074")]
  [Address(RVA = "0x12AD140", Offset = "0x12ABF40", VA = "0x112AD140")]
  public bool Hide(
    bool fade = false,
    UniWebViewTransitionEdge edge = UniWebViewTransitionEdge.None,
    float duration = 0.4f,
    Action completionHandler = null)
  {
    return new bool();
  }

  [Token(Token = "0x6001075")]
  [Address(RVA = "0x12ACBD0", Offset = "0x12AB9D0", VA = "0x112ACBD0")]
  public bool AnimateTo(Rect frame, float duration, float delay = 0.0f, Action completionHandler = null)
  {
    return new bool();
  }

  [Token(Token = "0x6001076")]
  [Address(RVA = "0x12AC990", Offset = "0x12AB790", VA = "0x112AC990")]
  public void AddJavaScript(
    string jsString,
    Action<UniWebViewNativeResultPayload> completionHandler = null)
  {
  }

  [Token(Token = "0x6001077")]
  [Address(RVA = "0x12ACF10", Offset = "0x12ABD10", VA = "0x112ACF10")]
  public void EvaluateJavaScript(
    string jsString,
    Action<UniWebViewNativeResultPayload> completionHandler = null)
  {
  }

  [Token(Token = "0x6001078")]
  [Address(RVA = "0x12ACB00", Offset = "0x12AB900", VA = "0x112ACB00")]
  public void AddUrlScheme(string scheme)
  {
  }

  [Token(Token = "0x6001079")]
  [Address(RVA = "0x12ADD70", Offset = "0x12ACB70", VA = "0x112ADD70")]
  public void RemoveUrlScheme(string scheme)
  {
  }

  [Token(Token = "0x600107A")]
  [Address(RVA = "0x12ACA30", Offset = "0x12AB830", VA = "0x112ACA30")]
  public void AddSslExceptionDomain(string domain)
  {
  }

  [Token(Token = "0x600107B")]
  [Address(RVA = "0x12ADCA0", Offset = "0x12ACAA0", VA = "0x112ADCA0")]
  public void RemoveSslExceptionDomain(string domain)
  {
  }

  [Token(Token = "0x600107C")]
  [Address(RVA = "0x12ADE40", Offset = "0x12ACC40", VA = "0x112ADE40")]
  public void SetHeaderField(string key, string value)
  {
  }

  [Token(Token = "0x600107D")]
  [Address(RVA = "0x12ACED0", Offset = "0x12ABCD0", VA = "0x112ACED0")]
  public void SetUserAgent(string agent)
  {
  }

  [Token(Token = "0x600107E")]
  [Address(RVA = "0x12AD0E0", Offset = "0x12ABEE0", VA = "0x112AD0E0")]
  public string GetUserAgent() => (string) null;

  [Token(Token = "0x600107F")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  public void SetContentInsetAdjustmentBehavior(UniWebViewContentInsetAdjustmentBehavior behavior)
  {
  }

  [Token(Token = "0x6001080")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void SetAllowAutoPlay(bool flag)
  {
  }

  [Token(Token = "0x6001081")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  public static void SetAllowInlinePlay(bool flag)
  {
  }

  [Token(Token = "0x6001082")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void SetJavaScriptEnabled(bool enabled)
  {
  }

  [Token(Token = "0x6001083")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void SetAllowJavaScriptOpenWindow(bool flag)
  {
  }

  [Token(Token = "0x6001084")]
  [Address(RVA = "0x12ACED0", Offset = "0x12ABCD0", VA = "0x112ACED0")]
  public void CleanCache()
  {
  }

  [Token(Token = "0x6001085")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void ClearCookies()
  {
  }

  [Token(Token = "0x6001086")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void SetCookie(string url, string cookie, bool skipEncoding = false)
  {
  }

  [Token(Token = "0x6001087")]
  [Address(RVA = "0x12AB390", Offset = "0x12AA190", VA = "0x112AB390")]
  public static string GetCookie(string url, string key, bool skipEncoding = false)
  {
    return (string) null;
  }

  [Token(Token = "0x6001088")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void ClearHttpAuthUsernamePassword(string host, string realm)
  {
  }

  [Token(Token = "0x170001E2")]
  public Color BackgroundColor
  {
    [Token(Token = "0x6001089"), Address(RVA = "0x12AE6E0", Offset = "0x12AD4E0", VA = "0x112AE6E0")] get
    {
      return new Color();
    }
    [Token(Token = "0x600108A"), Address(RVA = "0x12AEC40", Offset = "0x12ADA40", VA = "0x112AEC40")] set
    {
    }
  }

  [Token(Token = "0x170001E3")]
  public float Alpha
  {
    [Token(Token = "0x600108B"), Address(RVA = "0x12AE6A0", Offset = "0x12AD4A0", VA = "0x112AE6A0")] get
    {
      return new float();
    }
    [Token(Token = "0x600108C"), Address(RVA = "0x12ACED0", Offset = "0x12ABCD0", VA = "0x112ACED0")] set
    {
    }
  }

  [Token(Token = "0x600108D")]
  [Address(RVA = "0x12ACED0", Offset = "0x12ABCD0", VA = "0x112ACED0")]
  public void SetShowSpinnerWhileLoading(bool flag)
  {
  }

  [Token(Token = "0x600108E")]
  [Address(RVA = "0x12ACED0", Offset = "0x12ABCD0", VA = "0x112ACED0")]
  public void SetSpinnerText(string text)
  {
  }

  [Token(Token = "0x600108F")]
  [Address(RVA = "0x12ACED0", Offset = "0x12ABCD0", VA = "0x112ACED0")]
  public void SetHorizontalScrollBarEnabled(bool enabled)
  {
  }

  [Token(Token = "0x6001090")]
  [Address(RVA = "0x12ACED0", Offset = "0x12ABCD0", VA = "0x112ACED0")]
  public void SetVerticalScrollBarEnabled(bool enabled)
  {
  }

  [Token(Token = "0x6001091")]
  [Address(RVA = "0x12ACED0", Offset = "0x12ABCD0", VA = "0x112ACED0")]
  public void SetBouncesEnabled(bool enabled)
  {
  }

  [Token(Token = "0x6001092")]
  [Address(RVA = "0x12ACED0", Offset = "0x12ABCD0", VA = "0x112ACED0")]
  public void SetZoomEnabled(bool enabled)
  {
  }

  [Token(Token = "0x6001093")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  public void AddPermissionTrustDomain(string domain)
  {
  }

  [Token(Token = "0x6001094")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  public void RemovePermissionTrustDomain(string domain)
  {
  }

  [Token(Token = "0x6001095")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  public void SetBackButtonEnabled(bool enabled)
  {
  }

  [Token(Token = "0x6001096")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  public void SetUseWideViewPort(bool flag)
  {
  }

  [Token(Token = "0x6001097")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  public void SetLoadWithOverviewMode(bool flag)
  {
  }

  [Token(Token = "0x6001098")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  public void SetImmersiveModeEnabled(bool enabled)
  {
  }

  [Token(Token = "0x6001099")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  public void SetShowToolbar(bool show, bool animated = false, bool onTop = true, bool adjustInset = false)
  {
  }

  [Token(Token = "0x600109A")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  public void SetToolbarDoneButtonText(string text)
  {
  }

  [Token(Token = "0x600109B")]
  [Address(RVA = "0x12AB2B0", Offset = "0x12AA0B0", VA = "0x112AB2B0")]
  public static void SetWebContentsDebuggingEnabled(bool enabled)
  {
  }

  [Token(Token = "0x600109C")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  public void SetWindowUserResizeEnabled(bool enabled)
  {
  }

  [Token(Token = "0x600109D")]
  [Address(RVA = "0x12ACFB0", Offset = "0x12ABDB0", VA = "0x112ACFB0")]
  public void GetHTMLContent(Action<string> handler)
  {
  }

  [Token(Token = "0x600109E")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  public void SetAllowFileAccessFromFileURLs(bool flag)
  {
  }

  [Token(Token = "0x600109F")]
  [Address(RVA = "0x12ACED0", Offset = "0x12ABCD0", VA = "0x112ACED0")]
  public void SetAllowHTTPAuthPopUpWindow(bool flag)
  {
  }

  [Token(Token = "0x60010A0")]
  [Address(RVA = "0x12ACED0", Offset = "0x12ABCD0", VA = "0x112ACED0")]
  public void SetCalloutEnabled(bool enabled)
  {
  }

  [Token(Token = "0x60010A1")]
  [Address(RVA = "0x12ACED0", Offset = "0x12ABCD0", VA = "0x112ACED0")]
  public void SetSupportMultipleWindows(bool enabled)
  {
  }

  [Token(Token = "0x60010A2")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  public void SetDragInteractionEnabled(bool enabled)
  {
  }

  [Token(Token = "0x60010A3")]
  [Address(RVA = "0x12ACED0", Offset = "0x12ABCD0", VA = "0x112ACED0")]
  public void Print()
  {
  }

  [Token(Token = "0x60010A4")]
  [Address(RVA = "0x12ACED0", Offset = "0x12ABCD0", VA = "0x112ACED0")]
  public void ScrollTo(int x, int y, bool animated)
  {
  }

  [Token(Token = "0x60010A5")]
  [Address(RVA = "0x12ADAC0", Offset = "0x12AC8C0", VA = "0x112ADAC0")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x60010A6")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  private void OnApplicationPause(bool pause)
  {
  }

  [Token(Token = "0x60010A7")]
  [Address(RVA = "0x12AD660", Offset = "0x12AC460", VA = "0x112AD660")]
  internal void InternalOnShowTransitionFinished(string identifier)
  {
  }

  [Token(Token = "0x60010A8")]
  [Address(RVA = "0x12AD390", Offset = "0x12AC190", VA = "0x112AD390")]
  internal void InternalOnHideTransitionFinished(string identifier)
  {
  }

  [Token(Token = "0x60010A9")]
  [Address(RVA = "0x12AD260", Offset = "0x12AC060", VA = "0x112AD260")]
  internal void InternalOnAnimateToFinished(string identifier)
  {
  }

  [Token(Token = "0x60010AA")]
  [Address(RVA = "0x12AD1C0", Offset = "0x12ABFC0", VA = "0x112AD1C0")]
  internal void InternalOnAddJavaScriptFinished(UniWebViewNativeResultPayload payload)
  {
  }

  [Token(Token = "0x60010AB")]
  [Address(RVA = "0x12AD2F0", Offset = "0x12AC0F0", VA = "0x112AD2F0")]
  internal void InternalOnEvalJavaScriptFinished(UniWebViewNativeResultPayload payload)
  {
  }

  [Token(Token = "0x60010AC")]
  [Address(RVA = "0x12AD520", Offset = "0x12AC320", VA = "0x112AD520")]
  internal void InternalOnPageFinished(UniWebViewNativeResultPayload payload)
  {
  }

  [Token(Token = "0x60010AD")]
  [Address(RVA = "0x12AD5D0", Offset = "0x12AC3D0", VA = "0x112AD5D0")]
  internal void InternalOnPageStarted(string url)
  {
  }

  [Token(Token = "0x60010AE")]
  [Address(RVA = "0x12AD470", Offset = "0x12AC270", VA = "0x112AD470")]
  internal void InternalOnPageErrorReceived(UniWebViewNativeResultPayload payload)
  {
  }

  [Token(Token = "0x60010AF")]
  [Address(RVA = "0x12AD420", Offset = "0x12AC220", VA = "0x112AD420")]
  internal void InternalOnMessageReceived(string result)
  {
  }

  [Token(Token = "0x60010B0")]
  [Address(RVA = "0x12AD6F0", Offset = "0x12AC4F0", VA = "0x112AD6F0")]
  internal void InternalOnWebViewKeyDown(int keyCode)
  {
  }

  [Token(Token = "0x60010B1")]
  [Address(RVA = "0x12AD600", Offset = "0x12AC400", VA = "0x112AD600")]
  internal void InternalOnShouldClose()
  {
  }

  [Token(Token = "0x60010B2")]
  [Address(RVA = "0x12AD720", Offset = "0x12AC520", VA = "0x112AD720")]
  internal void InternalWebContentProcessDidTerminate()
  {
  }

  [Token(Token = "0x1400000E")]
  [Obsolete("OnOreintationChanged is a typo and deprecated. Use `OnOrientationChanged` instead.", true)]
  public event UniWebView.OrientationChangedDelegate OnOreintationChanged
  {
    [Token(Token = "0x60010B3"), Address(RVA = "0x12AE320", Offset = "0x12AD120", VA = "0x112AE320")] add
    {
    }
    [Token(Token = "0x60010B4"), Address(RVA = "0x12AE8C0", Offset = "0x12AD6C0", VA = "0x112AE8C0")] remove
    {
    }
  }

  [Token(Token = "0x60010B5")]
  [Address(RVA = "0x12AE130", Offset = "0x12ACF30", VA = "0x112AE130")]
  public UniWebView()
  {
  }

  [Token(Token = "0x2000319")]
  public delegate void PageStartedDelegate(UniWebView webView, string url);

  [Token(Token = "0x200031A")]
  public delegate void PageFinishedDelegate(UniWebView webView, int statusCode, string url);

  [Token(Token = "0x200031B")]
  public delegate void PageErrorReceivedDelegate(
    UniWebView webView,
    int errorCode,
    string errorMessage);

  [Token(Token = "0x200031C")]
  public delegate void MessageReceivedDelegate(UniWebView webView, UniWebViewMessage message);

  [Token(Token = "0x200031D")]
  public delegate bool ShouldCloseDelegate(UniWebView webView);

  [Token(Token = "0x200031E")]
  public delegate void KeyCodeReceivedDelegate(UniWebView webView, int keyCode);

  [Token(Token = "0x200031F")]
  public delegate void OrientationChangedDelegate(UniWebView webView, ScreenOrientation orientation);

  [Token(Token = "0x2000320")]
  public delegate void OnWebContentProcessTerminatedDelegate(UniWebView webView);

  [Token(Token = "0x2000321")]
  [Obsolete("OreintationChangedDelegate is a typo and deprecated. Use `OrientationChangedDelegate` instead.", true)]
  public delegate void OreintationChangedDelegate(UniWebView webView, ScreenOrientation orientation);
}
