// Decompiled with JetBrains decompiler
// Type: SRPG.LeagueMatchSetBuffParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BB4")]
  [MessagePackObject(true)]
  public class LeagueMatchSetBuffParam
  {
    [Token(Token = "0x40069FF")]
    [FieldOffset(Offset = "0x8")]
    public ELeagueMatchBuffTarget mBuff_target;
    [Token(Token = "0x4006A00")]
    [FieldOffset(Offset = "0xC")]
    private string mBuff_iname;
    [Token(Token = "0x4006A01")]
    [FieldOffset(Offset = "0x10")]
    private string mIcon_name;
    [Token(Token = "0x4006A02")]
    [FieldOffset(Offset = "0x14")]
    private string mBuff_name;
    [Token(Token = "0x4006A03")]
    [FieldOffset(Offset = "0x18")]
    private string mBuff_description;
    [Token(Token = "0x4006A04")]
    [FieldOffset(Offset = "0x1C")]
    private int mNum;
    [Token(Token = "0x4006A05")]
    [FieldOffset(Offset = "0x20")]
    private LeagueMatchBuffSelectType mSelect_set;

    [Token(Token = "0x17000DF1")]
    public string Buff_iname
    {
      [Token(Token = "0x6007261"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000DF2")]
    public ELeagueMatchBuffTarget Buff_target
    {
      [Token(Token = "0x6007262"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new ELeagueMatchBuffTarget();
      }
    }

    [Token(Token = "0x17000DF3")]
    public string Icon_name
    {
      [Token(Token = "0x6007263"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000DF4")]
    public string Buff_name
    {
      [Token(Token = "0x6007264"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000DF5")]
    public string Buff_description
    {
      [Token(Token = "0x6007265"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000DF6")]
    public int Num
    {
      [Token(Token = "0x6007266"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000DF7")]
    public LeagueMatchBuffSelectType Select_set
    {
      [Token(Token = "0x6007267"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new LeagueMatchBuffSelectType();
      }
    }

    [Token(Token = "0x6007268")]
    [Address(RVA = "0x37A9F0", Offset = "0x3797F0", VA = "0x1037A9F0")]
    public bool Deserialize(JSON_LeagueMatchSetBuffParam json) => new bool();

    [Token(Token = "0x6007269")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public LeagueMatchSetBuffParam()
    {
    }
  }
}
