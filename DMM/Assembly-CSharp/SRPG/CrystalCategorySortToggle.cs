// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalCategorySortToggle
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
  [Token(Token = "0x2002275")]
  public class CrystalCategorySortToggle : MonoBehaviour
  {
    [Token(Token = "0x40098F8")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList ExhibitList;
    [Token(Token = "0x40098F9")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Toggle ToggleButton;
    [Token(Token = "0x40098FA")]
    [FieldOffset(Offset = "0x14")]
    private CrystalSortCondParam mParam;
    [Token(Token = "0x40098FB")]
    [FieldOffset(Offset = "0x18")]
    private string mParentIname;
    [Token(Token = "0x40098FC")]
    [FieldOffset(Offset = "0x1C")]
    private CrystalCategoryToggleModel mModel;

    [Token(Token = "0x170014A5")]
    public CrystalSortCondParam GetParam
    {
      [Token(Token = "0x6009333"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (CrystalSortCondParam) null;
      }
    }

    [Token(Token = "0x170014A6")]
    public string GetParentIname
    {
      [Token(Token = "0x6009334"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170014A7")]
    public Toggle GetToggle
    {
      [Token(Token = "0x6009335"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (Toggle) null;
      }
    }

    [Token(Token = "0x6009336")]
    [Address(RVA = "0x565FF0", Offset = "0x564DF0", VA = "0x10565FF0")]
    public void SetUp(CrystalSortWindow _window, CrystalSortCondParam _param, string _parent_iname)
    {
    }

    [Token(Token = "0x6009337")]
    [Address(RVA = "0x565F70", Offset = "0x564D70", VA = "0x10565F70")]
    private void Draw()
    {
    }

    [Token(Token = "0x6009338")]
    [Address(RVA = "0x5662B0", Offset = "0x5650B0", VA = "0x105662B0")]
    public void ToggleOff()
    {
    }

    [Token(Token = "0x6009339")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CrystalCategorySortToggle()
    {
    }
  }
}
