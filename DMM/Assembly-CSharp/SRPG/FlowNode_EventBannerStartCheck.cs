// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_EventBannerStartCheck
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20013D1")]
  [AddComponentMenu("")]
  [FlowNode.Pin(10, "Finished", FlowNode.PinTypes.Output, 10)]
  [FlowNode.NodeType("SRPG/EventBannerStartCheck", 32741)]
  [FlowNode.Pin(1, "Check", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_EventBannerStartCheck : FlowNode
  {
    [Token(Token = "0x400495B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private AppealItemLimitedShop LimitedShopAppealItem;

    [Token(Token = "0x60052EE")]
    [Address(RVA = "0x127AD40", Offset = "0x1279B40", VA = "0x1127AD40", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60052EF")]
    [Address(RVA = "0x127ADB0", Offset = "0x1279BB0", VA = "0x1127ADB0")]
    private IEnumerator UpdateEventBanner() => (IEnumerator) null;

    [Token(Token = "0x60052F0")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_EventBannerStartCheck()
    {
    }
  }
}
