// Decompiled with JetBrains decompiler
// Type: SRPG.GuildData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000F89")]
  public class GuildData
  {
    [Token(Token = "0x4003695")]
    [FieldOffset(Offset = "0x8")]
    private long mUniqueID;
    [Token(Token = "0x4003696")]
    [FieldOffset(Offset = "0x10")]
    private string mCreatedUid;
    [Token(Token = "0x4003697")]
    [FieldOffset(Offset = "0x14")]
    private string mName;
    [Token(Token = "0x4003698")]
    [FieldOffset(Offset = "0x18")]
    private string mEmblem;
    [Token(Token = "0x4003699")]
    [FieldOffset(Offset = "0x1C")]
    private string mBoard;
    [Token(Token = "0x400369A")]
    [FieldOffset(Offset = "0x20")]
    private int mMemberCount;
    [Token(Token = "0x400369B")]
    [FieldOffset(Offset = "0x24")]
    private int mMemberCountMax;
    [Token(Token = "0x400369C")]
    [FieldOffset(Offset = "0x28")]
    private int mSubMasterCountMax;
    [Token(Token = "0x400369D")]
    [FieldOffset(Offset = "0x2C")]
    private GuildEntryConditions mEntryConditions;
    [Token(Token = "0x400369E")]
    [FieldOffset(Offset = "0x30")]
    private GuildMemberData[] mMembers;
    [Token(Token = "0x400369F")]
    [FieldOffset(Offset = "0x34")]
    private string[] mHaveAwards;
    [Token(Token = "0x40036A0")]
    [FieldOffset(Offset = "0x38")]
    private GuildFacilityData[] mFacilities;
    [Token(Token = "0x40036A1")]
    [FieldOffset(Offset = "0x40")]
    private long mCreatedAt;
    [Token(Token = "0x40036A2")]
    [FieldOffset(Offset = "0x48")]
    private int mGvGJoinStatus;
    [Token(Token = "0x40036A3")]
    [FieldOffset(Offset = "0x4C")]
    private int mGvGRate;
    [Token(Token = "0x40036A4")]
    [FieldOffset(Offset = "0x50")]
    private int mBoardUnread;

    [Token(Token = "0x17000568")]
    public long UniqueID
    {
      [Token(Token = "0x6004067"), Address(RVA = "0x305C20", Offset = "0x304A20", VA = "0x10305C20")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x17000569")]
    public string CreatedUid
    {
      [Token(Token = "0x6004068"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700056A")]
    public string Name
    {
      [Token(Token = "0x6004069"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600406A"), Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")] set
      {
      }
    }

    [Token(Token = "0x1700056B")]
    public string Emblem
    {
      [Token(Token = "0x600406B"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600406C"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] set
      {
      }
    }

    [Token(Token = "0x1700056C")]
    public string Board
    {
      [Token(Token = "0x600406D"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600406E"), Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")] set
      {
      }
    }

    [Token(Token = "0x1700056D")]
    public GuildFacilityData[] Facilities
    {
      [Token(Token = "0x600406F"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return (GuildFacilityData[]) null;
      }
    }

    [Token(Token = "0x1700056E")]
    public long CreatedAt
    {
      [Token(Token = "0x6004070"), Address(RVA = "0x66AFE0", Offset = "0x669DE0", VA = "0x1066AFE0")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x1700056F")]
    public int GvGJoinStatus
    {
      [Token(Token = "0x6004071"), Address(RVA = "0x288000", Offset = "0x286E00", VA = "0x10288000")] get
      {
        return new int();
      }
      [Token(Token = "0x6004072"), Address(RVA = "0x370680", Offset = "0x36F480", VA = "0x10370680")] set
      {
      }
    }

    [Token(Token = "0x17000570")]
    public int GvGRate
    {
      [Token(Token = "0x6004073"), Address(RVA = "0x2AABE0", Offset = "0x2A99E0", VA = "0x102AABE0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000571")]
    public int BoardUnread
    {
      [Token(Token = "0x6004074"), Address(RVA = "0x3490F0", Offset = "0x347EF0", VA = "0x103490F0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000572")]
    public GuildEntryConditions EntryConditions
    {
      [Token(Token = "0x6004075"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (GuildEntryConditions) null;
      }
      [Token(Token = "0x6004076"), Address(RVA = "0x27FBD0", Offset = "0x27E9D0", VA = "0x1027FBD0")] set
      {
      }
    }

    [Token(Token = "0x17000573")]
    public GuildMemberData[] Members
    {
      [Token(Token = "0x6004077"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return (GuildMemberData[]) null;
      }
    }

    [Token(Token = "0x17000574")]
    public string[] HaveAwards
    {
      [Token(Token = "0x6004078"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return (string[]) null;
      }
    }

    [Token(Token = "0x17000575")]
    public int MemberMax
    {
      [Token(Token = "0x6004079"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000576")]
    public int SubMasterCountMax
    {
      [Token(Token = "0x600407A"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000577")]
    public int MemberCount
    {
      [Token(Token = "0x600407B"), Address(RVA = "0x1191DC0", Offset = "0x1190BC0", VA = "0x11191DC0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000578")]
    public GuildMemberData GuildMaster
    {
      [Token(Token = "0x600407C"), Address(RVA = "0x1191CD0", Offset = "0x1190AD0", VA = "0x11191CD0")] get
      {
        return (GuildMemberData) null;
      }
    }

    [Token(Token = "0x600407D")]
    [Address(RVA = "0x1191BA0", Offset = "0x11909A0", VA = "0x11191BA0")]
    public GuildData()
    {
    }

    [Token(Token = "0x600407E")]
    [Address(RVA = "0x11914C0", Offset = "0x11902C0", VA = "0x111914C0")]
    public bool Deserialize(JSON_Guild json) => new bool();

    [Token(Token = "0x600407F")]
    [Address(RVA = "0x1191220", Offset = "0x1190020", VA = "0x11191220")]
    public static GuildData CreateDefault() => (GuildData) null;

    [Token(Token = "0x6004080")]
    [Address(RVA = "0x1190E40", Offset = "0x118FC40", VA = "0x11190E40")]
    public static GuildData Clone(GuildData original) => (GuildData) null;

    [Token(Token = "0x6004081")]
    [Address(RVA = "0x11910B0", Offset = "0x118FEB0", VA = "0x111910B0")]
    public static Dictionary<int, string> CreateConditionsLvTable(int min_lv, int lv_distance)
    {
      return (Dictionary<int, string>) null;
    }

    [Token(Token = "0x6004082")]
    [Address(RVA = "0x1191050", Offset = "0x118FE50", VA = "0x11191050")]
    public void CopyParam(GuildData guild)
    {
    }

    [Token(Token = "0x6004083")]
    [Address(RVA = "0x1191A70", Offset = "0x1190870", VA = "0x11191A70")]
    public bool IsMatchConditions(PlayerData target_player) => new bool();

    [Token(Token = "0x6004084")]
    [Address(RVA = "0x1191AB0", Offset = "0x11908B0", VA = "0x11191AB0")]
    public void SetParam(long gid, string guild_name, GuildEntryConditions conditions)
    {
    }

    [Token(Token = "0x6004085")]
    [Address(RVA = "0x1191A00", Offset = "0x1190800", VA = "0x11191A00")]
    public GuildFacilityData GetFacilityData(GuildFacilityParam.eFacilityType facility_type)
    {
      return (GuildFacilityData) null;
    }
  }
}
