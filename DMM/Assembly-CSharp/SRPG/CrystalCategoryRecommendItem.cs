// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalCategoryRecommendItem
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
  [Token(Token = "0x20022CC")]
  public class CrystalCategoryRecommendItem : MonoBehaviour
  {
    [Token(Token = "0x4009AFE")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList ExhibitList;
    [Token(Token = "0x4009AFF")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private CrystalCategoryRecommendToggle ToggleTempleate;
    [Token(Token = "0x4009B00")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Transform Parent;
    [Token(Token = "0x4009B02")]
    [FieldOffset(Offset = "0x1C")]
    private CrystalCategoryItemModel mModel;

    [Token(Token = "0x170014E3")]
    public CrystalRecommendParam Param
    {
      [Token(Token = "0x600957A"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (CrystalRecommendParam) null;
      }
      [Token(Token = "0x600957B"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] private set
      {
      }
    }

    [Token(Token = "0x600957C")]
    [Address(RVA = "0x57C970", Offset = "0x57B770", VA = "0x1057C970")]
    public void SetUp(
      CrystalRecommendWindow _window,
      CrystalRecommendParam _param,
      bool _is_disp_title)
    {
    }

    [Token(Token = "0x600957D")]
    [Address(RVA = "0x57C8F0", Offset = "0x57B6F0", VA = "0x1057C8F0")]
    private void Draw()
    {
    }

    [Token(Token = "0x600957E")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CrystalCategoryRecommendItem()
    {
    }
  }
}
