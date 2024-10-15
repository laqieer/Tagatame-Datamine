// Decompiled with JetBrains decompiler
// Type: SRPG.LimitedShopList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20026D6")]
  [FlowNode.Pin(101, "限定ショップが選択された", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("UI/LimitedShopList")]
  public class LimitedShopList : BaseShopList, IFlowInterface
  {
    [Token(Token = "0x600ADE3")]
    [Address(RVA = "0x71E2A0", Offset = "0x71D0A0", VA = "0x1071E2A0", Slot = "16")]
    protected override void OnSelectItem(ShopListItemModel model)
    {
    }

    [Token(Token = "0x600ADE4")]
    [Address(RVA = "0x5E23C0", Offset = "0x5E11C0", VA = "0x105E23C0")]
    public LimitedShopList()
    {
    }
  }
}
