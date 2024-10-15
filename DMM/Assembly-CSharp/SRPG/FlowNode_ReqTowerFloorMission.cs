// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqTowerFloorMission
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20015B9")]
  [FlowNode.Pin(1, "ミッション進捗を取得", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("Request/Tower/Floor/Mission", 32741)]
  [FlowNode.Pin(100, "ミッション進捗を取得完了", FlowNode.PinTypes.Output, 100)]
  public class FlowNode_ReqTowerFloorMission : FlowNode_Network
  {
    [Token(Token = "0x4004F15")]
    private const int INPUT_REQUEST_MISSION = 1;
    [Token(Token = "0x4004F16")]
    private const int OUTPUT_REQUEST_MISSION = 100;

    [Token(Token = "0x600596A")]
    [Address(RVA = "0x12E0570", Offset = "0x12DF370", VA = "0x112E0570", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600596B")]
    [Address(RVA = "0x12E0660", Offset = "0x12DF460", VA = "0x112E0660", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600596C")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqTowerFloorMission()
    {
    }
  }
}
