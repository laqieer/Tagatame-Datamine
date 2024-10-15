// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_RaidPeriod
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200181D")]
  [FlowNode.NodeType("Raid/RaidPeriod", 32741)]
  [FlowNode.Pin(10, "Start", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(1000, "RAID開催中", FlowNode.PinTypes.Output, 1000)]
  [FlowNode.Pin(1001, "RAID期間外", FlowNode.PinTypes.Output, 1001)]
  [AddComponentMenu("")]
  public class FlowNode_RaidPeriod : FlowNode
  {
    [Token(Token = "0x40056B2")]
    private const int INPUT_START = 10;
    [Token(Token = "0x40056B3")]
    private const int OUTPUT_RAIDOPEN = 1000;
    [Token(Token = "0x40056B4")]
    private const int OUTPUT_RAIDCLOSE = 1001;
    [Token(Token = "0x40056B5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [HeaderBar("レイド開始時間を伸ばす(hour)")]
    private int beginAddHour;
    [Token(Token = "0x40056B6")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    [HeaderBar("レイド終了時間を伸ばす(hour)")]
    private int endAddHour;

    [Token(Token = "0x6006157")]
    [Address(RVA = "0x135BEC0", Offset = "0x135ACC0", VA = "0x1135BEC0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006158")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_RaidPeriod()
    {
    }
  }
}
