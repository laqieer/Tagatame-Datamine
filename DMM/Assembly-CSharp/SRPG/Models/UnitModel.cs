// Decompiled with JetBrains decompiler
// Type: SRPG.Models.UnitModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x20033D2")]
  public class UnitModel
  {
    [Token(Token = "0x400F572")]
    [FieldOffset(Offset = "0x8")]
    private UnitData unitdata;
    [Token(Token = "0x400F573")]
    [FieldOffset(Offset = "0xC")]
    private UnitParam unitParam;
    [Token(Token = "0x400F574")]
    [FieldOffset(Offset = "0x10")]
    private bool _leader;
    [Token(Token = "0x400F575")]
    [FieldOffset(Offset = "0x11")]
    private bool _notUse;
    [Token(Token = "0x400F576")]
    [FieldOffset(Offset = "0x14")]
    private string resonanceCondMsg;
    [Token(Token = "0x400F577")]
    [FieldOffset(Offset = "0x18")]
    private int _hp;
    [Token(Token = "0x400F578")]
    [FieldOffset(Offset = "0x1C")]
    private int _hpMax;
    [Token(Token = "0x400F579")]
    [FieldOffset(Offset = "0x20")]
    private PartySlotIndex _partySlotIndex;
    [Token(Token = "0x400F57A")]
    [FieldOffset(Offset = "0x24")]
    private ResonanceUnitParam resonanceUnitParam;
    [Token(Token = "0x400F57B")]
    [FieldOffset(Offset = "0x28")]
    private ResonanceParam resonanceParam;
    [Token(Token = "0x400F57C")]
    [FieldOffset(Offset = "0x2C")]
    private ResonanceUseItemParam[] resonanceUseItemParamList;
    [Token(Token = "0x400F57D")]
    [FieldOffset(Offset = "0x30")]
    private ResonanceCondParam resonanceCondParam;
    [Token(Token = "0x400F57E")]
    [FieldOffset(Offset = "0x34")]
    private bool mIsForcedDefaultFrame;

    [Token(Token = "0x1700210C")]
    public UnitData Unitdata
    {
      [Token(Token = "0x600E7F9"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x1700210D")]
    public UnitParam UnitParam
    {
      [Token(Token = "0x600E7FA"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (UnitParam) null;
      }
    }

    [Token(Token = "0x1700210E")]
    public string UnitIconPath
    {
      [Token(Token = "0x600E7FB"), Address(RVA = "0xAD2EB0", Offset = "0xAD1CB0", VA = "0x10AD2EB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700210F")]
    public string PathUnitImage2
    {
      [Token(Token = "0x600E7FC"), Address(RVA = "0xAD26A0", Offset = "0xAD14A0", VA = "0x10AD26A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002110")]
    public string UnitName
    {
      [Token(Token = "0x600E7FD"), Address(RVA = "0xAD2F80", Offset = "0xAD1D80", VA = "0x10AD2F80")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002111")]
    public int Rarity
    {
      [Token(Token = "0x600E7FE"), Address(RVA = "0xAD2880", Offset = "0xAD1680", VA = "0x10AD2880")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002112")]
    public int Level
    {
      [Token(Token = "0x600E7FF"), Address(RVA = "0xAD2670", Offset = "0xAD1470", VA = "0x10AD2670")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002113")]
    public int LevelCap
    {
      [Token(Token = "0x600E800"), Address(RVA = "0xAD2640", Offset = "0xAD1440", VA = "0x10AD2640")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002114")]
    public JobData[] Jobs
    {
      [Token(Token = "0x600E801"), Address(RVA = "0xAD2620", Offset = "0xAD1420", VA = "0x10AD2620")] get
      {
        return (JobData[]) null;
      }
    }

    [Token(Token = "0x17002115")]
    public string JobIconPath
    {
      [Token(Token = "0x600E802"), Address(RVA = "0xAD25A0", Offset = "0xAD13A0", VA = "0x10AD25A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002116")]
    public Sprite JobFrame
    {
      [Token(Token = "0x600E803"), Address(RVA = "0xAD2470", Offset = "0xAD1270", VA = "0x10AD2470")] get
      {
        return (Sprite) null;
      }
    }

    [Token(Token = "0x17002117")]
    public bool IsForcedDefaultFrame
    {
      [Token(Token = "0x600E804"), Address(RVA = "0x54FC50", Offset = "0x54EA50", VA = "0x1054FC50")] set
      {
      }
    }

    [Token(Token = "0x17002118")]
    public EElement Element
    {
      [Token(Token = "0x600E805"), Address(RVA = "0xAD16E0", Offset = "0xAD04E0", VA = "0x10AD16E0")] get
      {
        return new EElement();
      }
    }

    [Token(Token = "0x17002119")]
    public bool IsHighElement
    {
      [Token(Token = "0x600E806"), Address(RVA = "0xAD1940", Offset = "0xAD0740", VA = "0x10AD1940")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700211A")]
    public int ElementPlus
    {
      [Token(Token = "0x600E807"), Address(RVA = "0xAD16B0", Offset = "0xAD04B0", VA = "0x10AD16B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700211B")]
    public Sprite ElementIcon
    {
      [Token(Token = "0x600E808"), Address(RVA = "0xAD15F0", Offset = "0xAD03F0", VA = "0x10AD15F0")] get
      {
        return (Sprite) null;
      }
    }

    [Token(Token = "0x1700211C")]
    public bool IsUnlockTobira
    {
      [Token(Token = "0x600E809"), Address(RVA = "0xAD2210", Offset = "0xAD1010", VA = "0x10AD2210")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E80A")]
    [Address(RVA = "0xAD14A0", Offset = "0xAD02A0", VA = "0x10AD14A0")]
    public int TruthLv(TobiraParam.Category category) => new int();

    [Token(Token = "0x1700211D")]
    public Sprite RaritySprite
    {
      [Token(Token = "0x600E80B"), Address(RVA = "0xAD27C0", Offset = "0xAD15C0", VA = "0x10AD27C0")] get
      {
        return (Sprite) null;
      }
    }

    [Token(Token = "0x1700211E")]
    public int CombatPower
    {
      [Token(Token = "0x600E80C"), Address(RVA = "0xAD15C0", Offset = "0xAD03C0", VA = "0x10AD15C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700211F")]
    public bool IsLeader
    {
      [Token(Token = "0x600E80D"), Address(RVA = "0x2B0B70", Offset = "0x2AF970", VA = "0x102B0B70")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E80E"), Address(RVA = "0x2C73C0", Offset = "0x2C61C0", VA = "0x102C73C0")] set
      {
      }
    }

    [Token(Token = "0x17002120")]
    public bool IsNotUse
    {
      [Token(Token = "0x600E80F"), Address(RVA = "0x3E6E30", Offset = "0x3E5C30", VA = "0x103E6E30")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E810"), Address(RVA = "0xAB3920", Offset = "0xAB2720", VA = "0x10AB3920")] set
      {
      }
    }

    [Token(Token = "0x17002121")]
    public int Hp
    {
      [Token(Token = "0x600E811"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002122")]
    public int HpMax
    {
      [Token(Token = "0x600E812"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002123")]
    public PartySlotIndex PartySlotIndex
    {
      [Token(Token = "0x600E813"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new PartySlotIndex();
      }
      [Token(Token = "0x600E814"), Address(RVA = "0x2A68E0", Offset = "0x2A56E0", VA = "0x102A68E0")] set
      {
      }
    }

    [Token(Token = "0x17002124")]
    public bool IsResonanceTarget
    {
      [Token(Token = "0x600E815"), Address(RVA = "0xAD1FF0", Offset = "0xAD0DF0", VA = "0x10AD1FF0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002125")]
    public bool IsResonance
    {
      [Token(Token = "0x600E816"), Address(RVA = "0xAD21C0", Offset = "0xAD0FC0", VA = "0x10AD21C0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002126")]
    public bool IsResonanceParent
    {
      [Token(Token = "0x600E817"), Address(RVA = "0xAD1F90", Offset = "0xAD0D90", VA = "0x10AD1F90")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002127")]
    public bool IsResonanceChild
    {
      [Token(Token = "0x600E818"), Address(RVA = "0xAD1970", Offset = "0xAD0770", VA = "0x10AD1970")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002128")]
    public string ResonanceUnitIconPath
    {
      [Token(Token = "0x600E819"), Address(RVA = "0xAD29E0", Offset = "0xAD17E0", VA = "0x10AD29E0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002129")]
    public JobData ResonanceUnitJob
    {
      [Token(Token = "0x600E81A"), Address(RVA = "0xAD2C80", Offset = "0xAD1A80", VA = "0x10AD2C80")] get
      {
        return (JobData) null;
      }
    }

    [Token(Token = "0x1700212A")]
    public string ResonanceUnitJobIconPath
    {
      [Token(Token = "0x600E81B"), Address(RVA = "0xAD2C10", Offset = "0xAD1A10", VA = "0x10AD2C10")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700212B")]
    public Sprite ResonanceUnitJobFrame
    {
      [Token(Token = "0x600E81C"), Address(RVA = "0xAD2B40", Offset = "0xAD1940", VA = "0x10AD2B40")] get
      {
        return (Sprite) null;
      }
    }

    [Token(Token = "0x1700212C")]
    public Sprite ResonanceUnitElementIcon
    {
      [Token(Token = "0x600E81D"), Address(RVA = "0xAD28B0", Offset = "0xAD16B0", VA = "0x10AD28B0")] get
      {
        return (Sprite) null;
      }
    }

    [Token(Token = "0x1700212D")]
    public Sprite ResonanceUnitRaritySprite
    {
      [Token(Token = "0x600E81E"), Address(RVA = "0xAD2D50", Offset = "0xAD1B50", VA = "0x10AD2D50")] get
      {
        return (Sprite) null;
      }
    }

    [Token(Token = "0x1700212E")]
    public bool IsValidResonance
    {
      [Token(Token = "0x600E81F"), Address(RVA = "0xAD2280", Offset = "0xAD1080", VA = "0x10AD2280")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700212F")]
    public bool IsResonanceJobLevel
    {
      [Token(Token = "0x600E820"), Address(RVA = "0xAD1CE0", Offset = "0xAD0AE0", VA = "0x10AD1CE0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002130")]
    public bool IsResonanceItemAmount
    {
      [Token(Token = "0x600E821"), Address(RVA = "0xAD1B60", Offset = "0xAD0960", VA = "0x10AD1B60")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002131")]
    public bool IsResonanceUnitLevel
    {
      [Token(Token = "0x600E822"), Address(RVA = "0xAD2010", Offset = "0xAD0E10", VA = "0x10AD2010")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002132")]
    public bool IsResonanceIncludeTobiraUnlock
    {
      [Token(Token = "0x600E823"), Address(RVA = "0xAD19D0", Offset = "0xAD07D0", VA = "0x10AD19D0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002133")]
    public bool IsValidResonanceTips
    {
      [Token(Token = "0x600E824"), Address(RVA = "0xAD2240", Offset = "0xAD1040", VA = "0x10AD2240")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002134")]
    public string ResonanceCondMessage
    {
      [Token(Token = "0x600E825"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002135")]
    public List<MaterialItemModel> GetMaterialItemModelList
    {
      [Token(Token = "0x600E826"), Address(RVA = "0xAD1710", Offset = "0xAD0510", VA = "0x10AD1710")] get
      {
        return (List<MaterialItemModel>) null;
      }
    }

    [Token(Token = "0x600E827")]
    [Address(RVA = "0xAD1100", Offset = "0xACFF00", VA = "0x10AD1100")]
    private ResonanceUnitParam GetResonanceUnitParam() => (ResonanceUnitParam) null;

    [Token(Token = "0x600E828")]
    [Address(RVA = "0xAD13E0", Offset = "0xAD01E0", VA = "0x10AD13E0")]
    public void Initialize(UnitData _unitdata = null)
    {
    }

    [Token(Token = "0x600E829")]
    [Address(RVA = "0xAD1430", Offset = "0xAD0230", VA = "0x10AD1430")]
    public void Initialize(UnitParam _unitParam)
    {
    }

    [Token(Token = "0x600E82A")]
    [Address(RVA = "0xAD13C0", Offset = "0xAD01C0", VA = "0x10AD13C0")]
    public void InitializeHp(int hp, int hp_max)
    {
    }

    [Token(Token = "0x600E82B")]
    [Address(RVA = "0xAD1360", Offset = "0xAD0160", VA = "0x10AD1360")]
    private void InitializeData()
    {
    }

    [Token(Token = "0x600E82C")]
    [Address(RVA = "0xAD0BA0", Offset = "0xACF9A0", VA = "0x10AD0BA0")]
    private void CreateResonanceCondMessage()
    {
    }

    [Token(Token = "0x600E82D")]
    [Address(RVA = "0xAD1570", Offset = "0xAD0370", VA = "0x10AD1570")]
    public UnitModel()
    {
    }
  }
}
