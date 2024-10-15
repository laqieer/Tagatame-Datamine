// Decompiled with JetBrains decompiler
// Type: SRPG.Flownode_ShopCrystalBuyConfirm
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200162B")]
  [FlowNode.Pin(11, "Buy Other", FlowNode.PinTypes.Output, 11)]
  [FlowNode.NodeType("System/Shop/Flownode_ShopCrystalBuyConfirm", 32741)]
  [FlowNode.Pin(1, "start", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(10, "Buy Crystal", FlowNode.PinTypes.Output, 10)]
  [AddComponentMenu("")]
  public class Flownode_ShopCrystalBuyConfirm : FlowNode
  {
    [Token(Token = "0x4005059")]
    private const int PINID_START = 1;
    [Token(Token = "0x400505A")]
    private const int PINOUT_BUY_CRYSTAL = 10;
    [Token(Token = "0x400505B")]
    private const int PINOUT_BUY_OTHER = 11;

    [Token(Token = "0x6005B17")]
    [Address(RVA = "0x1301ED0", Offset = "0x1300CD0", VA = "0x11301ED0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005B18")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public Flownode_ShopCrystalBuyConfirm()
    {
    }
  }
}
