// Decompiled with JetBrains decompiler
// Type: SRPG.VersusEnableTimeParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EBE")]
  public class VersusEnableTimeParam
  {
    [Token(Token = "0x4008101")]
    [FieldOffset(Offset = "0x8")]
    private int mScheduleId;
    [Token(Token = "0x4008102")]
    [FieldOffset(Offset = "0xC")]
    private VERSUS_TYPE mVersusType;
    [Token(Token = "0x4008103")]
    [FieldOffset(Offset = "0x10")]
    private DateTime mBeginAt;
    [Token(Token = "0x4008104")]
    [FieldOffset(Offset = "0x18")]
    private DateTime mEndAt;
    [Token(Token = "0x4008105")]
    [FieldOffset(Offset = "0x20")]
    private int mDraftId;
    [Token(Token = "0x4008106")]
    [FieldOffset(Offset = "0x24")]
    private VersusDraftType mDraftType;
    [Token(Token = "0x4008107")]
    [FieldOffset(Offset = "0x28")]
    private List<int> mFriendDraftIdList;
    [Token(Token = "0x4008108")]
    [FieldOffset(Offset = "0x2C")]
    private List<VersusEnableTimeScheduleParam> mSchedule;
    [Token(Token = "0x4008109")]
    [FieldOffset(Offset = "0x30")]
    private int mDraftLockNum;
    [Token(Token = "0x400810A")]
    [FieldOffset(Offset = "0x34")]
    private string mTagatameCupIname;

    [Token(Token = "0x170011A5")]
    public int ScheduleId
    {
      [Token(Token = "0x6007DEB"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170011A6")]
    public VERSUS_TYPE VersusType
    {
      [Token(Token = "0x6007DEC"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new VERSUS_TYPE();
      }
    }

    [Token(Token = "0x170011A7")]
    public DateTime BeginAt
    {
      [Token(Token = "0x6007DED"), Address(RVA = "0x31CBE0", Offset = "0x31B9E0", VA = "0x1031CBE0")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x170011A8")]
    public DateTime EndAt
    {
      [Token(Token = "0x6007DEE"), Address(RVA = "0x31CBF0", Offset = "0x31B9F0", VA = "0x1031CBF0")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x170011A9")]
    public int DraftId
    {
      [Token(Token = "0x6007DEF"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170011AA")]
    public VersusDraftType DraftType
    {
      [Token(Token = "0x6007DF0"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new VersusDraftType();
      }
    }

    [Token(Token = "0x170011AB")]
    public List<int> FriendDraftIdList
    {
      [Token(Token = "0x6007DF1"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (List<int>) null;
      }
    }

    [Token(Token = "0x170011AC")]
    public List<VersusEnableTimeScheduleParam> Schedule
    {
      [Token(Token = "0x6007DF2"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (List<VersusEnableTimeScheduleParam>) null;
      }
    }

    [Token(Token = "0x170011AD")]
    public int DraftLockNum
    {
      [Token(Token = "0x6007DF3"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170011AE")]
    public string TagatameCupIname
    {
      [Token(Token = "0x6007DF4"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6007DF5")]
    [Address(RVA = "0x3FA410", Offset = "0x3F9210", VA = "0x103FA410")]
    public bool Deserialize(JSON_VersusEnableTimeParam json) => new bool();

    [Token(Token = "0x6007DF6")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public VersusEnableTimeParam()
    {
    }
  }
}
