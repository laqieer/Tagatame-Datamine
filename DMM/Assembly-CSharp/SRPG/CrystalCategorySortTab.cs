// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalCategorySortTab
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
  [Token(Token = "0x2002273")]
  public class CrystalCategorySortTab : MonoBehaviour
  {
    [Token(Token = "0x40098F3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ExhibitList ExhibitList;
    [Token(Token = "0x40098F4")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Toggle ToggleButton;
    [Token(Token = "0x40098F5")]
    [FieldOffset(Offset = "0x18")]
    private CrystalCategoryTabModel mModel;

    [Token(Token = "0x170014A4")]
    public string TabName
    {
      [Token(Token = "0x600932C"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600932D"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x600932E")]
    [Address(RVA = "0x565D10", Offset = "0x564B10", VA = "0x10565D10")]
    public void SetUp(CrystalSortWindow _window, string _tab_name, bool _is_on)
    {
    }

    [Token(Token = "0x600932F")]
    [Address(RVA = "0x565C90", Offset = "0x564A90", VA = "0x10565C90")]
    private void Draw()
    {
    }

    [Token(Token = "0x6009330")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CrystalCategorySortTab()
    {
    }
  }
}
