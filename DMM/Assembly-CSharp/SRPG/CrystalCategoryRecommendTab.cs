// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalCategoryRecommendTab
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
  [Token(Token = "0x20022CD")]
  public class CrystalCategoryRecommendTab : MonoBehaviour
  {
    [Token(Token = "0x4009B04")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ExhibitList ExhibitList;
    [Token(Token = "0x4009B05")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Toggle ToggleButton;
    [Token(Token = "0x4009B06")]
    [FieldOffset(Offset = "0x18")]
    private CrystalCategoryTabModel mModel;

    [Token(Token = "0x170014E4")]
    public string TabName
    {
      [Token(Token = "0x600957F"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009580"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x6009581")]
    [Address(RVA = "0x57CDA0", Offset = "0x57BBA0", VA = "0x1057CDA0")]
    public void SetUp(CrystalRecommendWindow _window, string _tab_name, bool _is_on)
    {
    }

    [Token(Token = "0x6009582")]
    [Address(RVA = "0x57CD20", Offset = "0x57BB20", VA = "0x1057CD20")]
    private void Draw()
    {
    }

    [Token(Token = "0x6009583")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CrystalCategoryRecommendTab()
    {
    }
  }
}
