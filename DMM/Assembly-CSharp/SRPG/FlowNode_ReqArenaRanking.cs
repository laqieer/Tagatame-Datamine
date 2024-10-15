// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqArenaRanking
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001485")]
  [FlowNode.NodeType("Network/btl_colo_ranking")]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [AddComponentMenu("")]
  public class FlowNode_ReqArenaRanking : FlowNode_Network
  {
    [Token(Token = "0x4004BC5")]
    [FieldOffset(Offset = "0x20")]
    public ReqBtlColoRanking.RankingTypes RankingType;

    [Token(Token = "0x60055B9")]
    [Address(RVA = "0x12B6290", Offset = "0x12B5090", VA = "0x112B6290", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60055BA")]
    [Address(RVA = "0x1264AF0", Offset = "0x12638F0", VA = "0x11264AF0")]
    private void Success()
    {
    }

    [Token(Token = "0x60055BB")]
    [Address(RVA = "0x12B6390", Offset = "0x12B5190", VA = "0x112B6390", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60055BC")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqArenaRanking()
    {
    }
  }
}
