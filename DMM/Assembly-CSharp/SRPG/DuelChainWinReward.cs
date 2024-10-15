// Decompiled with JetBrains decompiler
// Type: SRPG.DuelChainWinReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001AC3")]
  public class DuelChainWinReward
  {
    [Token(Token = "0x400632F")]
    [FieldOffset(Offset = "0x8")]
    private int mChain;
    [Token(Token = "0x4006330")]
    [FieldOffset(Offset = "0xC")]
    private string mReward;

    [Token(Token = "0x17000C6D")]
    public int Chain
    {
      [Token(Token = "0x6006E51"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C6E")]
    public string Reward
    {
      [Token(Token = "0x6006E52"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6006E53")]
    [Address(RVA = "0x35F6F0", Offset = "0x35E4F0", VA = "0x1035F6F0")]
    public bool Deserialize(JSON_DuelChainWinReward json) => new bool();

    [Token(Token = "0x6006E54")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public DuelChainWinReward()
    {
    }
  }
}
