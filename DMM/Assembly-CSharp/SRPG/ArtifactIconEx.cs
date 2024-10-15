// Decompiled with JetBrains decompiler
// Type: SRPG.ArtifactIconEx
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
  [Token(Token = "0x2002000")]
  public class ArtifactIconEx : BaseIcon
  {
    [Token(Token = "0x4008886")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ArtifactIconEx.Slot mSlot;
    [Token(Token = "0x4008887")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x4008888")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private SerializeValueList mVisibleList;
    [Token(Token = "0x4008889")]
    [FieldOffset(Offset = "0x18")]
    private ArtifactIconExModel mModel;

    [Token(Token = "0x600842C")]
    [Address(RVA = "0x44BAC0", Offset = "0x44A8C0", VA = "0x1044BAC0")]
    public void InitializeModel()
    {
    }

    [Token(Token = "0x600842D")]
    [Address(RVA = "0x44BC30", Offset = "0x44AA30", VA = "0x1044BC30")]
    public void Initialize(ArtifactParam artifactParam)
    {
    }

    [Token(Token = "0x600842E")]
    [Address(RVA = "0x44BB70", Offset = "0x44A970", VA = "0x1044BB70")]
    public void Initialize(ArtifactData artifactData)
    {
    }

    [Token(Token = "0x600842F")]
    [Address(RVA = "0x44BBA0", Offset = "0x44A9A0", VA = "0x1044BBA0")]
    public void Initialize(UnitData unitData, int slot)
    {
    }

    [Token(Token = "0x6008430")]
    [Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")]
    public void Initialize(ArtifactIconExModel model)
    {
    }

    [Token(Token = "0x6008431")]
    [Address(RVA = "0x44BB70", Offset = "0x44A970", VA = "0x1044BB70")]
    public void Setup(ArtifactData data)
    {
    }

    [Token(Token = "0x6008432")]
    [Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")]
    private int GetSlotNum() => new int();

    [Token(Token = "0x6008433")]
    [Address(RVA = "0x44BD10", Offset = "0x44AB10", VA = "0x1044BD10")]
    public void Refresh()
    {
    }

    [Token(Token = "0x6008434")]
    [Address(RVA = "0x44BC70", Offset = "0x44AA70", VA = "0x1044BC70")]
    public void Refresh(UnitData unitData)
    {
    }

    [Token(Token = "0x6008435")]
    [Address(RVA = "0x44BF90", Offset = "0x44AD90", VA = "0x1044BF90", Slot = "12")]
    public override void UpdateValue()
    {
    }

    [Token(Token = "0x6008436")]
    [Address(RVA = "0x44BD90", Offset = "0x44AB90", VA = "0x1044BD90")]
    public void SetDisplay()
    {
    }

    [Token(Token = "0x6008437")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public ArtifactIconEx()
    {
    }

    [Token(Token = "0x2002001")]
    private enum Slot
    {
      [Token(Token = "0x400888B")] slot1,
      [Token(Token = "0x400888C")] slot2,
      [Token(Token = "0x400888D")] slot3,
    }
  }
}
