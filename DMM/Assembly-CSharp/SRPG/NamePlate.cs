// Decompiled with JetBrains decompiler
// Type: SRPG.NamePlate
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
  [Token(Token = "0x20027B0")]
  public class NamePlate : MonoBehaviour
  {
    [Token(Token = "0x400BBD6")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x400BBD7")]
    [FieldOffset(Offset = "0x10")]
    private NamePlateModel mModel;

    [Token(Token = "0x600B23A")]
    [Address(RVA = "0x7A5B90", Offset = "0x7A4990", VA = "0x107A5B90")]
    public void Initialize(
      UnitData unitData,
      bool isHideElement = false,
      bool isHideName = false,
      bool isHideBirth = false)
    {
    }

    [Token(Token = "0x600B23B")]
    [Address(RVA = "0x7A5C50", Offset = "0x7A4A50", VA = "0x107A5C50")]
    public void Setup()
    {
    }

    [Token(Token = "0x600B23C")]
    [Address(RVA = "0x7A5C20", Offset = "0x7A4A20", VA = "0x107A5C20")]
    public void Refresh(UnitData unitData)
    {
    }

    [Token(Token = "0x600B23D")]
    [Address(RVA = "0x7A5B10", Offset = "0x7A4910", VA = "0x107A5B10")]
    private void InitializeModel(
      UnitData unitData,
      bool isHideElement = false,
      bool isHideName = false,
      bool isHideBirth = false)
    {
    }

    [Token(Token = "0x600B23E")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public NamePlate()
    {
    }
  }
}
