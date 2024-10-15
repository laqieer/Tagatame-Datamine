// Decompiled with JetBrains decompiler
// Type: SRPG.WebView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D34")]
  [AddComponentMenu("UI/WebView")]
  public class WebView : MonoBehaviour
  {
    [Token(Token = "0x400E154")]
    [FieldOffset(Offset = "0xC")]
    public Text Text_Title;
    [Token(Token = "0x400E155")]
    [FieldOffset(Offset = "0x10")]
    public Button Btn_Close;
    [Token(Token = "0x400E156")]
    [FieldOffset(Offset = "0x14")]
    public RawImage ClientArea;
    [Token(Token = "0x400E157")]
    [FieldOffset(Offset = "0x18")]
    public UIUtility.DialogResultEvent OnClose;

    [Token(Token = "0x600D2A2")]
    [Address(RVA = "0x9DBB20", Offset = "0x9DA920", VA = "0x109DBB20")]
    public void BeginClose()
    {
    }

    [Token(Token = "0x600D2A3")]
    [Address(RVA = "0x9DBBB0", Offset = "0x9DA9B0", VA = "0x109DBBB0")]
    private void OnClickButton(GameObject obj)
    {
    }

    [Token(Token = "0x600D2A4")]
    [Address(RVA = "0x9DBD00", Offset = "0x9DAB00", VA = "0x109DBD00")]
    public void SetTitleText(string text)
    {
    }

    [Token(Token = "0x600D2A5")]
    [Address(RVA = "0x9DBA50", Offset = "0x9DA850", VA = "0x109DBA50")]
    private void Awake()
    {
    }

    [Token(Token = "0x600D2A6")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void SetHeaderField(string key, string value)
    {
    }

    [Token(Token = "0x600D2A7")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void OpenURL(string url, bool reopen = false)
    {
    }

    [Token(Token = "0x600D2A8")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public WebView()
    {
    }
  }
}
