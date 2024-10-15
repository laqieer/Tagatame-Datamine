// Decompiled with JetBrains decompiler
// Type: SRPG.TowerQuestList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B51")]
  [FlowNode.Pin(0, "更新", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(100, "フロア選択", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("UI/TowerQuestList")]
  public class TowerQuestList : MonoBehaviour, IFlowInterface, ScrollListSetUp
  {
    [Token(Token = "0x400D3E1")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private TowerQuestInfo info;
    [Token(Token = "0x400D3E2")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private TowerScrollListController mScrollListController;
    [Token(Token = "0x400D3E3")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ListItemEvents mListItemTemplate;
    [Token(Token = "0x400D3E4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button mChallenge;
    [Token(Token = "0x400D3E5")]
    [FieldOffset(Offset = "0x1C")]
    private List<TowerFloorParam> mFloorParams;
    [Token(Token = "0x400D3E6")]
    [FieldOffset(Offset = "0x20")]
    private bool isInitialized;

    [Token(Token = "0x600C654")]
    [Address(RVA = "0x8EEF90", Offset = "0x8EDD90", VA = "0x108EEF90", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C655")]
    [Address(RVA = "0x8EFA40", Offset = "0x8EE840", VA = "0x108EFA40")]
    public void ScrollToCurrentFloor()
    {
    }

    [Token(Token = "0x600C656")]
    [Address(RVA = "0x8EF990", Offset = "0x8EE790", VA = "0x108EF990")]
    public void ScrollToCurrentFloor(TowerFloorParam floorParam)
    {
    }

    [Token(Token = "0x600C657")]
    [Address(RVA = "0x8EF050", Offset = "0x8EDE50", VA = "0x108EF050")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600C658")]
    [Address(RVA = "0x8EF8F0", Offset = "0x8EE6F0", VA = "0x108EF8F0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600C659")]
    [Address(RVA = "0x8EF450", Offset = "0x8EE250", VA = "0x108EF450", Slot = "5")]
    public void OnSetUpItems()
    {
    }

    [Token(Token = "0x600C65A")]
    [Address(RVA = "0x8EF600", Offset = "0x8EE400", VA = "0x108EF600", Slot = "6")]
    public void OnUpdateItems(int idx, GameObject obj)
    {
    }

    [Token(Token = "0x600C65B")]
    [Address(RVA = "0x8EF290", Offset = "0x8EE090", VA = "0x108EF290")]
    private void OnScrollStop(GameObject go)
    {
    }

    [Token(Token = "0x600C65C")]
    [Address(RVA = "0x8EF320", Offset = "0x8EE120", VA = "0x108EF320")]
    private void OnSelectItem(GameObject go)
    {
    }

    [Token(Token = "0x600C65D")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public TowerQuestList()
    {
    }
  }
}
