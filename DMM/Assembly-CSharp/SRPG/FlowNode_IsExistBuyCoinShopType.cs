// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_IsExistBuyCoinShopType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001310")]
  [FlowNode.Pin(0, "Input", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("System/Buy/BuyCoinTypeExist", 32741)]
  [FlowNode.Pin(10, "Exist", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(11, "NotExist", FlowNode.PinTypes.Output, 11)]
  [AddComponentMenu("")]
  public class FlowNode_IsExistBuyCoinShopType : FlowNode
  {
    [Token(Token = "0x40046C5")]
    private const int PIN_INPUT = 0;
    [Token(Token = "0x40046C6")]
    private const int PIN_OUTPUT_EXIST = 10;
    [Token(Token = "0x40046C7")]
    private const int PIN_OUTPUT_NOT_EXIST = 11;
    [Token(Token = "0x40046C8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private BuyCoinManager.BuyCoinShopType mShopType;

    [Token(Token = "0x6005072")]
    [Address(RVA = "0x124FAD0", Offset = "0x124E8D0", VA = "0x1124FAD0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005073")]
    [Address(RVA = "0x124F9E0", Offset = "0x124E7E0", VA = "0x1124F9E0")]
    public static bool IsExistShopItem(BuyCoinManager.BuyCoinShopType type) => new bool();

    [Token(Token = "0x6005074")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_IsExistBuyCoinShopType()
    {
    }
  }
}
