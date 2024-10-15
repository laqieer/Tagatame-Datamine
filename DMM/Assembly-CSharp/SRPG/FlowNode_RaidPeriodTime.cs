// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_RaidPeriodTime
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200181E")]
  [AddComponentMenu("")]
  [FlowNode.Pin(1003, "RAIDスケジュール指定で停止中", FlowNode.PinTypes.Output, 1003)]
  [FlowNode.Pin(1002, "RAIDスケジュール指定で開催中", FlowNode.PinTypes.Output, 1002)]
  [FlowNode.Pin(1000, "RAID指定なしで開催中", FlowNode.PinTypes.Output, 1000)]
  [FlowNode.Pin(10, "Start", FlowNode.PinTypes.Input, 10)]
  [FlowNode.NodeType("Raid/RaidPeriodTime", 32741)]
  [FlowNode.Pin(1001, "RAID期間終了", FlowNode.PinTypes.Output, 1001)]
  public class FlowNode_RaidPeriodTime : FlowNode
  {
    [Token(Token = "0x40056B7")]
    private const int INPUT_START = 10;
    [Token(Token = "0x40056B8")]
    private const int OUTPUT_RAIDTIMEOPEN = 1000;
    [Token(Token = "0x40056B9")]
    private const int OUTPUT_RAIDTIMECLOSE = 1001;
    [Token(Token = "0x40056BA")]
    private const int OUTPUT_RAIDTIMEOPENSCHEDULE = 1002;
    [Token(Token = "0x40056BB")]
    private const int OUTPUT_RAIDTIMECLOSESCHEDULE = 1003;

    [Token(Token = "0x6006159")]
    [Address(RVA = "0x135BDF0", Offset = "0x135ABF0", VA = "0x1135BDF0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600615A")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_RaidPeriodTime()
    {
    }
  }
}
