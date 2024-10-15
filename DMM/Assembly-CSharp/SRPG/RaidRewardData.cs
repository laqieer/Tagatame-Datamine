// Decompiled with JetBrains decompiler
// Type: SRPG.RaidRewardData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20010E0")]
  public class RaidRewardData
  {
    [Token(Token = "0x4003CF7")]
    [FieldOffset(Offset = "0x8")]
    private RaidRewardKind mKind;
    [Token(Token = "0x4003CF8")]
    [FieldOffset(Offset = "0xC")]
    private GiftData[] mRewards;

    [Token(Token = "0x1700072B")]
    public RaidRewardKind Kind
    {
      [Token(Token = "0x6004754"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new RaidRewardKind();
      }
    }

    [Token(Token = "0x1700072C")]
    public GiftData[] Rewards
    {
      [Token(Token = "0x6004755"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (GiftData[]) null;
      }
    }

    [Token(Token = "0x6004756")]
    [Address(RVA = "0x11E8E60", Offset = "0x11E7C60", VA = "0x111E8E60")]
    public bool Deserialize(RaidRewardKind kind, Json_Gift[] json_gifts) => new bool();

    [Token(Token = "0x6004757")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RaidRewardData()
    {
    }
  }
}
