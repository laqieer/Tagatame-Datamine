// Decompiled with JetBrains decompiler
// Type: SRPG.MasteryRewardData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BE7")]
  public class MasteryRewardData
  {
    [Token(Token = "0x4006BE5")]
    [FieldOffset(Offset = "0x8")]
    private MasteryRewardParam mParam;
    [Token(Token = "0x4006BE6")]
    [FieldOffset(Offset = "0xC")]
    private RewardStatus mStatus;

    [Token(Token = "0x17000E46")]
    public MasteryRewardParam Param
    {
      [Token(Token = "0x6007319"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (MasteryRewardParam) null;
      }
    }

    [Token(Token = "0x17000E47")]
    public RewardStatus Status
    {
      [Token(Token = "0x600731A"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new RewardStatus();
      }
    }

    [Token(Token = "0x600731B")]
    [Address(RVA = "0x37BC60", Offset = "0x37AA60", VA = "0x1037BC60")]
    public void Setup(MasteryRewardParam param, RewardStatus status)
    {
    }

    [Token(Token = "0x600731C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public MasteryRewardData()
    {
    }
  }
}
