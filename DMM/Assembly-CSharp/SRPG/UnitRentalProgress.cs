// Decompiled with JetBrains decompiler
// Type: SRPG.UnitRentalProgress
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002CED")]
  [FlowNode.Pin(0, "Open", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Close", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "Refresh", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(10, "パネル表示", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(11, "ヘルプ表示", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(21, "好感度MAXじゃない", FlowNode.PinTypes.Output, 21)]
  [FlowNode.Pin(31, "好感度MAX", FlowNode.PinTypes.Output, 31)]
  [AddComponentMenu("UI/UnitRental/UnitRentalProgress")]
  public class UnitRentalProgress : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400DF52")]
    public const int PIN_OPEN = 0;
    [Token(Token = "0x400DF53")]
    public const int PIN_CLOSE = 1;
    [Token(Token = "0x400DF54")]
    public const int PIN_REFRESH = 2;
    [Token(Token = "0x400DF55")]
    public const int PIN_SHOW_PANEL = 10;
    [Token(Token = "0x400DF56")]
    public const int PIN_SHOW_HELP = 11;
    [Token(Token = "0x400DF57")]
    public const int PIN_OUT_FAVOLIT_POINT_NOT_MAX = 21;
    [Token(Token = "0x400DF58")]
    public const int PIN_OUT_FAVOLIT_POINT_MAX = 31;
    [Token(Token = "0x400DF59")]
    [FieldOffset(Offset = "0xC")]
    public Button ButtonHelp;
    [Token(Token = "0x400DF5A")]
    [FieldOffset(Offset = "0x10")]
    public Button ButtonDetail;
    [Token(Token = "0x400DF5B")]
    [FieldOffset(Offset = "0x14")]
    public Button ButtonReward;
    [Token(Token = "0x400DF5C")]
    [FieldOffset(Offset = "0x18")]
    private readonly string EVENT_UNIT_RENTALICON_SHOW;
    [Token(Token = "0x400DF5D")]
    [FieldOffset(Offset = "0x1C")]
    private readonly string EVENT_UNIT_RENTALICON_HIDE;

    [Token(Token = "0x600D111")]
    [Address(RVA = "0x9C0D00", Offset = "0x9BFB00", VA = "0x109C0D00", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600D112")]
    [Address(RVA = "0x9C1320", Offset = "0x9C0120", VA = "0x109C1320")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x600D113")]
    [Address(RVA = "0x9C12D0", Offset = "0x9C00D0", VA = "0x109C12D0")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x600D114")]
    [Address(RVA = "0x9C0D90", Offset = "0x9BFB90", VA = "0x109C0D90")]
    private void Awake()
    {
    }

    [Token(Token = "0x600D115")]
    [Address(RVA = "0x9C1120", Offset = "0x9BFF20", VA = "0x109C1120")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600D116")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Update()
    {
    }

    [Token(Token = "0x600D117")]
    [Address(RVA = "0x9C1370", Offset = "0x9C0170", VA = "0x109C1370")]
    private void Refresh(bool fromRefresh)
    {
    }

    [Token(Token = "0x600D118")]
    [Address(RVA = "0x9C0F40", Offset = "0x9BFD40", VA = "0x109C0F40")]
    private void OnClickDetail()
    {
    }

    [Token(Token = "0x600D119")]
    [Address(RVA = "0x9C0F60", Offset = "0x9BFD60", VA = "0x109C0F60")]
    private void OnClickHelp()
    {
    }

    [Token(Token = "0x600D11A")]
    [Address(RVA = "0x9C1490", Offset = "0x9C0290", VA = "0x109C1490")]
    public UnitRentalProgress()
    {
    }
  }
}
