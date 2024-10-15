// Decompiled with JetBrains decompiler
// Type: SRPG.UnitIconPanel
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
  [Token(Token = "0x2002C37")]
  public class UnitIconPanel : MonoBehaviour
  {
    [Token(Token = "0x400DAF2")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x400DAF3")]
    [FieldOffset(Offset = "0x10")]
    private UnitIconPanelModel mModel;

    [Token(Token = "0x600CCCF")]
    [Address(RVA = "0x978A20", Offset = "0x977820", VA = "0x10978A20")]
    public void Initialize(
      UnitData unitData,
      bool isHideIcon = false,
      bool isHideRarity = false,
      bool isHideLevel = false,
      bool isHideJob = false)
    {
    }

    [Token(Token = "0x600CCD0")]
    [Address(RVA = "0x978AB0", Offset = "0x9778B0", VA = "0x10978AB0")]
    public void Refresh(UnitData unitData)
    {
    }

    [Token(Token = "0x600CCD1")]
    [Address(RVA = "0x978AE0", Offset = "0x9778E0", VA = "0x10978AE0")]
    public void Setup()
    {
    }

    [Token(Token = "0x600CCD2")]
    [Address(RVA = "0x9789A0", Offset = "0x9777A0", VA = "0x109789A0")]
    private void InitializeModel(
      UnitData unitData,
      bool isHideIcon = false,
      bool isHideRarity = false,
      bool isHideLevel = false,
      bool isHideJob = false)
    {
    }

    [Token(Token = "0x600CCD3")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public UnitIconPanel()
    {
    }
  }
}
