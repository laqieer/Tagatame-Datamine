// Decompiled with JetBrains decompiler
// Type: SRPG.MultiInvitationWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200278A")]
  [FlowNode.Pin(210, "受け取りウィンド閉じる", FlowNode.PinTypes.Input, 210)]
  [FlowNode.NodeType("UI/MultiInvitationWindow", 32741)]
  [AddComponentMenu("")]
  [FlowNode.Pin(300, "タブ切り替え完了", FlowNode.PinTypes.Output, 300)]
  [FlowNode.Pin(220, "アクティブタブ", FlowNode.PinTypes.Input, 220)]
  [FlowNode.Pin(260, "履歴リスト更新", FlowNode.PinTypes.Input, 260)]
  [FlowNode.Pin(250, "アクティブリスト更新", FlowNode.PinTypes.Input, 250)]
  [FlowNode.Pin(240, "プレイ", FlowNode.PinTypes.Input, 240)]
  [FlowNode.Pin(290, "受け取りウィンド閉じた", FlowNode.PinTypes.Output, 290)]
  [FlowNode.Pin(110, "送信ウィンド閉じる", FlowNode.PinTypes.Input, 110)]
  [FlowNode.Pin(120, "送信フレンド選択", FlowNode.PinTypes.Input, 120)]
  [FlowNode.Pin(230, "履歴タブ", FlowNode.PinTypes.Input, 230)]
  [FlowNode.Pin(190, "送信準備完了", FlowNode.PinTypes.Output, 190)]
  [FlowNode.Pin(191, "送信ウィンド閉じた", FlowNode.PinTypes.Output, 191)]
  [FlowNode.Pin(200, "受け取りウィンド開く", FlowNode.PinTypes.Input, 200)]
  [FlowNode.Pin(100, "送信ウィンド開く", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(130, "送信準備", FlowNode.PinTypes.Input, 130)]
  public class MultiInvitationWindow : FlowNodePersistent
  {
    [Token(Token = "0x400BAB1")]
    public const int INPUT_SENDWINDOW_OPEN = 100;
    [Token(Token = "0x400BAB2")]
    public const int INPUT_SENDWINDOW_CLOSE = 110;
    [Token(Token = "0x400BAB3")]
    public const int INPUT_SENDWINDOW_SELECTFRIEND = 120;
    [Token(Token = "0x400BAB4")]
    public const int INPUT_SENDWINDOW_SEND = 130;
    [Token(Token = "0x400BAB5")]
    public const int OUTPUT_SENDWINDOW_SENDOK = 190;
    [Token(Token = "0x400BAB6")]
    public const int OUTPUT_SENDWINDOW_CLOSED = 191;
    [Token(Token = "0x400BAB7")]
    public const int INPUT_RECEIVEWINDOW_OPEN = 200;
    [Token(Token = "0x400BAB8")]
    public const int INPUT_RECEIVEWINDOW_CLOSE = 210;
    [Token(Token = "0x400BAB9")]
    public const int INPUT_RECEIVEWINDOW_TAB_ACTIVE = 220;
    [Token(Token = "0x400BABA")]
    public const int INPUT_RECEIVEWINDOW_TAB_LOG = 230;
    [Token(Token = "0x400BABB")]
    public const int INPUT_RECEIVEWINDOW_PLAY = 240;
    [Token(Token = "0x400BABC")]
    public const int INPUT_RECEIVEWINDOW_REFRESH_ACTIVELIST = 250;
    [Token(Token = "0x400BABD")]
    public const int INPUT_RECEIVEWINDOW_REFRESH_LOGLIST = 260;
    [Token(Token = "0x400BABE")]
    public const int OUTPUT_RECEIVEWINDOW_CLOSED = 290;
    [Token(Token = "0x400BABF")]
    public const int OUTPUT_RECEIVEWINDOW_TBCHANGED = 300;
    [Token(Token = "0x400BAC0")]
    [FieldOffset(Offset = "0x18")]
    public MultiInvitationSendWindow.SerializeParam m_SendWindowParam;
    [Token(Token = "0x400BAC1")]
    [FieldOffset(Offset = "0x1C")]
    public MultiInvitationReceiveWindow.SerializeParam m_ReceiveWindowParam;
    [Token(Token = "0x400BAC2")]
    [FieldOffset(Offset = "0x20")]
    private FlowWindowController m_WindowController;

    [Token(Token = "0x600B15A")]
    [Address(RVA = "0x757370", Offset = "0x756170", VA = "0x10757370", Slot = "7")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x600B15B")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Start()
    {
    }

    [Token(Token = "0x600B15C")]
    [Address(RVA = "0x757400", Offset = "0x756200", VA = "0x10757400", Slot = "8")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x600B15D")]
    [Address(RVA = "0x757430", Offset = "0x756230", VA = "0x10757430")]
    private void Update()
    {
    }

    [Token(Token = "0x600B15E")]
    [Address(RVA = "0x7573D0", Offset = "0x7561D0", VA = "0x107573D0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600B15F")]
    [Address(RVA = "0x757460", Offset = "0x756260", VA = "0x10757460")]
    public MultiInvitationWindow()
    {
    }
  }
}
