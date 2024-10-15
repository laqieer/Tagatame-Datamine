// Decompiled with JetBrains decompiler
// Type: SRPG.GuildEmblemParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B3B")]
  [MessagePackObject(true)]
  [Serializable]
  public class GuildEmblemParam
  {
    [Token(Token = "0x40067BB")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x40067BC")]
    [FieldOffset(Offset = "0xC")]
    private string mName;
    [Token(Token = "0x40067BD")]
    [FieldOffset(Offset = "0x10")]
    private int mConditionsType;
    [Token(Token = "0x40067BE")]
    [FieldOffset(Offset = "0x14")]
    private int mConditionsValue;
    [Token(Token = "0x40067BF")]
    [FieldOffset(Offset = "0x18")]
    private string mImage;
    [Token(Token = "0x40067C0")]
    [FieldOffset(Offset = "0x20")]
    private DateTime mStartAt;
    [Token(Token = "0x40067C1")]
    [FieldOffset(Offset = "0x28")]
    private DateTime mEndAt;

    [Token(Token = "0x17000D35")]
    public string Iname
    {
      [Token(Token = "0x6007037"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000D36")]
    public string Name
    {
      [Token(Token = "0x6007038"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000D37")]
    public int ConditionsType
    {
      [Token(Token = "0x6007039"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000D38")]
    public int ConditionsValue
    {
      [Token(Token = "0x600703A"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000D39")]
    public string Image
    {
      [Token(Token = "0x600703B"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000D3A")]
    public DateTime StartAt
    {
      [Token(Token = "0x600703C"), Address(RVA = "0x31F940", Offset = "0x31E740", VA = "0x1031F940")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17000D3B")]
    public DateTime EndAt
    {
      [Token(Token = "0x600703D"), Address(RVA = "0x31F950", Offset = "0x31E750", VA = "0x1031F950")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x600703E")]
    [Address(RVA = "0x36EB30", Offset = "0x36D930", VA = "0x1036EB30")]
    public void Deserialize(JSON_GuildEmblemParam json)
    {
    }

    [Token(Token = "0x600703F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GuildEmblemParam()
    {
    }
  }
}
