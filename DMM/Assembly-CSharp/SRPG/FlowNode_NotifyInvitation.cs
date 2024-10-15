// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_NotifyInvitation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001447")]
  [FlowNode.NodeType("System/Notify/Invitation", 32741)]
  [FlowNode.Pin(100, "通知監視開始", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(110, "通知監視停止", FlowNode.PinTypes.Input, 110)]
  [FlowNode.Pin(120, "通知監視リセット", FlowNode.PinTypes.Input, 120)]
  [FlowNode.Pin(191, "通知チェック", FlowNode.PinTypes.Output, 190)]
  [AddComponentMenu("")]
  public class FlowNode_NotifyInvitation : FlowNodePersistent
  {
    [Token(Token = "0x4004AFD")]
    public const int INPUT_NOTIFYMONITOR_START = 100;
    [Token(Token = "0x4004AFE")]
    public const int INPUT_NOTIFYMONITOR_STOP = 110;
    [Token(Token = "0x4004AFF")]
    public const int INPUT_NOTIFYMONITOR_RESET = 120;
    [Token(Token = "0x4004B00")]
    public const int OUTPUT_NOTIFY_GO = 191;
    [Token(Token = "0x4004B01")]
    [FieldOffset(Offset = "0x18")]
    public float m_Interval;
    [Token(Token = "0x4004B02")]
    [FieldOffset(Offset = "0x1C")]
    private bool m_Monitor;
    [Token(Token = "0x4004B03")]
    [FieldOffset(Offset = "0x20")]
    private float m_Time;

    [Token(Token = "0x60054BD")]
    [Address(RVA = "0x1293190", Offset = "0x1291F90", VA = "0x11293190", Slot = "7")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x60054BE")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Start()
    {
    }

    [Token(Token = "0x60054BF")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0", Slot = "8")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x60054C0")]
    [Address(RVA = "0x1293420", Offset = "0x1292220", VA = "0x11293420")]
    private void Update()
    {
    }

    [Token(Token = "0x60054C1")]
    [Address(RVA = "0x12931A0", Offset = "0x1291FA0", VA = "0x112931A0")]
    private bool CanNotifyGo() => new bool();

    [Token(Token = "0x60054C2")]
    [Address(RVA = "0x1293380", Offset = "0x1292180", VA = "0x11293380", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60054C3")]
    [Address(RVA = "0x12934C0", Offset = "0x12922C0", VA = "0x112934C0")]
    public FlowNode_NotifyInvitation()
    {
    }
  }
}
