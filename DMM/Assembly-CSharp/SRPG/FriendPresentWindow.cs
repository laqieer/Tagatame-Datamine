// Decompiled with JetBrains decompiler
// Type: SRPG.FriendPresentWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002402")]
  [FlowNode.Pin(160, "ウィッシュリスト更新", FlowNode.PinTypes.Input, 160)]
  [FlowNode.Pin(140, "一括受け取り", FlowNode.PinTypes.Input, 140)]
  [FlowNode.Pin(130, "贈るタブ", FlowNode.PinTypes.Input, 130)]
  [FlowNode.Pin(120, "受け取りタブ", FlowNode.PinTypes.Input, 120)]
  [FlowNode.Pin(110, "ルートウィンド閉じる", FlowNode.PinTypes.Input, 110)]
  [FlowNode.NodeType("UI/FriendPresentWindow", 32741)]
  [FlowNode.Pin(150, "一括送信", FlowNode.PinTypes.Input, 150)]
  [FlowNode.Pin(100, "ルートウィンド開く", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(170, "受け取りリスト更新", FlowNode.PinTypes.Input, 170)]
  [FlowNode.Pin(180, "贈るリスト更新", FlowNode.PinTypes.Input, 180)]
  [FlowNode.Pin(171, "受け取りリストクリア", FlowNode.PinTypes.Input, 171)]
  [FlowNode.Pin(390, "贈ってくれた人ウィンド閉じた", FlowNode.PinTypes.Output, 1020)]
  [FlowNode.Pin(290, "欲しいものウィンド閉じた", FlowNode.PinTypes.Output, 1010)]
  [FlowNode.Pin(190, "ルートウィンド閉じた", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(191, "ルートウィンド開いた", FlowNode.PinTypes.Output, 1000)]
  [AddComponentMenu("")]
  [FlowNode.Pin(300, "贈ってくれた人ウィンド開く", FlowNode.PinTypes.Input, 300)]
  [FlowNode.Pin(220, "欲しいもの選択", FlowNode.PinTypes.Input, 220)]
  [FlowNode.Pin(210, "欲しいものウィンド閉じる", FlowNode.PinTypes.Input, 210)]
  [FlowNode.Pin(200, "欲しいものウィンド開く", FlowNode.PinTypes.Input, 200)]
  [FlowNode.Pin(310, "贈ってくれた人ウィンド閉じる", FlowNode.PinTypes.Input, 310)]
  public class FriendPresentWindow : FlowNodePersistent
  {
    [Token(Token = "0x400A2A2")]
    public const int INPUT_ROOTWINDOW_OPEN = 100;
    [Token(Token = "0x400A2A3")]
    public const int INPUT_ROOTWINDOW_CLOSE = 110;
    [Token(Token = "0x400A2A4")]
    public const int INPUT_ROOTWINDOW_TAB_RECEIVE = 120;
    [Token(Token = "0x400A2A5")]
    public const int INPUT_ROOTWINDOW_TAB_SEND = 130;
    [Token(Token = "0x400A2A6")]
    public const int INPUT_ROOTWINDOW_RECEIVEALL = 140;
    [Token(Token = "0x400A2A7")]
    public const int INPUT_ROOTWINDOW_SENDALL = 150;
    [Token(Token = "0x400A2A8")]
    public const int INPUT_ROOTWINDOW_REFRESH_WISHLIST = 160;
    [Token(Token = "0x400A2A9")]
    public const int INPUT_ROOTWINDOW_REFRESH_RECEIVELIST = 170;
    [Token(Token = "0x400A2AA")]
    public const int INPUT_ROOTWINDOW_CLEAR_RECEIVELIST = 171;
    [Token(Token = "0x400A2AB")]
    public const int INPUT_ROOTWINDOW_REFRESH_SENDLIST = 180;
    [Token(Token = "0x400A2AC")]
    public const int OUTPUT_ROOTWINDOW_CLOSED = 190;
    [Token(Token = "0x400A2AD")]
    public const int OUTPUT_ROOTWINDOW_OPEND = 191;
    [Token(Token = "0x400A2AE")]
    public const int INPUT_WANTWINDOW_OPEN = 200;
    [Token(Token = "0x400A2AF")]
    public const int INPUT_WANTWINDOW_CLOSE = 210;
    [Token(Token = "0x400A2B0")]
    public const int INPUT_WANTWINDOW_ITEMSELECT = 220;
    [Token(Token = "0x400A2B1")]
    public const int OUTPUT_WANTWINDOW_CLOSED = 290;
    [Token(Token = "0x400A2B2")]
    public const int INPUT_GAVEWINDOW_OPEN = 300;
    [Token(Token = "0x400A2B3")]
    public const int INPUT_GAVEWINDOW_CLOSE = 310;
    [Token(Token = "0x400A2B4")]
    public const int OUTPUT_GAVEWINDOW_CLOSED = 390;
    [Token(Token = "0x400A2B5")]
    [FieldOffset(Offset = "0x18")]
    public FriendPresentRootWindow.SerializeParam m_RootWindowParam;
    [Token(Token = "0x400A2B6")]
    [FieldOffset(Offset = "0x1C")]
    public FriendPresentWantWindow.SerializeParam m_WantWindowParam;
    [Token(Token = "0x400A2B7")]
    [FieldOffset(Offset = "0x20")]
    public FriendPresentGaveWindow.SerializeParam m_GaveWindowParam;
    [Token(Token = "0x400A2B8")]
    [FieldOffset(Offset = "0x24")]
    private FlowWindowController m_WindowController;

    [Token(Token = "0x6009CA6")]
    [Address(RVA = "0x5F87F0", Offset = "0x5F75F0", VA = "0x105F87F0", Slot = "7")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x6009CA7")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Start()
    {
    }

    [Token(Token = "0x6009CA8")]
    [Address(RVA = "0x5F88E0", Offset = "0x5F76E0", VA = "0x105F88E0", Slot = "8")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x6009CA9")]
    [Address(RVA = "0x5F8910", Offset = "0x5F7710", VA = "0x105F8910")]
    private void Update()
    {
    }

    [Token(Token = "0x6009CAA")]
    [Address(RVA = "0x5F88B0", Offset = "0x5F76B0", VA = "0x105F88B0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6009CAB")]
    [Address(RVA = "0x5F8940", Offset = "0x5F7740", VA = "0x105F8940")]
    public FriendPresentWindow()
    {
    }
  }
}
