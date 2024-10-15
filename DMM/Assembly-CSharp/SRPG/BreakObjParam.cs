// Decompiled with JetBrains decompiler
// Type: SRPG.BreakObjParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001DD7")]
  public class BreakObjParam
  {
    [Token(Token = "0x400779C")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x400779D")]
    [FieldOffset(Offset = "0xC")]
    private string mName;
    [Token(Token = "0x400779E")]
    [FieldOffset(Offset = "0x10")]
    private string mExpr;
    [Token(Token = "0x400779F")]
    [FieldOffset(Offset = "0x14")]
    private string mUnitId;
    [Token(Token = "0x40077A0")]
    [FieldOffset(Offset = "0x18")]
    private eMapBreakClashType mClashType;
    [Token(Token = "0x40077A1")]
    [FieldOffset(Offset = "0x1C")]
    private eMapBreakAIType mAiType;
    [Token(Token = "0x40077A2")]
    [FieldOffset(Offset = "0x20")]
    private eMapBreakSideType mSideType;
    [Token(Token = "0x40077A3")]
    [FieldOffset(Offset = "0x24")]
    private eMapBreakRayType mRayType;
    [Token(Token = "0x40077A4")]
    [FieldOffset(Offset = "0x28")]
    private bool mIsUI;
    [Token(Token = "0x40077A5")]
    [FieldOffset(Offset = "0x2C")]
    private int[] mRestHps;
    [Token(Token = "0x40077A6")]
    [FieldOffset(Offset = "0x30")]
    private int mAliveClock;
    [Token(Token = "0x40077A7")]
    [FieldOffset(Offset = "0x34")]
    private EUnitDirection mAppearDir;

    [Token(Token = "0x17001082")]
    public string Iname
    {
      [Token(Token = "0x6007A1E"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001083")]
    public string Name
    {
      [Token(Token = "0x6007A1F"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001084")]
    public string Expr
    {
      [Token(Token = "0x6007A20"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001085")]
    public string UnitId
    {
      [Token(Token = "0x6007A21"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001086")]
    public eMapBreakClashType ClashType
    {
      [Token(Token = "0x6007A22"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new eMapBreakClashType();
      }
    }

    [Token(Token = "0x17001087")]
    public eMapBreakAIType AiType
    {
      [Token(Token = "0x6007A23"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new eMapBreakAIType();
      }
    }

    [Token(Token = "0x17001088")]
    public eMapBreakSideType SideType
    {
      [Token(Token = "0x6007A24"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new eMapBreakSideType();
      }
    }

    [Token(Token = "0x17001089")]
    public eMapBreakRayType RayType
    {
      [Token(Token = "0x6007A25"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new eMapBreakRayType();
      }
    }

    [Token(Token = "0x1700108A")]
    public bool IsUI
    {
      [Token(Token = "0x6007A26"), Address(RVA = "0x34F470", Offset = "0x34E270", VA = "0x1034F470")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700108B")]
    public int[] RestHps
    {
      [Token(Token = "0x6007A27"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (int[]) null;
      }
    }

    [Token(Token = "0x1700108C")]
    public int AliveClock
    {
      [Token(Token = "0x6007A28"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700108D")]
    public EUnitDirection AppearDir
    {
      [Token(Token = "0x6007A29"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return new EUnitDirection();
      }
    }

    [Token(Token = "0x6007A2A")]
    [Address(RVA = "0x3B8E80", Offset = "0x3B7C80", VA = "0x103B8E80")]
    public void Deserialize(JSON_BreakObjParam json)
    {
    }

    [Token(Token = "0x6007A2B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public BreakObjParam()
    {
    }
  }
}
