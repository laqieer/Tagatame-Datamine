// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_SetShopType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001626")]
  [FlowNode.Pin(111, "Port", FlowNode.PinTypes.Input, 111)]
  [FlowNode.NodeType("System/Shop/SetShopType", 32741)]
  [FlowNode.Pin(100, "Normal", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(101, "Tabi", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(102, "Kimagure", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(103, "Monozuki", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(104, "Arena", FlowNode.PinTypes.Input, 4)]
  [FlowNode.Pin(105, "Tour", FlowNode.PinTypes.Input, 5)]
  [FlowNode.Pin(106, "Multi", FlowNode.PinTypes.Input, 6)]
  [FlowNode.Pin(107, "AwakePiece", FlowNode.PinTypes.Input, 7)]
  [FlowNode.Pin(109, "Limited", FlowNode.PinTypes.Input, 9)]
  [FlowNode.Pin(110, "Gurrilla", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(112, "Duel", FlowNode.PinTypes.Input, 112)]
  [FlowNode.Pin(113, "LeagueMatch", FlowNode.PinTypes.Input, 113)]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1000)]
  [AddComponentMenu("")]
  [FlowNode.Pin(108, "Artifact", FlowNode.PinTypes.Input, 8)]
  public class FlowNode_SetShopType : FlowNode
  {
    [Token(Token = "0x4005048")]
    private const int PIN_IN_SHOP_PORT = 111;
    [Token(Token = "0x4005049")]
    private const int PIN_IN_SHOP_DUEL = 112;
    [Token(Token = "0x400504A")]
    private const int PIN_IN_SHOP_LEAGUEMATCH = 113;

    [Token(Token = "0x6005B09")]
    [Address(RVA = "0x12FBF20", Offset = "0x12FAD20", VA = "0x112FBF20", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005B0A")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_SetShopType()
    {
    }
  }
}
