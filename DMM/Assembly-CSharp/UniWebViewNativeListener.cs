// Decompiled with JetBrains decompiler
// Type: UniWebViewNativeListener
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000328")]
public class UniWebViewNativeListener : MonoBehaviour
{
  [Token(Token = "0x4000CEC")]
  [FieldOffset(Offset = "0x0")]
  private static Dictionary<string, UniWebViewNativeListener> listeners;
  [Token(Token = "0x4000CED")]
  [FieldOffset(Offset = "0xC")]
  [HideInInspector]
  public UniWebView webView;

  [Token(Token = "0x60010F1")]
  [Address(RVA = "0x12ABE60", Offset = "0x12AAC60", VA = "0x112ABE60")]
  public static void AddListener(UniWebViewNativeListener target)
  {
  }

  [Token(Token = "0x60010F2")]
  [Address(RVA = "0x12AC5A0", Offset = "0x12AB3A0", VA = "0x112AC5A0")]
  public static void RemoveListener(string name)
  {
  }

  [Token(Token = "0x60010F3")]
  [Address(RVA = "0x12AC0E0", Offset = "0x12AAEE0", VA = "0x112AC0E0")]
  public static UniWebViewNativeListener GetListener(string name)
  {
    return (UniWebViewNativeListener) null;
  }

  [Token(Token = "0x170001EA")]
  public string Name
  {
    [Token(Token = "0x60010F4"), Address(RVA = "0x12AC960", Offset = "0x12AB760", VA = "0x112AC960")] get
    {
      return (string) null;
    }
  }

  [Token(Token = "0x60010F5")]
  [Address(RVA = "0x12AC520", Offset = "0x12AB320", VA = "0x112AC520")]
  public void PageStarted(string url)
  {
  }

  [Token(Token = "0x60010F6")]
  [Address(RVA = "0x12AC400", Offset = "0x12AB200", VA = "0x112AC400")]
  public void PageFinished(string result)
  {
  }

  [Token(Token = "0x60010F7")]
  [Address(RVA = "0x12AC2E0", Offset = "0x12AB0E0", VA = "0x112AC2E0")]
  public void PageErrorReceived(string result)
  {
  }

  [Token(Token = "0x60010F8")]
  [Address(RVA = "0x12AC610", Offset = "0x12AB410", VA = "0x112AC610")]
  public void ShowTransitionFinished(string identifer)
  {
  }

  [Token(Token = "0x60010F9")]
  [Address(RVA = "0x12AC160", Offset = "0x12AAF60", VA = "0x112AC160")]
  public void HideTransitionFinished(string identifer)
  {
  }

  [Token(Token = "0x60010FA")]
  [Address(RVA = "0x12ABEF0", Offset = "0x12AACF0", VA = "0x112ABEF0")]
  public void AnimateToFinished(string identifer)
  {
  }

  [Token(Token = "0x60010FB")]
  [Address(RVA = "0x12ABD50", Offset = "0x12AAB50", VA = "0x112ABD50")]
  public void AddJavaScriptFinished(string result)
  {
  }

  [Token(Token = "0x60010FC")]
  [Address(RVA = "0x12ABFD0", Offset = "0x12AADD0", VA = "0x112ABFD0")]
  public void EvalJavaScriptFinished(string result)
  {
  }

  [Token(Token = "0x60010FD")]
  [Address(RVA = "0x12AC240", Offset = "0x12AB040", VA = "0x112AC240")]
  public void MessageReceived(string result)
  {
  }

  [Token(Token = "0x60010FE")]
  [Address(RVA = "0x12AC810", Offset = "0x12AB610", VA = "0x112AC810")]
  public void WebViewKeyDown(string keyCode)
  {
  }

  [Token(Token = "0x60010FF")]
  [Address(RVA = "0x12AC760", Offset = "0x12AB560", VA = "0x112AC760")]
  public void WebViewDone(string param)
  {
  }

  [Token(Token = "0x6001100")]
  [Address(RVA = "0x12AC6F0", Offset = "0x12AB4F0", VA = "0x112AC6F0")]
  public void WebContentProcessDidTerminate(string param)
  {
  }

  [Token(Token = "0x6001101")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public UniWebViewNativeListener()
  {
  }

  [Token(Token = "0x6001102")]
  [Address(RVA = "0x12AC8E0", Offset = "0x12AB6E0", VA = "0x112AC8E0")]
  static UniWebViewNativeListener()
  {
  }
}
