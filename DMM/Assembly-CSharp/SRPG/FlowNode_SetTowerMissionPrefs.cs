// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_SetTowerMissionPrefs
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001628")]
  [FlowNode.NodeType("Tower/SetTowerMissionPrefs", 32741)]
  [FlowNode.Pin(0, "ミッションID設定", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "設定完了", FlowNode.PinTypes.Output, 1)]
  [AddComponentMenu("")]
  public class FlowNode_SetTowerMissionPrefs : FlowNode
  {
    [Token(Token = "0x400504B")]
    private const int INPUT_SET_MISSION_ID = 0;
    [Token(Token = "0x400504C")]
    private const int OUTPUT_SET_MISSION_ID = 1;

    [Token(Token = "0x6005B0F")]
    [Address(RVA = "0x12FC2A0", Offset = "0x12FB0A0", VA = "0x112FC2A0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005B10")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_SetTowerMissionPrefs()
    {
    }
  }
}
