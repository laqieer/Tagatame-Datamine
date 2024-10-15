// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalCategorySortItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002272")]
  public class CrystalCategorySortItem : MonoBehaviour
  {
    [Token(Token = "0x40098ED")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList ExhibitList;
    [Token(Token = "0x40098EE")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private CrystalCategorySortToggle ToggleTempleate;
    [Token(Token = "0x40098EF")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Transform Parent;
    [Token(Token = "0x40098F1")]
    [FieldOffset(Offset = "0x1C")]
    private CrystalCategoryItemModel mModel;

    [Token(Token = "0x170014A3")]
    public CrystalSortParam Param
    {
      [Token(Token = "0x6009327"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (CrystalSortParam) null;
      }
      [Token(Token = "0x6009328"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] private set
      {
      }
    }

    [Token(Token = "0x6009329")]
    [Address(RVA = "0x5658E0", Offset = "0x5646E0", VA = "0x105658E0")]
    public void SetUp(CrystalSortWindow _window, CrystalSortParam _param, bool _is_disp_title)
    {
    }

    [Token(Token = "0x600932A")]
    [Address(RVA = "0x565860", Offset = "0x564660", VA = "0x10565860")]
    private void Draw()
    {
    }

    [Token(Token = "0x600932B")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CrystalCategorySortItem()
    {
    }
  }
}
