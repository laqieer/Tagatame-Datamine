// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_WebView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200166D")]
  [FlowNode.NodeType("System/WebView", 32741)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "Created", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(2, "Destroyed", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(101, "Destroy", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(102, "Preload", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(100, "Create", FlowNode.PinTypes.Input, 0)]
  public class FlowNode_WebView : FlowNode
  {
    [Token(Token = "0x4005174")]
    private const int PIN_ID_CREATE = 100;
    [Token(Token = "0x4005175")]
    private const int PIN_ID_DESTROY = 101;
    [Token(Token = "0x4005176")]
    private const int PIN_ID_PRELOAD = 102;
    [Token(Token = "0x4005177")]
    private const int PIN_ID_CREATED = 1;
    [Token(Token = "0x4005178")]
    private const int PIN_ID_DESTROYED = 2;
    [Token(Token = "0x4005179")]
    private const string PREFAB_PATH = "UI/WebView";
    [Token(Token = "0x400517A")]
    public const string WEBVIEW_VALUELIST_KEY_URL = "WEBVIEW_VALUELIST_KEY_URL";
    [Token(Token = "0x400517B")]
    [FieldOffset(Offset = "0x18")]
    public string Title;
    [Token(Token = "0x400517C")]
    [FieldOffset(Offset = "0x1C")]
    public string URL;
    [Token(Token = "0x400517D")]
    [FieldOffset(Offset = "0x20")]
    public bool usegAuth;
    [Token(Token = "0x400517E")]
    [FieldOffset(Offset = "0x21")]
    public bool useVariable;
    [Token(Token = "0x400517F")]
    [FieldOffset(Offset = "0x22")]
    public bool resetVariable;
    [Token(Token = "0x4005180")]
    [FieldOffset(Offset = "0x24")]
    public SerializeValueBehaviour ValueList;
    [Token(Token = "0x4005181")]
    [FieldOffset(Offset = "0x28")]
    private WebView webView;
    [Token(Token = "0x4005182")]
    [FieldOffset(Offset = "0x2C")]
    private string originalURL;
    [Token(Token = "0x4005183")]
    [FieldOffset(Offset = "0x30")]
    public FlowNode_WebView.URL_Mode URLMode;

    [Token(Token = "0x6005C18")]
    [Address(RVA = "0x1315B50", Offset = "0x1314950", VA = "0x11315B50")]
    private void Create()
    {
    }

    [Token(Token = "0x6005C19")]
    [Address(RVA = "0x1272E30", Offset = "0x1271C30", VA = "0x11272E30")]
    public void OnClose(GameObject go)
    {
    }

    [Token(Token = "0x6005C1A")]
    [Address(RVA = "0x1316220", Offset = "0x1315020", VA = "0x11316220", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005C1B")]
    [Address(RVA = "0x1296EE0", Offset = "0x1295CE0", VA = "0x11296EE0")]
    public FlowNode_WebView()
    {
    }

    [Token(Token = "0x200166E")]
    public enum URL_Mode
    {
      [Token(Token = "0x4005185")] APIHost,
      [Token(Token = "0x4005186")] SiteHost,
      [Token(Token = "0x4005187")] NewsHost,
    }
  }
}
