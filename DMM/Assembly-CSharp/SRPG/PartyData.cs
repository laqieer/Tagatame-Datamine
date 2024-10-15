// Decompiled with JetBrains decompiler
// Type: SRPG.PartyData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FE8")]
  public class PartyData : ICombatPowerContent
  {
    [Token(Token = "0x4003835")]
    public const int SYS_MAINMEMBER_MAX = 5;
    [Token(Token = "0x4003836")]
    [FieldOffset(Offset = "0x8")]
    private int mMAX_UNIT;
    [Token(Token = "0x4003837")]
    [FieldOffset(Offset = "0xC")]
    private int mMAX_MAINMEMBER;
    [Token(Token = "0x4003838")]
    [FieldOffset(Offset = "0x10")]
    private int mMAX_SUBMEMBER;
    [Token(Token = "0x4003839")]
    [FieldOffset(Offset = "0x14")]
    private int mMAINMEMBER_START;
    [Token(Token = "0x400383A")]
    [FieldOffset(Offset = "0x18")]
    private int mMAINMEMBER_END;
    [Token(Token = "0x400383B")]
    [FieldOffset(Offset = "0x1C")]
    private int mSUBMEMBER_START;
    [Token(Token = "0x400383C")]
    [FieldOffset(Offset = "0x20")]
    private int mSUBMEMBER_END;
    [Token(Token = "0x400383D")]
    [FieldOffset(Offset = "0x24")]
    private int mVSWAITMEMBER_START;
    [Token(Token = "0x400383E")]
    [FieldOffset(Offset = "0x28")]
    private int mVSWAITMEMBER_END;
    [Token(Token = "0x400383F")]
    [FieldOffset(Offset = "0x2C")]
    private string mName;
    [Token(Token = "0x4003840")]
    [FieldOffset(Offset = "0x30")]
    private long[] mUniqueIDs;
    [Token(Token = "0x4003841")]
    [FieldOffset(Offset = "0x34")]
    private int mLeaderIndex;

    [Token(Token = "0x170005FD")]
    public int MAX_UNIT
    {
      [Token(Token = "0x6004221"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170005FE")]
    public int MAX_MAINMEMBER
    {
      [Token(Token = "0x6004222"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170005FF")]
    public int MAX_SUBMEMBER
    {
      [Token(Token = "0x6004223"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000600")]
    public int MAINMEMBER_START
    {
      [Token(Token = "0x6004224"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000601")]
    public int MAINMEMBER_END
    {
      [Token(Token = "0x6004225"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000602")]
    public int SUBMEMBER_START
    {
      [Token(Token = "0x6004226"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000603")]
    public int SUBMEMBER_END
    {
      [Token(Token = "0x6004227"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000604")]
    public int VSWAITMEMBER_START
    {
      [Token(Token = "0x6004228"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000605")]
    public int VSWAITMEMBER_END
    {
      [Token(Token = "0x6004229"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000606")]
    public string Name
    {
      [Token(Token = "0x600422A"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600422B"), Address(RVA = "0x27FBD0", Offset = "0x27E9D0", VA = "0x1027FBD0")] set
      {
      }
    }

    [Token(Token = "0x17000607")]
    public int Num
    {
      [Token(Token = "0x600422C"), Address(RVA = "0x119BE20", Offset = "0x119AC20", VA = "0x1119BE20")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000608")]
    public int LeaderIndex
    {
      [Token(Token = "0x600422D"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000609")]
    public PlayerPartyTypes PartyType
    {
      [Token(Token = "0x600422E"), Address(RVA = "0x374A30", Offset = "0x373830", VA = "0x10374A30")] set
      {
      }
      [Token(Token = "0x600422F"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return new PlayerPartyTypes();
      }
    }

    [Token(Token = "0x1700060A")]
    public bool Selected
    {
      [Token(Token = "0x6004230"), Address(RVA = "0x428390", Offset = "0x427190", VA = "0x10428390")] set
      {
      }
      [Token(Token = "0x6004231"), Address(RVA = "0x428380", Offset = "0x427180", VA = "0x10428380")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700060B")]
    public bool IsDefense
    {
      [Token(Token = "0x6004232"), Address(RVA = "0x56B2F0", Offset = "0x56A0F0", VA = "0x1056B2F0")] set
      {
      }
      [Token(Token = "0x6004233"), Address(RVA = "0x56B2D0", Offset = "0x56A0D0", VA = "0x1056B2D0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700060C")]
    public long CombatPower
    {
      [Token(Token = "0x6004234"), Address(RVA = "0x119BCF0", Offset = "0x119AAF0", VA = "0x1119BCF0", Slot = "4")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x6004235")]
    [Address(RVA = "0x119BB10", Offset = "0x119A910", VA = "0x1119BB10")]
    public PartyData(PlayerPartyTypes type)
    {
    }

    [Token(Token = "0x6004236")]
    [Address(RVA = "0x119B080", Offset = "0x1199E80", VA = "0x1119B080")]
    public static PlayerPartyTypes GetPartyTypeFromString(string ptype) => new PlayerPartyTypes();

    [Token(Token = "0x6004237")]
    [Address(RVA = "0x119B5D0", Offset = "0x119A3D0", VA = "0x1119B5D0")]
    public static string GetStringFromPartyType(PlayerPartyTypes type) => (string) null;

    [Token(Token = "0x6004238")]
    [Address(RVA = "0x119AF60", Offset = "0x1199D60", VA = "0x1119AF60")]
    public void Deserialize(Json_Party json)
    {
    }

    [Token(Token = "0x6004239")]
    [Address(RVA = "0x119B8D0", Offset = "0x119A6D0", VA = "0x1119B8D0")]
    public void Reset()
    {
    }

    [Token(Token = "0x600423A")]
    [Address(RVA = "0x119B900", Offset = "0x119A700", VA = "0x1119B900")]
    public void SetParty(PartyData org)
    {
    }

    [Token(Token = "0x600423B")]
    [Address(RVA = "0x119B9B0", Offset = "0x119A7B0", VA = "0x1119B9B0")]
    public void SetUnitUniqueID(int index, long uniqueid)
    {
    }

    [Token(Token = "0x600423C")]
    [Address(RVA = "0x119B810", Offset = "0x119A610", VA = "0x1119B810")]
    public long GetUnitUniqueID(int index) => new long();

    [Token(Token = "0x600423D")]
    [Address(RVA = "0x119B850", Offset = "0x119A650", VA = "0x1119B850")]
    public bool IsPartyUnit(long uniqueid) => new bool();

    [Token(Token = "0x600423E")]
    [Address(RVA = "0x119B030", Offset = "0x1199E30", VA = "0x1119B030")]
    public int FindPartyUnit(long uniqueid) => new int();

    [Token(Token = "0x600423F")]
    [Address(RVA = "0x119B870", Offset = "0x119A670", VA = "0x1119B870")]
    public bool IsSub(long uniqueid) => new bool();

    [Token(Token = "0x6004240")]
    [Address(RVA = "0x119B8A0", Offset = "0x119A6A0", VA = "0x1119B8A0")]
    public bool IsSub(UnitData unit) => new bool();

    [Token(Token = "0x6004241")]
    [Address(RVA = "0x119B9F0", Offset = "0x119A7F0", VA = "0x1119B9F0")]
    public UnitData[] ToUnits() => (UnitData[]) null;
  }
}
