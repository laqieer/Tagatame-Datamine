// Decompiled with JetBrains decompiler
// Type: SRPG.EnchantParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E00")]
  [MessagePackObject(true)]
  public class EnchantParam
  {
    [Token(Token = "0x400794A")]
    [FieldOffset(Offset = "0x0")]
    public static readonly int MAX_ENCHANT;
    [Token(Token = "0x400794B")]
    [FieldOffset(Offset = "0x8")]
    public short[] values;
    [Token(Token = "0x400794C")]
    [FieldOffset(Offset = "0x4")]
    public static readonly ParamTypes[] ConvertAssistParamTypes;
    [Token(Token = "0x400794D")]
    [FieldOffset(Offset = "0x8")]
    public static readonly ParamTypes[] ConvertResistParamTypes;

    [Token(Token = "0x6007AD2")]
    [Address(RVA = "0x3DC090", Offset = "0x3DAE90", VA = "0x103DC090")]
    public string ToSuspendString() => (string) null;

    [Token(Token = "0x6007AD3")]
    [Address(RVA = "0x3DBB90", Offset = "0x3DA990", VA = "0x103DBB90")]
    public bool FromSuspendString(string str) => new bool();

    [Token(Token = "0x170010C3")]
    [IgnoreMember]
    public short this[EnchantTypes type]
    {
      [Token(Token = "0x6007AD4"), Address(RVA = "0x3B8E20", Offset = "0x3B7C20", VA = "0x103B8E20")] get
      {
        return new short();
      }
      [Token(Token = "0x6007AD5"), Address(RVA = "0x3B8E50", Offset = "0x3B7C50", VA = "0x103B8E50")] set
      {
      }
    }

    [Token(Token = "0x170010C4")]
    public short poison
    {
      [Token(Token = "0x6007AD6"), Address(RVA = "0x3DCDB0", Offset = "0x3DBBB0", VA = "0x103DCDB0")] get
      {
        return new short();
      }
      [Token(Token = "0x6007AD7"), Address(RVA = "0x3DD9E0", Offset = "0x3DC7E0", VA = "0x103DD9E0")] set
      {
      }
    }

    [Token(Token = "0x170010C5")]
    public short paralyse
    {
      [Token(Token = "0x6007AD8"), Address(RVA = "0x3DB2F0", Offset = "0x3DA0F0", VA = "0x103DB2F0")] get
      {
        return new short();
      }
      [Token(Token = "0x6007AD9"), Address(RVA = "0x3DB440", Offset = "0x3DA240", VA = "0x103DB440")] set
      {
      }
    }

    [Token(Token = "0x170010C6")]
    public short stun
    {
      [Token(Token = "0x6007ADA"), Address(RVA = "0x3DB380", Offset = "0x3DA180", VA = "0x103DB380")] get
      {
        return new short();
      }
      [Token(Token = "0x6007ADB"), Address(RVA = "0x3DB4D0", Offset = "0x3DA2D0", VA = "0x103DB4D0")] set
      {
      }
    }

    [Token(Token = "0x170010C7")]
    public short sleep
    {
      [Token(Token = "0x6007ADC"), Address(RVA = "0x3DB3B0", Offset = "0x3DA1B0", VA = "0x103DB3B0")] get
      {
        return new short();
      }
      [Token(Token = "0x6007ADD"), Address(RVA = "0x3DB500", Offset = "0x3DA300", VA = "0x103DB500")] set
      {
      }
    }

    [Token(Token = "0x170010C8")]
    public short charm
    {
      [Token(Token = "0x6007ADE"), Address(RVA = "0x3DB350", Offset = "0x3DA150", VA = "0x103DB350")] get
      {
        return new short();
      }
      [Token(Token = "0x6007ADF"), Address(RVA = "0x3DB4A0", Offset = "0x3DA2A0", VA = "0x103DB4A0")] set
      {
      }
    }

    [Token(Token = "0x170010C9")]
    public short stone
    {
      [Token(Token = "0x6007AE0"), Address(RVA = "0x3DB320", Offset = "0x3DA120", VA = "0x103DB320")] get
      {
        return new short();
      }
      [Token(Token = "0x6007AE1"), Address(RVA = "0x3DB470", Offset = "0x3DA270", VA = "0x103DB470")] set
      {
      }
    }

    [Token(Token = "0x170010CA")]
    public short blind
    {
      [Token(Token = "0x6007AE2"), Address(RVA = "0x3DB2C0", Offset = "0x3DA0C0", VA = "0x103DB2C0")] get
      {
        return new short();
      }
      [Token(Token = "0x6007AE3"), Address(RVA = "0x3DB410", Offset = "0x3DA210", VA = "0x103DB410")] set
      {
      }
    }

    [Token(Token = "0x170010CB")]
    public short notskl
    {
      [Token(Token = "0x6007AE4"), Address(RVA = "0x3DCD20", Offset = "0x3DBB20", VA = "0x103DCD20")] get
      {
        return new short();
      }
      [Token(Token = "0x6007AE5"), Address(RVA = "0x3DD950", Offset = "0x3DC750", VA = "0x103DD950")] set
      {
      }
    }

    [Token(Token = "0x170010CC")]
    public short notmov
    {
      [Token(Token = "0x6007AE6"), Address(RVA = "0x3DCCF0", Offset = "0x3DBAF0", VA = "0x103DCCF0")] get
      {
        return new short();
      }
      [Token(Token = "0x6007AE7"), Address(RVA = "0x3DD920", Offset = "0x3DC720", VA = "0x103DD920")] set
      {
      }
    }

    [Token(Token = "0x170010CD")]
    public short notatk
    {
      [Token(Token = "0x6007AE8"), Address(RVA = "0x3DCC90", Offset = "0x3DBA90", VA = "0x103DCC90")] get
      {
        return new short();
      }
      [Token(Token = "0x6007AE9"), Address(RVA = "0x3DD8C0", Offset = "0x3DC6C0", VA = "0x103DD8C0")] set
      {
      }
    }

    [Token(Token = "0x170010CE")]
    public short zombie
    {
      [Token(Token = "0x6007AEA"), Address(RVA = "0x3DCF60", Offset = "0x3DBD60", VA = "0x103DCF60")] get
      {
        return new short();
      }
      [Token(Token = "0x6007AEB"), Address(RVA = "0x3DDB90", Offset = "0x3DC990", VA = "0x103DDB90")] set
      {
      }
    }

    [Token(Token = "0x170010CF")]
    public short death
    {
      [Token(Token = "0x6007AEC"), Address(RVA = "0x3DC930", Offset = "0x3DB730", VA = "0x103DC930")] get
      {
        return new short();
      }
      [Token(Token = "0x6007AED"), Address(RVA = "0x3DD560", Offset = "0x3DC360", VA = "0x103DD560")] set
      {
      }
    }

    [Token(Token = "0x170010D0")]
    public short berserk
    {
      [Token(Token = "0x6007AEE"), Address(RVA = "0x3DC8D0", Offset = "0x3DB6D0", VA = "0x103DC8D0")] get
      {
        return new short();
      }
      [Token(Token = "0x6007AEF"), Address(RVA = "0x3DD500", Offset = "0x3DC300", VA = "0x103DD500")] set
      {
      }
    }

    [Token(Token = "0x170010D1")]
    public short knockback
    {
      [Token(Token = "0x6007AF0"), Address(RVA = "0x3DCC00", Offset = "0x3DBA00", VA = "0x103DCC00")] get
      {
        return new short();
      }
      [Token(Token = "0x6007AF1"), Address(RVA = "0x3DD830", Offset = "0x3DC630", VA = "0x103DD830")] set
      {
      }
    }

    [Token(Token = "0x170010D2")]
    public short resist_buff
    {
      [Token(Token = "0x6007AF2"), Address(RVA = "0x3DCE10", Offset = "0x3DBC10", VA = "0x103DCE10")] get
      {
        return new short();
      }
      [Token(Token = "0x6007AF3"), Address(RVA = "0x3DDA40", Offset = "0x3DC840", VA = "0x103DDA40")] set
      {
      }
    }

    [Token(Token = "0x170010D3")]
    public short resist_debuff
    {
      [Token(Token = "0x6007AF4"), Address(RVA = "0x3DCE40", Offset = "0x3DBC40", VA = "0x103DCE40")] get
      {
        return new short();
      }
      [Token(Token = "0x6007AF5"), Address(RVA = "0x3DDA70", Offset = "0x3DC870", VA = "0x103DDA70")] set
      {
      }
    }

    [Token(Token = "0x170010D4")]
    public short stop
    {
      [Token(Token = "0x6007AF6"), Address(RVA = "0x3DCF30", Offset = "0x3DBD30", VA = "0x103DCF30")] get
      {
        return new short();
      }
      [Token(Token = "0x6007AF7"), Address(RVA = "0x3DDB60", Offset = "0x3DC960", VA = "0x103DDB60")] set
      {
      }
    }

    [Token(Token = "0x170010D5")]
    public short fast
    {
      [Token(Token = "0x6007AF8"), Address(RVA = "0x3DCB10", Offset = "0x3DB910", VA = "0x103DCB10")] get
      {
        return new short();
      }
      [Token(Token = "0x6007AF9"), Address(RVA = "0x3DD740", Offset = "0x3DC540", VA = "0x103DD740")] set
      {
      }
    }

    [Token(Token = "0x170010D6")]
    public short slow
    {
      [Token(Token = "0x6007AFA"), Address(RVA = "0x3DCF00", Offset = "0x3DBD00", VA = "0x103DCF00")] get
      {
        return new short();
      }
      [Token(Token = "0x6007AFB"), Address(RVA = "0x3DDB30", Offset = "0x3DC930", VA = "0x103DDB30")] set
      {
      }
    }

    [Token(Token = "0x170010D7")]
    public short auto_heal
    {
      [Token(Token = "0x6007AFC"), Address(RVA = "0x3DC840", Offset = "0x3DB640", VA = "0x103DC840")] get
      {
        return new short();
      }
      [Token(Token = "0x6007AFD"), Address(RVA = "0x3DD470", Offset = "0x3DC270", VA = "0x103DD470")] set
      {
      }
    }

    [Token(Token = "0x170010D8")]
    public short donsoku
    {
      [Token(Token = "0x6007AFE"), Address(RVA = "0x3DC990", Offset = "0x3DB790", VA = "0x103DC990")] get
      {
        return new short();
      }
      [Token(Token = "0x6007AFF"), Address(RVA = "0x3DD5C0", Offset = "0x3DC3C0", VA = "0x103DD5C0")] set
      {
      }
    }

    [Token(Token = "0x170010D9")]
    public short rage
    {
      [Token(Token = "0x6007B00"), Address(RVA = "0x3DCDE0", Offset = "0x3DBBE0", VA = "0x103DCDE0")] get
      {
        return new short();
      }
      [Token(Token = "0x6007B01"), Address(RVA = "0x3DDA10", Offset = "0x3DC810", VA = "0x103DDA10")] set
      {
      }
    }

    [Token(Token = "0x170010DA")]
    public short good_sleep
    {
      [Token(Token = "0x6007B02"), Address(RVA = "0x3DCBA0", Offset = "0x3DB9A0", VA = "0x103DCBA0")] get
      {
        return new short();
      }
      [Token(Token = "0x6007B03"), Address(RVA = "0x3DD7D0", Offset = "0x3DC5D0", VA = "0x103DD7D0")] set
      {
      }
    }

    [Token(Token = "0x170010DB")]
    public short auto_jewel
    {
      [Token(Token = "0x6007B04"), Address(RVA = "0x3DC870", Offset = "0x3DB670", VA = "0x103DC870")] get
      {
        return new short();
      }
      [Token(Token = "0x6007B05"), Address(RVA = "0x3DD4A0", Offset = "0x3DC2A0", VA = "0x103DD4A0")] set
      {
      }
    }

    [Token(Token = "0x170010DC")]
    public short notheal
    {
      [Token(Token = "0x6007B06"), Address(RVA = "0x3DCCC0", Offset = "0x3DBAC0", VA = "0x103DCCC0")] get
      {
        return new short();
      }
      [Token(Token = "0x6007B07"), Address(RVA = "0x3DD8F0", Offset = "0x3DC6F0", VA = "0x103DD8F0")] set
      {
      }
    }

    [Token(Token = "0x170010DD")]
    public short single_attack
    {
      [Token(Token = "0x6007B08"), Address(RVA = "0x3DCEA0", Offset = "0x3DBCA0", VA = "0x103DCEA0")] get
      {
        return new short();
      }
      [Token(Token = "0x6007B09"), Address(RVA = "0x3DDAD0", Offset = "0x3DC8D0", VA = "0x103DDAD0")] set
      {
      }
    }

    [Token(Token = "0x170010DE")]
    public short area_attack
    {
      [Token(Token = "0x6007B0A"), Address(RVA = "0x3DC810", Offset = "0x3DB610", VA = "0x103DC810")] get
      {
        return new short();
      }
      [Token(Token = "0x6007B0B"), Address(RVA = "0x3DD440", Offset = "0x3DC240", VA = "0x103DD440")] set
      {
      }
    }

    [Token(Token = "0x170010DF")]
    public short dec_ct
    {
      [Token(Token = "0x6007B0C"), Address(RVA = "0x3DC960", Offset = "0x3DB760", VA = "0x103DC960")] get
      {
        return new short();
      }
      [Token(Token = "0x6007B0D"), Address(RVA = "0x3DD590", Offset = "0x3DC390", VA = "0x103DD590")] set
      {
      }
    }

    [Token(Token = "0x170010E0")]
    public short inc_ct
    {
      [Token(Token = "0x6007B0E"), Address(RVA = "0x3DCBD0", Offset = "0x3DB9D0", VA = "0x103DCBD0")] get
      {
        return new short();
      }
      [Token(Token = "0x6007B0F"), Address(RVA = "0x3DD800", Offset = "0x3DC600", VA = "0x103DD800")] set
      {
      }
    }

    [Token(Token = "0x170010E1")]
    public short esa_fire
    {
      [Token(Token = "0x6007B10"), Address(RVA = "0x3DCA20", Offset = "0x3DB820", VA = "0x103DCA20")] get
      {
        return new short();
      }
      [Token(Token = "0x6007B11"), Address(RVA = "0x3DD650", Offset = "0x3DC450", VA = "0x103DD650")] set
      {
      }
    }

    [Token(Token = "0x170010E2")]
    public short esa_water
    {
      [Token(Token = "0x6007B12"), Address(RVA = "0x3DCAB0", Offset = "0x3DB8B0", VA = "0x103DCAB0")] get
      {
        return new short();
      }
      [Token(Token = "0x6007B13"), Address(RVA = "0x3DD6E0", Offset = "0x3DC4E0", VA = "0x103DD6E0")] set
      {
      }
    }

    [Token(Token = "0x170010E3")]
    public short esa_wind
    {
      [Token(Token = "0x6007B14"), Address(RVA = "0x3DCAE0", Offset = "0x3DB8E0", VA = "0x103DCAE0")] get
      {
        return new short();
      }
      [Token(Token = "0x6007B15"), Address(RVA = "0x3DD710", Offset = "0x3DC510", VA = "0x103DD710")] set
      {
      }
    }

    [Token(Token = "0x170010E4")]
    public short esa_thunder
    {
      [Token(Token = "0x6007B16"), Address(RVA = "0x3DCA80", Offset = "0x3DB880", VA = "0x103DCA80")] get
      {
        return new short();
      }
      [Token(Token = "0x6007B17"), Address(RVA = "0x3DD6B0", Offset = "0x3DC4B0", VA = "0x103DD6B0")] set
      {
      }
    }

    [Token(Token = "0x170010E5")]
    public short esa_shine
    {
      [Token(Token = "0x6007B18"), Address(RVA = "0x3DCA50", Offset = "0x3DB850", VA = "0x103DCA50")] get
      {
        return new short();
      }
      [Token(Token = "0x6007B19"), Address(RVA = "0x3DD680", Offset = "0x3DC480", VA = "0x103DD680")] set
      {
      }
    }

    [Token(Token = "0x170010E6")]
    public short esa_dark
    {
      [Token(Token = "0x6007B1A"), Address(RVA = "0x3DC9F0", Offset = "0x3DB7F0", VA = "0x103DC9F0")] get
      {
        return new short();
      }
      [Token(Token = "0x6007B1B"), Address(RVA = "0x3DD620", Offset = "0x3DC420", VA = "0x103DD620")] set
      {
      }
    }

    [Token(Token = "0x170010E7")]
    public short max_damage_hp
    {
      [Token(Token = "0x6007B1C"), Address(RVA = "0x3DCC30", Offset = "0x3DBA30", VA = "0x103DCC30")] get
      {
        return new short();
      }
      [Token(Token = "0x6007B1D"), Address(RVA = "0x3DD860", Offset = "0x3DC660", VA = "0x103DD860")] set
      {
      }
    }

    [Token(Token = "0x170010E8")]
    public short max_damage_mp
    {
      [Token(Token = "0x6007B1E"), Address(RVA = "0x3DCC60", Offset = "0x3DBA60", VA = "0x103DCC60")] get
      {
        return new short();
      }
      [Token(Token = "0x6007B1F"), Address(RVA = "0x3DD890", Offset = "0x3DC690", VA = "0x103DD890")] set
      {
      }
    }

    [Token(Token = "0x170010E9")]
    public short side_attack
    {
      [Token(Token = "0x6007B20"), Address(RVA = "0x3DCE70", Offset = "0x3DBC70", VA = "0x103DCE70")] get
      {
        return new short();
      }
      [Token(Token = "0x6007B21"), Address(RVA = "0x3DDAA0", Offset = "0x3DC8A0", VA = "0x103DDAA0")] set
      {
      }
    }

    [Token(Token = "0x170010EA")]
    public short back_attack
    {
      [Token(Token = "0x6007B22"), Address(RVA = "0x3DC8A0", Offset = "0x3DB6A0", VA = "0x103DC8A0")] get
      {
        return new short();
      }
      [Token(Token = "0x6007B23"), Address(RVA = "0x3DD4D0", Offset = "0x3DC2D0", VA = "0x103DD4D0")] set
      {
      }
    }

    [Token(Token = "0x170010EB")]
    public short obst_reaction
    {
      [Token(Token = "0x6007B24"), Address(RVA = "0x3DCD80", Offset = "0x3DBB80", VA = "0x103DCD80")] get
      {
        return new short();
      }
      [Token(Token = "0x6007B25"), Address(RVA = "0x3DD9B0", Offset = "0x3DC7B0", VA = "0x103DD9B0")] set
      {
      }
    }

    [Token(Token = "0x170010EC")]
    public short forced_targeting
    {
      [Token(Token = "0x6007B26"), Address(RVA = "0x3DCB40", Offset = "0x3DB940", VA = "0x103DCB40")] get
      {
        return new short();
      }
      [Token(Token = "0x6007B27"), Address(RVA = "0x3DD770", Offset = "0x3DC570", VA = "0x103DD770")] set
      {
      }
    }

    [Token(Token = "0x170010ED")]
    public short notsup
    {
      [Token(Token = "0x6007B28"), Address(RVA = "0x3DCD50", Offset = "0x3DBB50", VA = "0x103DCD50")] get
      {
        return new short();
      }
      [Token(Token = "0x6007B29"), Address(RVA = "0x3DD980", Offset = "0x3DC780", VA = "0x103DD980")] set
      {
      }
    }

    [Token(Token = "0x170010EE")]
    public short bomb
    {
      [Token(Token = "0x6007B2A"), Address(RVA = "0x3DC900", Offset = "0x3DB700", VA = "0x103DC900")] get
      {
        return new short();
      }
      [Token(Token = "0x6007B2B"), Address(RVA = "0x3DD530", Offset = "0x3DC330", VA = "0x103DD530")] set
      {
      }
    }

    [Token(Token = "0x170010EF")]
    public short slip
    {
      [Token(Token = "0x6007B2C"), Address(RVA = "0x3DCED0", Offset = "0x3DBCD0", VA = "0x103DCED0")] get
      {
        return new short();
      }
      [Token(Token = "0x6007B2D"), Address(RVA = "0x3DDB00", Offset = "0x3DC900", VA = "0x103DDB00")] set
      {
      }
    }

    [Token(Token = "0x170010F0")]
    public short freeze
    {
      [Token(Token = "0x6007B2E"), Address(RVA = "0x3DCB70", Offset = "0x3DB970", VA = "0x103DCB70")] get
      {
        return new short();
      }
      [Token(Token = "0x6007B2F"), Address(RVA = "0x3DD7A0", Offset = "0x3DC5A0", VA = "0x103DD7A0")] set
      {
      }
    }

    [Token(Token = "0x170010F1")]
    public short down
    {
      [Token(Token = "0x6007B30"), Address(RVA = "0x3DC9C0", Offset = "0x3DB7C0", VA = "0x103DC9C0")] get
      {
        return new short();
      }
      [Token(Token = "0x6007B31"), Address(RVA = "0x3DD5F0", Offset = "0x3DC3F0", VA = "0x103DD5F0")] set
      {
      }
    }

    [Token(Token = "0x170010F2")]
    [IgnoreMember]
    public short this[EUnitCondition condition]
    {
      [Token(Token = "0x6007B32"), Address(RVA = "0x3DC2A0", Offset = "0x3DB0A0", VA = "0x103DC2A0")] get
      {
        return new short();
      }
      [Token(Token = "0x6007B33"), Address(RVA = "0x3DCF90", Offset = "0x3DBD90", VA = "0x103DCF90")] set
      {
      }
    }

    [Token(Token = "0x6007B34")]
    [Address(RVA = "0x3B84B0", Offset = "0x3B72B0", VA = "0x103B84B0")]
    public void Clear()
    {
    }

    [Token(Token = "0x6007B35")]
    [Address(RVA = "0x3B84E0", Offset = "0x3B72E0", VA = "0x103B84E0")]
    public void CopyTo(EnchantParam dsc)
    {
    }

    [Token(Token = "0x6007B36")]
    [Address(RVA = "0x3DB9B0", Offset = "0x3DA7B0", VA = "0x103DB9B0")]
    public void Add(EnchantParam src)
    {
    }

    [Token(Token = "0x6007B37")]
    [Address(RVA = "0x3DBDB0", Offset = "0x3DABB0", VA = "0x103DBDB0")]
    public void Sub(EnchantParam src)
    {
    }

    [Token(Token = "0x6007B38")]
    [Address(RVA = "0x3DB760", Offset = "0x3DA560", VA = "0x103DB760")]
    public void AddRate(EnchantParam src)
    {
    }

    [Token(Token = "0x6007B39")]
    [Address(RVA = "0x3DB530", Offset = "0x3DA330", VA = "0x103DB530")]
    public void AddRateRoundUp(EnchantParam src)
    {
    }

    [Token(Token = "0x6007B3A")]
    [Address(RVA = "0x3DBCA0", Offset = "0x3DAAA0", VA = "0x103DBCA0")]
    public void SubRateRoundDown(long percent)
    {
    }

    [Token(Token = "0x6007B3B")]
    [Address(RVA = "0x3B86D0", Offset = "0x3B74D0", VA = "0x103B86D0")]
    public void ReplceHighest(EnchantParam comp)
    {
    }

    [Token(Token = "0x6007B3C")]
    [Address(RVA = "0x3B8750", Offset = "0x3B7550", VA = "0x103B8750")]
    public void ReplceLowest(EnchantParam comp)
    {
    }

    [Token(Token = "0x6007B3D")]
    [Address(RVA = "0x3B8310", Offset = "0x3B7110", VA = "0x103B8310")]
    public void ChoiceHighest(EnchantParam scale, EnchantParam base_status)
    {
    }

    [Token(Token = "0x6007B3E")]
    [Address(RVA = "0x3B83E0", Offset = "0x3B71E0", VA = "0x103B83E0")]
    public void ChoiceLowest(EnchantParam scale, EnchantParam base_status)
    {
    }

    [Token(Token = "0x6007B3F")]
    [Address(RVA = "0x3B7C10", Offset = "0x3B6A10", VA = "0x103B7C10")]
    public void AddConvRate(EnchantParam scale, EnchantParam base_status)
    {
    }

    [Token(Token = "0x6007B40")]
    [Address(RVA = "0x3B87D0", Offset = "0x3B75D0", VA = "0x103B87D0")]
    public void SubConvRate(EnchantParam scale, EnchantParam base_status)
    {
    }

    [Token(Token = "0x6007B41")]
    [Address(RVA = "0x3B8660", Offset = "0x3B7460", VA = "0x103B8660")]
    public void Mul(int mul_val)
    {
    }

    [Token(Token = "0x6007B42")]
    [Address(RVA = "0x3B8550", Offset = "0x3B7350", VA = "0x103B8550")]
    public void Div(int div_val)
    {
    }

    [Token(Token = "0x6007B43")]
    [Address(RVA = "0x3DBF90", Offset = "0x3DAD90", VA = "0x103DBF90")]
    public void Swap(EnchantParam src, bool is_rev)
    {
    }

    [Token(Token = "0x6007B44")]
    [Address(RVA = "0x3DBBE0", Offset = "0x3DA9E0", VA = "0x103DBBE0")]
    public ParamTypes GetAssistParamTypes(int index) => new ParamTypes();

    [Token(Token = "0x6007B45")]
    [Address(RVA = "0x3DBC40", Offset = "0x3DAA40", VA = "0x103DBC40")]
    public ParamTypes GetResistParamTypes(int index) => new ParamTypes();

    [Token(Token = "0x6007B46")]
    [Address(RVA = "0x3DC220", Offset = "0x3DB020", VA = "0x103DC220")]
    public EnchantParam()
    {
    }

    [Token(Token = "0x6007B47")]
    [Address(RVA = "0x3DC0E0", Offset = "0x3DAEE0", VA = "0x103DC0E0")]
    static EnchantParam()
    {
    }
  }
}
