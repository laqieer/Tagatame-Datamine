// Decompiled with JetBrains decompiler
// Type: SRPG.FirstChargeReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200214B")]
  public class FirstChargeReward
  {
    [Token(Token = "0x40090F8")]
    [FieldOffset(Offset = "0x8")]
    private string m_Iname;
    [Token(Token = "0x40090F9")]
    [FieldOffset(Offset = "0x10")]
    private long m_Type;
    [Token(Token = "0x40090FA")]
    [FieldOffset(Offset = "0x18")]
    private int m_Num;

    [Token(Token = "0x170013BA")]
    public string iname
    {
      [Token(Token = "0x6008BBC"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170013BB")]
    public long type
    {
      [Token(Token = "0x6008BBD"), Address(RVA = "0x361230", Offset = "0x360030", VA = "0x10361230")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x170013BC")]
    public int num
    {
      [Token(Token = "0x6008BBE"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6008BBF")]
    [Address(RVA = "0x50A0F0", Offset = "0x508EF0", VA = "0x1050A0F0")]
    public FirstChargeReward()
    {
    }

    [Token(Token = "0x6008BC0")]
    [Address(RVA = "0x50A170", Offset = "0x508F70", VA = "0x1050A170")]
    public FirstChargeReward(string _iname, GiftTypes _type, int _num)
    {
    }

    [Token(Token = "0x6008BC1")]
    [Address(RVA = "0x50A070", Offset = "0x508E70", VA = "0x1050A070")]
    public FirstChargeReward(FlowNode_ReqFirstChargeBonus.Reward _reward)
    {
    }

    [Token(Token = "0x6008BC2")]
    [Address(RVA = "0x50A020", Offset = "0x508E20", VA = "0x1050A020")]
    public bool CheckGiftTypes(GiftTypes flag) => new bool();

    [Token(Token = "0x6008BC3")]
    [Address(RVA = "0x50A050", Offset = "0x508E50", VA = "0x1050A050")]
    public void SetGiftTypes(GiftTypes flag)
    {
    }
  }
}
