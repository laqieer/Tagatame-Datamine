// Decompiled with JetBrains decompiler
// Type: SRPG.AdventureRecommend
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FA8")]
  public class AdventureRecommend
  {
    [Token(Token = "0x4008607")]
    [FieldOffset(Offset = "0x8")]
    private AdventureManager mManager;
    [Token(Token = "0x4008608")]
    [FieldOffset(Offset = "0xC")]
    private List<UnitData> mPlayerUnitData;
    [Token(Token = "0x4008609")]
    [FieldOffset(Offset = "0x10")]
    private List<AdventureData> mDataList;
    [Token(Token = "0x400860A")]
    [FieldOffset(Offset = "0x14")]
    private List<AdventureData> mRecAdvDataList;

    [Token(Token = "0x170012BD")]
    public List<AdventureData> RecAdvDataList
    {
      [Token(Token = "0x6008255"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (List<AdventureData>) null;
      }
    }

    [Token(Token = "0x6008256")]
    [Address(RVA = "0x42FBA0", Offset = "0x42E9A0", VA = "0x1042FBA0")]
    public void SetUp(List<AdventureData> _data_list)
    {
    }

    [Token(Token = "0x6008257")]
    [Address(RVA = "0x42FA00", Offset = "0x42E800", VA = "0x1042FA00")]
    public void Refresh(bool isForceEdit = false)
    {
    }

    [Token(Token = "0x6008258")]
    [Address(RVA = "0x42EEE0", Offset = "0x42DCE0", VA = "0x1042EEE0")]
    private void CreateRecommendParty(AdventureData _data, bool isForceEdit = false)
    {
    }

    [Token(Token = "0x6008259")]
    [Address(RVA = "0x42F680", Offset = "0x42E480", VA = "0x1042F680")]
    private bool IsCheckCondCombatPower(AdventureCondParam cond_param, PartyEditData party_edit)
    {
      return new bool();
    }

    [Token(Token = "0x600825A")]
    [Address(RVA = "0x42F840", Offset = "0x42E640", VA = "0x1042F840")]
    private bool IsSameUnit(UnitData _unit, PartyData _party) => new bool();

    [Token(Token = "0x600825B")]
    [Address(RVA = "0x42F400", Offset = "0x42E200", VA = "0x1042F400")]
    private bool IsAdventureUnit(UnitData _unit) => new bool();

    [Token(Token = "0x600825C")]
    [Address(RVA = "0x42F300", Offset = "0x42E100", VA = "0x1042F300")]
    public List<UnitData> GetRecommendUnitList(string _area_iname) => (List<UnitData>) null;

    [Token(Token = "0x600825D")]
    [Address(RVA = "0x42FF00", Offset = "0x42ED00", VA = "0x1042FF00")]
    public AdventureRecommend()
    {
    }
  }
}
