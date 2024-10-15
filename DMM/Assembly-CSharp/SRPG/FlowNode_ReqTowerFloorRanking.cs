// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqTowerFloorRanking
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20015BA")]
  [FlowNode.Pin(100, "ランキングを取得完了", FlowNode.PinTypes.Output, 100)]
  [FlowNode.NodeType("Request/Tower/Floor/Ranking", 32741)]
  [FlowNode.Pin(1, "この階層のランキングを取得", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("")]
  public class FlowNode_ReqTowerFloorRanking : FlowNode_Network
  {
    [Token(Token = "0x4004F17")]
    private const int INPUT_REQUEST_RANKING = 1;
    [Token(Token = "0x4004F18")]
    private const int OUTPUT_REQUEST_RANKING = 100;

    [Token(Token = "0x600596D")]
    [Address(RVA = "0x12E08F0", Offset = "0x12DF6F0", VA = "0x112E08F0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600596E")]
    [Address(RVA = "0x12E09E0", Offset = "0x12DF7E0", VA = "0x112E09E0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600596F")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqTowerFloorRanking()
    {
    }
  }
}
