// Decompiled with JetBrains decompiler
// Type: SRPG.RaidAreaClearRewardDataParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C62")]
  public class RaidAreaClearRewardDataParam
  {
    [Token(Token = "0x4006F88")]
    [FieldOffset(Offset = "0x8")]
    private int mRound;
    [Token(Token = "0x4006F89")]
    [FieldOffset(Offset = "0xC")]
    private string mRewardId;

    [Token(Token = "0x17000EF4")]
    public int Round
    {
      [Token(Token = "0x6007529"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000EF5")]
    public string RewardId
    {
      [Token(Token = "0x600752A"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600752B")]
    [Address(RVA = "0x35F6F0", Offset = "0x35E4F0", VA = "0x1035F6F0")]
    public bool Deserialize(JSON_RaidAreaClearRewardDataParam json) => new bool();

    [Token(Token = "0x600752C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RaidAreaClearRewardDataParam()
    {
    }
  }
}
