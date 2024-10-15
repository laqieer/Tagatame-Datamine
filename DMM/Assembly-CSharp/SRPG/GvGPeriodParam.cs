// Decompiled with JetBrains decompiler
// Type: SRPG.GvGPeriodParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B83")]
  public class GvGPeriodParam : GvGMasterParam<JSON_GvGPeriodParam>
  {
    [Token(Token = "0x17000DAF")]
    public int Id
    {
      [Token(Token = "0x600719B"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
      [Token(Token = "0x600719C"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] private set
      {
      }
    }

    [Token(Token = "0x17000DB0")]
    public DateTime PrepareAt
    {
      [Token(Token = "0x600719D"), Address(RVA = "0x31CBE0", Offset = "0x31B9E0", VA = "0x1031CBE0")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x600719E"), Address(RVA = "0x374A90", Offset = "0x373890", VA = "0x10374A90")] private set
      {
      }
    }

    [Token(Token = "0x17000DB1")]
    public DateTime BeginAt
    {
      [Token(Token = "0x600719F"), Address(RVA = "0x31CBF0", Offset = "0x31B9F0", VA = "0x1031CBF0")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x60071A0"), Address(RVA = "0x372E10", Offset = "0x371C10", VA = "0x10372E10")] private set
      {
      }
    }

    [Token(Token = "0x17000DB2")]
    public DateTime EndAt
    {
      [Token(Token = "0x60071A1"), Address(RVA = "0x31F940", Offset = "0x31E740", VA = "0x1031F940")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x60071A2"), Address(RVA = "0x34D360", Offset = "0x34C160", VA = "0x1034D360")] private set
      {
      }
    }

    [Token(Token = "0x17000DB3")]
    public DateTime ExitAt
    {
      [Token(Token = "0x60071A3"), Address(RVA = "0x31F950", Offset = "0x31E750", VA = "0x1031F950")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x60071A4"), Address(RVA = "0x305820", Offset = "0x304620", VA = "0x10305820")] private set
      {
      }
    }

    [Token(Token = "0x17000DB4")]
    public string DeclarationStartTime
    {
      [Token(Token = "0x60071A5"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60071A6"), Address(RVA = "0x34C010", Offset = "0x34AE10", VA = "0x1034C010")] private set
      {
      }
    }

    [Token(Token = "0x17000DB5")]
    public string DeclarationEndTime
    {
      [Token(Token = "0x60071A7"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60071A8"), Address(RVA = "0x34C030", Offset = "0x34AE30", VA = "0x1034C030")] private set
      {
      }
    }

    [Token(Token = "0x17000DB6")]
    public int DeclarationCoolMinites
    {
      [Token(Token = "0x60071A9"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return new int();
      }
      [Token(Token = "0x60071AA"), Address(RVA = "0x374A30", Offset = "0x373830", VA = "0x10374A30")] private set
      {
      }
    }

    [Token(Token = "0x17000DB7")]
    public string BattleStartTime
    {
      [Token(Token = "0x60071AB"), Address(RVA = "0x288010", Offset = "0x286E10", VA = "0x10288010")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60071AC"), Address(RVA = "0x36F610", Offset = "0x36E410", VA = "0x1036F610")] private set
      {
      }
    }

    [Token(Token = "0x17000DB8")]
    public string BattleEndTime
    {
      [Token(Token = "0x60071AD"), Address(RVA = "0x34EDB0", Offset = "0x34DBB0", VA = "0x1034EDB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60071AE"), Address(RVA = "0x36F630", Offset = "0x36E430", VA = "0x1036F630")] private set
      {
      }
    }

    [Token(Token = "0x17000DB9")]
    public string BattleCoolStartTime
    {
      [Token(Token = "0x60071AF"), Address(RVA = "0x2880B0", Offset = "0x286EB0", VA = "0x102880B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60071B0"), Address(RVA = "0x2886E0", Offset = "0x2874E0", VA = "0x102886E0")] private set
      {
      }
    }

    [Token(Token = "0x17000DBA")]
    public string BattleCoolEndTime
    {
      [Token(Token = "0x60071B1"), Address(RVA = "0x288000", Offset = "0x286E00", VA = "0x10288000")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60071B2"), Address(RVA = "0x288230", Offset = "0x287030", VA = "0x10288230")] private set
      {
      }
    }

    [Token(Token = "0x17000DBB")]
    public int DeclaredCoolMinutes
    {
      [Token(Token = "0x60071B3"), Address(RVA = "0x2AABE0", Offset = "0x2A99E0", VA = "0x102AABE0")] get
      {
        return new int();
      }
      [Token(Token = "0x60071B4"), Address(RVA = "0x374A50", Offset = "0x373850", VA = "0x10374A50")] private set
      {
      }
    }

    [Token(Token = "0x17000DBC")]
    public int BattleCoolSeconds
    {
      [Token(Token = "0x60071B5"), Address(RVA = "0x3490F0", Offset = "0x347EF0", VA = "0x103490F0")] get
      {
        return new int();
      }
      [Token(Token = "0x60071B6"), Address(RVA = "0x34FD00", Offset = "0x34EB00", VA = "0x1034FD00")] private set
      {
      }
    }

    [Token(Token = "0x17000DBD")]
    public int DeclareNum
    {
      [Token(Token = "0x60071B7"), Address(RVA = "0x349170", Offset = "0x347F70", VA = "0x10349170")] get
      {
        return new int();
      }
      [Token(Token = "0x60071B8"), Address(RVA = "0x374A40", Offset = "0x373840", VA = "0x10374A40")] private set
      {
      }
    }

    [Token(Token = "0x17000DBE")]
    public int MapIndex
    {
      [Token(Token = "0x60071B9"), Address(RVA = "0x349160", Offset = "0x347F60", VA = "0x10349160")] get
      {
        return new int();
      }
      [Token(Token = "0x60071BA"), Address(RVA = "0x374A60", Offset = "0x373860", VA = "0x10374A60")] private set
      {
      }
    }

    [Token(Token = "0x17000DBF")]
    public int MatchingCountMin
    {
      [Token(Token = "0x60071BB"), Address(RVA = "0x288090", Offset = "0x286E90", VA = "0x10288090")] get
      {
        return new int();
      }
      [Token(Token = "0x60071BC"), Address(RVA = "0x374A80", Offset = "0x373880", VA = "0x10374A80")] private set
      {
      }
    }

    [Token(Token = "0x17000DC0")]
    public int MatchingCountMax
    {
      [Token(Token = "0x60071BD"), Address(RVA = "0x2B5EA0", Offset = "0x2B4CA0", VA = "0x102B5EA0")] get
      {
        return new int();
      }
      [Token(Token = "0x60071BE"), Address(RVA = "0x374A70", Offset = "0x373870", VA = "0x10374A70")] private set
      {
      }
    }

    [Token(Token = "0x17000DC1")]
    public int FirstOccupyNodeNum
    {
      [Token(Token = "0x60071BF"), Address(RVA = "0x2B6040", Offset = "0x2B4E40", VA = "0x102B6040")] get
      {
        return new int();
      }
      [Token(Token = "0x60071C0"), Address(RVA = "0x352460", Offset = "0x351260", VA = "0x10352460")] private set
      {
      }
    }

    [Token(Token = "0x17000DC2")]
    public int DefenseUnitMin
    {
      [Token(Token = "0x60071C1"), Address(RVA = "0x349350", Offset = "0x348150", VA = "0x10349350")] get
      {
        return new int();
      }
      [Token(Token = "0x60071C2"), Address(RVA = "0x370630", Offset = "0x36F430", VA = "0x10370630")] private set
      {
      }
    }

    [Token(Token = "0x17000DC3")]
    public string URL
    {
      [Token(Token = "0x60071C3"), Address(RVA = "0x288AC0", Offset = "0x2878C0", VA = "0x10288AC0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60071C4"), Address(RVA = "0x288AE0", Offset = "0x2878E0", VA = "0x10288AE0")] private set
      {
      }
    }

    [Token(Token = "0x17000DC4")]
    public string URL_TITLE
    {
      [Token(Token = "0x60071C5"), Address(RVA = "0x288AD0", Offset = "0x2878D0", VA = "0x10288AD0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60071C6"), Address(RVA = "0x288B00", Offset = "0x287900", VA = "0x10288B00")] private set
      {
      }
    }

    [Token(Token = "0x17000DC5")]
    public List<string> RuleCycle
    {
      [Token(Token = "0x60071C7"), Address(RVA = "0x349360", Offset = "0x348160", VA = "0x10349360")] get
      {
        return (List<string>) null;
      }
      [Token(Token = "0x60071C8"), Address(RVA = "0x374AB0", Offset = "0x3738B0", VA = "0x10374AB0")] private set
      {
      }
    }

    [Token(Token = "0x60071C9")]
    [Address(RVA = "0x373DC0", Offset = "0x372BC0", VA = "0x10373DC0", Slot = "4")]
    public override bool Deserialize(JSON_GvGPeriodParam json) => new bool();

    [Token(Token = "0x60071CA")]
    [Address(RVA = "0x3744E0", Offset = "0x3732E0", VA = "0x103744E0")]
    public static GvGPeriodParam GetGvGPeriod() => (GvGPeriodParam) null;

    [Token(Token = "0x60071CB")]
    [Address(RVA = "0x373FE0", Offset = "0x372DE0", VA = "0x10373FE0")]
    public static GvGPeriodParam GetGvGExitPeriod() => (GvGPeriodParam) null;

    [Token(Token = "0x60071CC")]
    [Address(RVA = "0x3746F0", Offset = "0x3734F0", VA = "0x103746F0")]
    public static GvGPeriodParam GetGvGPeriod(int id) => (GvGPeriodParam) null;

    [Token(Token = "0x60071CD")]
    [Address(RVA = "0x3741E0", Offset = "0x372FE0", VA = "0x103741E0")]
    public static GvGPeriodParam GetGvGNearPeriod() => (GvGPeriodParam) null;

    [Token(Token = "0x60071CE")]
    [Address(RVA = "0x374830", Offset = "0x373630", VA = "0x10374830")]
    public static bool IsGvGPrepare() => new bool();

    [Token(Token = "0x60071CF")]
    [Address(RVA = "0x3749F0", Offset = "0x3737F0", VA = "0x103749F0")]
    public GvGPeriodParam()
    {
    }
  }
}
