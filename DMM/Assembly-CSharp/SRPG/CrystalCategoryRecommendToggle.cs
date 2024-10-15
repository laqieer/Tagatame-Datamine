// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalCategoryRecommendToggle
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
  [Token(Token = "0x20022CF")]
  public class CrystalCategoryRecommendToggle : MonoBehaviour
  {
    [Token(Token = "0x4009B09")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList ExhibitList;
    [Token(Token = "0x4009B0A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Toggle ToggleButton;
    [Token(Token = "0x4009B0B")]
    [FieldOffset(Offset = "0x14")]
    private CrystalRecommendCondParam mParam;
    [Token(Token = "0x4009B0C")]
    [FieldOffset(Offset = "0x18")]
    private string mParentIname;
    [Token(Token = "0x4009B0D")]
    [FieldOffset(Offset = "0x1C")]
    private CrystalCategoryToggleModel mModel;

    [Token(Token = "0x170014E5")]
    public CrystalRecommendCondParam GetParam
    {
      [Token(Token = "0x6009586"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (CrystalRecommendCondParam) null;
      }
    }

    [Token(Token = "0x170014E6")]
    public string GetParentIname
    {
      [Token(Token = "0x6009587"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170014E7")]
    public Toggle GetToggle
    {
      [Token(Token = "0x6009588"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (Toggle) null;
      }
    }

    [Token(Token = "0x6009589")]
    [Address(RVA = "0x57D080", Offset = "0x57BE80", VA = "0x1057D080")]
    public void SetUp(
      CrystalRecommendWindow _window,
      CrystalRecommendCondParam _param,
      string _parent_iname)
    {
    }

    [Token(Token = "0x600958A")]
    [Address(RVA = "0x57D000", Offset = "0x57BE00", VA = "0x1057D000")]
    private void Draw()
    {
    }

    [Token(Token = "0x600958B")]
    [Address(RVA = "0x57D380", Offset = "0x57C180", VA = "0x1057D380")]
    public void ToggleOff()
    {
    }

    [Token(Token = "0x600958C")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CrystalCategoryRecommendToggle()
    {
    }
  }
}
