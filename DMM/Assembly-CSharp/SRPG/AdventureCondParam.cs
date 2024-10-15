// Decompiled with JetBrains decompiler
// Type: SRPG.AdventureCondParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001973")]
  public class AdventureCondParam
  {
    [Token(Token = "0x4005CB7")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x4005CB8")]
    [FieldOffset(Offset = "0xC")]
    private List<AdventureCondParam.Cond> mCondList;

    [Token(Token = "0x17000AAD")]
    public string Iname
    {
      [Token(Token = "0x60067C8"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000AAE")]
    public List<AdventureCondParam.Cond> CondList
    {
      [Token(Token = "0x60067C9"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<AdventureCondParam.Cond>) null;
      }
    }

    [Token(Token = "0x60067CA")]
    [Address(RVA = "0x31CDA0", Offset = "0x31BBA0", VA = "0x1031CDA0")]
    public void Deserialize(JSON_AdventureCondParam json)
    {
    }

    [Token(Token = "0x60067CB")]
    [Address(RVA = "0x31CC00", Offset = "0x31BA00", VA = "0x1031CC00")]
    public static void Deserialize(
      ref List<AdventureCondParam> list,
      JSON_AdventureCondParam[] json)
    {
    }

    [Token(Token = "0x60067CC")]
    [Address(RVA = "0x31CF70", Offset = "0x31BD70", VA = "0x1031CF70")]
    public static AdventureCondParam GetParam(string iname) => (AdventureCondParam) null;

    [Token(Token = "0x60067CD")]
    [Address(RVA = "0x31D590", Offset = "0x31C390", VA = "0x1031D590")]
    public bool IsUnitCond(UnitData _unit, bool _is_check_combat_power) => new bool();

    [Token(Token = "0x60067CE")]
    [Address(RVA = "0x31D1E0", Offset = "0x31BFE0", VA = "0x1031D1E0")]
    public bool IsCondOnlyCombatPower(UnitData _unit, int _combat_power) => new bool();

    [Token(Token = "0x60067CF")]
    [Address(RVA = "0x31D080", Offset = "0x31BE80", VA = "0x1031D080")]
    public bool IsCondOnlyAllCombatPower(int _combat_power) => new bool();

    [Token(Token = "0x60067D0")]
    [Address(RVA = "0x31D340", Offset = "0x31C140", VA = "0x1031D340")]
    public bool IsPartyCond(PartyData _party, AdventureCondParam.Cond _cond_data) => new bool();

    [Token(Token = "0x60067D1")]
    [Address(RVA = "0x31D870", Offset = "0x31C670", VA = "0x1031D870")]
    public AdventureCondParam()
    {
    }

    [Token(Token = "0x2001974")]
    public enum eCondType
    {
      [Token(Token = "0x4005CBA")] None,
      [Token(Token = "0x4005CBB")] Level,
      [Token(Token = "0x4005CBC")] UnitGroup,
      [Token(Token = "0x4005CBD")] Element,
      [Token(Token = "0x4005CBE")] Birth,
      [Token(Token = "0x4005CBF")] Gender,
      [Token(Token = "0x4005CC0")] CombatPower,
      [Token(Token = "0x4005CC1")] AllCombatPower,
    }

    [Token(Token = "0x2001975")]
    public class Cond
    {
      [Token(Token = "0x4005CC2")]
      [FieldOffset(Offset = "0x8")]
      private AdventureCondParam.eCondType mCondType;
      [Token(Token = "0x4005CC3")]
      [FieldOffset(Offset = "0xC")]
      private string mCondText;
      [Token(Token = "0x4005CC4")]
      [FieldOffset(Offset = "0x10")]
      private int mLevel;
      [Token(Token = "0x4005CC5")]
      [FieldOffset(Offset = "0x14")]
      private string mUnitGroupId;
      [Token(Token = "0x4005CC6")]
      [FieldOffset(Offset = "0x18")]
      private UnitGroupParam mUnitGroupParam;
      [Token(Token = "0x4005CC7")]
      [FieldOffset(Offset = "0x1C")]
      private List<EElement> mElementList;
      [Token(Token = "0x4005CC8")]
      [FieldOffset(Offset = "0x20")]
      private List<EBirth> mBirthList;
      [Token(Token = "0x4005CC9")]
      [FieldOffset(Offset = "0x24")]
      private ESex mGender;
      [Token(Token = "0x4005CCA")]
      [FieldOffset(Offset = "0x28")]
      private int mCombatPowerMin;
      [Token(Token = "0x4005CCB")]
      [FieldOffset(Offset = "0x2C")]
      private int mAllCombatPowerMin;

      [Token(Token = "0x17000AAF")]
      public AdventureCondParam.eCondType CondType
      {
        [Token(Token = "0x60067D2"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return new AdventureCondParam.eCondType();
        }
      }

      [Token(Token = "0x17000AB0")]
      public string CondText
      {
        [Token(Token = "0x60067D3"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17000AB1")]
      public int Level
      {
        [Token(Token = "0x60067D4"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17000AB2")]
      public UnitGroupParam UnitGroupParam
      {
        [Token(Token = "0x60067D5"), Address(RVA = "0x3215A0", Offset = "0x3203A0", VA = "0x103215A0")] get
        {
          return (UnitGroupParam) null;
        }
      }

      [Token(Token = "0x17000AB3")]
      public List<EElement> ElementList
      {
        [Token(Token = "0x60067D6"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
        {
          return (List<EElement>) null;
        }
      }

      [Token(Token = "0x17000AB4")]
      public List<EBirth> BirthList
      {
        [Token(Token = "0x60067D7"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
        {
          return (List<EBirth>) null;
        }
      }

      [Token(Token = "0x17000AB5")]
      public ESex Gender
      {
        [Token(Token = "0x60067D8"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
        {
          return new ESex();
        }
      }

      [Token(Token = "0x17000AB6")]
      public int CombatPowerMin
      {
        [Token(Token = "0x60067D9"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17000AB7")]
      public int AllCombatPowerMin
      {
        [Token(Token = "0x60067DA"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x60067DB")]
      [Address(RVA = "0x3212D0", Offset = "0x3200D0", VA = "0x103212D0")]
      public void Deserialize(JSON_AdventureCondParam.Cond json)
      {
      }

      [Token(Token = "0x60067DC")]
      [Address(RVA = "0x3214F0", Offset = "0x3202F0", VA = "0x103214F0")]
      public Cond()
      {
      }
    }
  }
}
