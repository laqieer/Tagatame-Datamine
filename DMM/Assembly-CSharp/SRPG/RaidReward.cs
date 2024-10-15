// Decompiled with JetBrains decompiler
// Type: SRPG.RaidReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C88")]
  public class RaidReward
  {
    [Token(Token = "0x4007015")]
    [FieldOffset(Offset = "0x8")]
    private RaidRewardType mType;
    [Token(Token = "0x4007016")]
    [FieldOffset(Offset = "0xC")]
    private string mIName;
    [Token(Token = "0x4007017")]
    [FieldOffset(Offset = "0x10")]
    private int mNum;

    [Token(Token = "0x17000F36")]
    public RaidRewardType Type
    {
      [Token(Token = "0x60075A4"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new RaidRewardType();
      }
    }

    [Token(Token = "0x17000F37")]
    public string IName
    {
      [Token(Token = "0x60075A5"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000F38")]
    public int Num
    {
      [Token(Token = "0x60075A6"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60075A7")]
    [Address(RVA = "0x3569E0", Offset = "0x3557E0", VA = "0x103569E0")]
    public bool Deserialize(JSON_RaidReward json) => new bool();

    [Token(Token = "0x60075A8")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RaidReward()
    {
    }
  }
}
