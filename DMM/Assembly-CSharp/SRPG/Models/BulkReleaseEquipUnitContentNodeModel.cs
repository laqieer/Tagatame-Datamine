// Decompiled with JetBrains decompiler
// Type: SRPG.Models.BulkReleaseEquipUnitContentNodeModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x200333A")]
  public class BulkReleaseEquipUnitContentNodeModel
  {
    [Token(Token = "0x400F1D3")]
    [FieldOffset(Offset = "0x8")]
    private UnitModel mUnitModel;
    [Token(Token = "0x400F1D4")]
    [FieldOffset(Offset = "0xC")]
    private List<PartyToggleModel> mBadgeModels;

    [Token(Token = "0x17001E3C")]
    public UnitData UnitData
    {
      [Token(Token = "0x600E276"), Address(RVA = "0xAA87D0", Offset = "0xAA75D0", VA = "0x10AA87D0")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x17001E3D")]
    public UnitModel UnitModel
    {
      [Token(Token = "0x600E277"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (UnitModel) null;
      }
    }

    [Token(Token = "0x600E278")]
    [Address(RVA = "0xAA8140", Offset = "0xAA6F40", VA = "0x10AA8140")]
    public List<PartyToggleModel> GetBadgeModels() => (List<PartyToggleModel>) null;

    [Token(Token = "0x600E279")]
    [Address(RVA = "0xAA8370", Offset = "0xAA7170", VA = "0x10AA8370")]
    public bool IsBadgeVisible(BulkReleaseWindow.EquipPartyType ptype) => new bool();

    [Token(Token = "0x600E27A")]
    [Address(RVA = "0xAA82F0", Offset = "0xAA70F0", VA = "0x10AA82F0")]
    public void Initialize(UnitData unitdata)
    {
    }

    [Token(Token = "0x600E27B")]
    [Address(RVA = "0xAA8270", Offset = "0xAA7070", VA = "0x10AA8270")]
    public void InitializeUnitModel(UnitData unitdata)
    {
    }

    [Token(Token = "0x600E27C")]
    [Address(RVA = "0xAA84F0", Offset = "0xAA72F0", VA = "0x10AA84F0")]
    public void SetupVisibleDic()
    {
    }

    [Token(Token = "0x600E27D")]
    [Address(RVA = "0xAA8430", Offset = "0xAA7230", VA = "0x10AA8430")]
    public void SetBadgeVisible(BulkReleaseWindow.EquipPartyType type, bool flag)
    {
    }

    [Token(Token = "0x600E27E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public BulkReleaseEquipUnitContentNodeModel()
    {
    }
  }
}
