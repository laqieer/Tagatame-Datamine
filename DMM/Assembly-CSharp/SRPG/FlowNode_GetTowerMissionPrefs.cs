// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_GetTowerMissionPrefs
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20013FA")]
  [FlowNode.NodeType("Tower/GetTowerMissionPrefs", 32741)]
  [FlowNode.Pin(0, "ミッションID取得", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "取得成功", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(2, "取得出来ない", FlowNode.PinTypes.Output, 2)]
  [AddComponentMenu("")]
  public class FlowNode_GetTowerMissionPrefs : FlowNode
  {
    [Token(Token = "0x40049F2")]
    private const int INPUT_GET_MISSION_ID = 0;
    [Token(Token = "0x40049F3")]
    private const int OUTPUT_SUCCESS_GET_MISSION_ID = 1;
    [Token(Token = "0x40049F4")]
    private const int OUTPUT_NONE_GET_MISSION_ID = 2;

    [Token(Token = "0x6005396")]
    [Address(RVA = "0x1281DD0", Offset = "0x1280BD0", VA = "0x11281DD0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005397")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_GetTowerMissionPrefs()
    {
    }
  }
}
