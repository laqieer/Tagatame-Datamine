// Decompiled with JetBrains decompiler
// Type: SRPG.Models.MasteryRewardGroupModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x200336E")]
  public class MasteryRewardGroupModel
  {
    [Token(Token = "0x400F309")]
    [FieldOffset(Offset = "0x8")]
    private MasteryRewardData mRewardData;
    [Token(Token = "0x400F30A")]
    [FieldOffset(Offset = "0xC")]
    private string mAchieveNumText;
    [Token(Token = "0x400F30B")]
    [FieldOffset(Offset = "0x10")]
    private string mEmblemPath;
    [Token(Token = "0x400F30C")]
    [FieldOffset(Offset = "0x14")]
    private bool mAchievement;
    [Token(Token = "0x400F30D")]
    [FieldOffset(Offset = "0x15")]
    private bool mReceived;

    [Token(Token = "0x17001F2E")]
    public MasteryRewardParam RewardData
    {
      [Token(Token = "0x600E442"), Address(RVA = "0xAA87D0", Offset = "0xAA75D0", VA = "0x10AA87D0")] get
      {
        return (MasteryRewardParam) null;
      }
    }

    [Token(Token = "0x17001F2F")]
    public string AchieveNumText
    {
      [Token(Token = "0x600E443"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F30")]
    public string EmblemPath
    {
      [Token(Token = "0x600E444"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F31")]
    public bool Achievement
    {
      [Token(Token = "0x600E445"), Address(RVA = "0x2CE1E0", Offset = "0x2CCFE0", VA = "0x102CE1E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001F32")]
    public bool Received
    {
      [Token(Token = "0x600E446"), Address(RVA = "0x39C2B0", Offset = "0x39B0B0", VA = "0x1039C2B0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E447")]
    [Address(RVA = "0xABAB70", Offset = "0xAB9970", VA = "0x10ABAB70")]
    private string GetEmblemPath() => (string) null;

    [Token(Token = "0x600E448")]
    [Address(RVA = "0xABAC90", Offset = "0xAB9A90", VA = "0x10ABAC90")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600E449")]
    [Address(RVA = "0xABAD00", Offset = "0xAB9B00", VA = "0x10ABAD00")]
    public void Setup(MasteryRewardData rewardData)
    {
    }

    [Token(Token = "0x600E44A")]
    [Address(RVA = "0xABAE90", Offset = "0xAB9C90", VA = "0x10ABAE90")]
    public MasteryRewardGroupModel()
    {
    }
  }
}
