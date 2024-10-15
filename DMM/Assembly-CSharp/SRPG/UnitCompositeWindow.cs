// Decompiled with JetBrains decompiler
// Type: SRPG.UnitCompositeWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002BD2")]
  [AddComponentMenu("UI/UnitCompositeWindow")]
  [FlowNode.Pin(1, "Refresh", FlowNode.PinTypes.Input, 1)]
  public class UnitCompositeWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400D738")]
    [FieldOffset(Offset = "0xC")]
    public RectTransform ItemLayoutParent;
    [Token(Token = "0x400D739")]
    [FieldOffset(Offset = "0x10")]
    public RectTransform CommonItemLayoutParent;
    [Token(Token = "0x400D73A")]
    [FieldOffset(Offset = "0x14")]
    public GameObject ItemTemplate;
    [Token(Token = "0x400D73B")]
    [FieldOffset(Offset = "0x18")]
    public GameObject CommonItemTemplate;
    [Token(Token = "0x400D73C")]
    [FieldOffset(Offset = "0x1C")]
    private ItemParam mItemParam;
    [Token(Token = "0x400D73D")]
    [FieldOffset(Offset = "0x20")]
    private List<GameObject> mConsumeObjects;

    [Token(Token = "0x600C986")]
    [Address(RVA = "0x94D400", Offset = "0x94C200", VA = "0x1094D400")]
    private void Awake()
    {
    }

    [Token(Token = "0x600C987")]
    [Address(RVA = "0x94DDC0", Offset = "0x94CBC0", VA = "0x1094DDC0")]
    private void Start()
    {
    }

    [Token(Token = "0x600C988")]
    [Address(RVA = "0x94D3E0", Offset = "0x94C1E0", VA = "0x1094D3E0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C989")]
    [Address(RVA = "0x94D530", Offset = "0x94C330", VA = "0x1094D530")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600C98A")]
    [Address(RVA = "0x94D490", Offset = "0x94C290", VA = "0x1094D490")]
    public ItemData CreateItemData(string iname, int num) => (ItemData) null;

    [Token(Token = "0x600C98B")]
    [Address(RVA = "0x94DDD0", Offset = "0x94CBD0", VA = "0x1094DDD0")]
    public UnitCompositeWindow()
    {
    }
  }
}
