// Decompiled with JetBrains decompiler
// Type: SRPG.PointQuestRewardStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002820")]
  public class PointQuestRewardStatus
  {
    [Token(Token = "0x400BF3D")]
    [FieldOffset(Offset = "0x8")]
    public string Iname;
    [Token(Token = "0x400BF3E")]
    [FieldOffset(Offset = "0xC")]
    public RewardStatus Status;

    [Token(Token = "0x600B513")]
    [Address(RVA = "0x372170", Offset = "0x370F70", VA = "0x10372170")]
    public bool Deserialize(JSON_PointQuestRewardStatusData json) => new bool();

    [Token(Token = "0x600B514")]
    [Address(RVA = "0x7C1EC0", Offset = "0x7C0CC0", VA = "0x107C1EC0")]
    public bool IsAchievement() => new bool();

    [Token(Token = "0x600B515")]
    [Address(RVA = "0x7C1ED0", Offset = "0x7C0CD0", VA = "0x107C1ED0")]
    public bool IsReceived() => new bool();

    [Token(Token = "0x600B516")]
    [Address(RVA = "0x7C1EE0", Offset = "0x7C0CE0", VA = "0x107C1EE0")]
    public void Reassessment(
      PointQuestTotalRewardData data,
      int mTotalPoint,
      bool mIsGuildContribution)
    {
    }

    [Token(Token = "0x600B517")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public PointQuestRewardStatus()
    {
    }
  }
}
