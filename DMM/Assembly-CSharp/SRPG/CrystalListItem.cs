// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002285")]
  public class CrystalListItem : MonoBehaviour
  {
    [Token(Token = "0x4009934")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList ExhibitList;
    [Token(Token = "0x4009935")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private CrystalIcon Icon;
    [Token(Token = "0x4009936")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Button ItemButton;
    [Token(Token = "0x4009937")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private float EquipChangeInterval;
    [Token(Token = "0x4009938")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private bool IsFixedDispRank;
    [Token(Token = "0x4009939")]
    [FieldOffset(Offset = "0x1D")]
    [SerializeField]
    private bool IsFixedDispName;
    [Token(Token = "0x400993A")]
    [FieldOffset(Offset = "0x1E")]
    [SerializeField]
    private bool IsIconDispRank;
    [Token(Token = "0x400993B")]
    [FieldOffset(Offset = "0x20")]
    private CrystalScrollList mScrollList;
    [Token(Token = "0x400993C")]
    [FieldOffset(Offset = "0x24")]
    private CrystalListItemModel mModel;
    [Token(Token = "0x400993D")]
    [FieldOffset(Offset = "0x28")]
    private UnitData mUnitData;
    [Token(Token = "0x400993E")]
    [FieldOffset(Offset = "0x2C")]
    private float mNowInterval;

    [Token(Token = "0x6009386")]
    [Address(RVA = "0x56B510", Offset = "0x56A310", VA = "0x1056B510")]
    public void SetUp(
      CrystalScrollList _scroll_list,
      CrystalListItemParam _param,
      UnitData _unit_data)
    {
    }

    [Token(Token = "0x6009387")]
    [Address(RVA = "0x56B3A0", Offset = "0x56A1A0", VA = "0x1056B3A0")]
    public void SetRemoveEquip(CrystalScrollList _scroll_list)
    {
    }

    [Token(Token = "0x6009388")]
    [Address(RVA = "0x56B310", Offset = "0x56A110", VA = "0x1056B310")]
    private void Draw()
    {
    }

    [Token(Token = "0x6009389")]
    [Address(RVA = "0x56B790", Offset = "0x56A590", VA = "0x1056B790")]
    private void Update()
    {
    }

    [Token(Token = "0x600938A")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CrystalListItem()
    {
    }
  }
}
