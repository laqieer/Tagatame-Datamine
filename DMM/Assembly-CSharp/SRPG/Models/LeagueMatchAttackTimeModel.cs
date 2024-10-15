// Decompiled with JetBrains decompiler
// Type: SRPG.Models.LeagueMatchAttackTimeModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003351")]
  public class LeagueMatchAttackTimeModel
  {
    [Token(Token = "0x400F22E")]
    [FieldOffset(Offset = "0x8")]
    private string _nextMessage;
    [Token(Token = "0x400F22F")]
    [FieldOffset(Offset = "0xC")]
    private string _afterNextMessage;
    [Token(Token = "0x400F230")]
    [FieldOffset(Offset = "0x10")]
    private bool _isNextActive;
    [Token(Token = "0x400F231")]
    [FieldOffset(Offset = "0x11")]
    private bool _isAfterNextActive;

    [Token(Token = "0x17001E7A")]
    public string NextMessage
    {
      [Token(Token = "0x600E317"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001E7B")]
    public string AfterNextMessage
    {
      [Token(Token = "0x600E318"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001E7C")]
    public bool IsNextActive
    {
      [Token(Token = "0x600E319"), Address(RVA = "0x2B0B70", Offset = "0x2AF970", VA = "0x102B0B70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001E7D")]
    public bool IsAfterNextActive
    {
      [Token(Token = "0x600E31A"), Address(RVA = "0x3E6E30", Offset = "0x3E5C30", VA = "0x103E6E30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E31B")]
    [Address(RVA = "0xAB26F0", Offset = "0xAB14F0", VA = "0x10AB26F0")]
    public void Initialize(int seasonID)
    {
    }

    [Token(Token = "0x600E31C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public LeagueMatchAttackTimeModel()
    {
    }
  }
}
