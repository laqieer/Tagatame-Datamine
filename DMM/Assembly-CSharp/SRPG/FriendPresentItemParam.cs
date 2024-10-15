// Decompiled with JetBrains decompiler
// Type: SRPG.FriendPresentItemParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001AE9")]
  public class FriendPresentItemParam
  {
    [Token(Token = "0x400660E")]
    public const string DEAULT_ID = "FP_DEFAULT";
    [Token(Token = "0x400660F")]
    [FieldOffset(Offset = "0x0")]
    public static FriendPresentItemParam DefaultParam;
    [Token(Token = "0x4006610")]
    [FieldOffset(Offset = "0x8")]
    private string m_Id;
    [Token(Token = "0x4006611")]
    [FieldOffset(Offset = "0xC")]
    private string m_Name;
    [Token(Token = "0x4006612")]
    [FieldOffset(Offset = "0x10")]
    private string m_Expr;
    [Token(Token = "0x4006613")]
    [FieldOffset(Offset = "0x14")]
    private ItemParam m_Item;
    [Token(Token = "0x4006614")]
    [FieldOffset(Offset = "0x18")]
    private int m_Num;
    [Token(Token = "0x4006615")]
    [FieldOffset(Offset = "0x1C")]
    private int m_Zeny;
    [Token(Token = "0x4006616")]
    [FieldOffset(Offset = "0x20")]
    private long m_BeginAt;
    [Token(Token = "0x4006617")]
    [FieldOffset(Offset = "0x28")]
    private long m_EndAt;

    [Token(Token = "0x17000CAF")]
    public string iname
    {
      [Token(Token = "0x6006F05"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000CB0")]
    public string name
    {
      [Token(Token = "0x6006F06"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000CB1")]
    public string expr
    {
      [Token(Token = "0x6006F07"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000CB2")]
    public ItemParam item
    {
      [Token(Token = "0x6006F08"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (ItemParam) null;
      }
    }

    [Token(Token = "0x17000CB3")]
    public int num
    {
      [Token(Token = "0x6006F09"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CB4")]
    public int zeny
    {
      [Token(Token = "0x6006F0A"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CB5")]
    public long begin_at
    {
      [Token(Token = "0x6006F0B"), Address(RVA = "0x34F490", Offset = "0x34E290", VA = "0x1034F490")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x17000CB6")]
    public long end_at
    {
      [Token(Token = "0x6006F0C"), Address(RVA = "0x3057C0", Offset = "0x3045C0", VA = "0x103057C0")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x6006F0D")]
    [Address(RVA = "0x368320", Offset = "0x367120", VA = "0x10368320")]
    public long GetRestTime(long serverTime) => new long();

    [Token(Token = "0x6006F0E")]
    [Address(RVA = "0x3683C0", Offset = "0x3671C0", VA = "0x103683C0")]
    public bool IsItem() => new bool();

    [Token(Token = "0x6006F0F")]
    [Address(RVA = "0x368420", Offset = "0x367220", VA = "0x10368420")]
    public bool IsZeny() => new bool();

    [Token(Token = "0x6006F10")]
    [Address(RVA = "0x368350", Offset = "0x367150", VA = "0x10368350")]
    public bool HasTimeLimit() => new bool();

    [Token(Token = "0x6006F11")]
    [Address(RVA = "0x3683D0", Offset = "0x3671D0", VA = "0x103683D0")]
    public bool IsValid(long nowSec) => new bool();

    [Token(Token = "0x6006F12")]
    [Address(RVA = "0x368380", Offset = "0x367180", VA = "0x10368380")]
    public bool IsDefault() => new bool();

    [Token(Token = "0x6006F13")]
    [Address(RVA = "0x368070", Offset = "0x366E70", VA = "0x10368070")]
    public void Deserialize(JSON_FriendPresentItemParam json)
    {
    }

    [Token(Token = "0x6006F14")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public FriendPresentItemParam()
    {
    }
  }
}
