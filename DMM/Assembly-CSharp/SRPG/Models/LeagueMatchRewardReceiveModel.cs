// Decompiled with JetBrains decompiler
// Type: SRPG.Models.LeagueMatchRewardReceiveModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003369")]
  public class LeagueMatchRewardReceiveModel
  {
    [Token(Token = "0x400F2EA")]
    [FieldOffset(Offset = "0x8")]
    private ReqLeagueMatchReward.Response _response;
    [Token(Token = "0x400F2EB")]
    [FieldOffset(Offset = "0xC")]
    private DuelRewardIconTemplate _iconTemplate;
    [Token(Token = "0x400F2EC")]
    [FieldOffset(Offset = "0x10")]
    private string _rankIconKey;
    [Token(Token = "0x400F2ED")]
    [FieldOffset(Offset = "0x14")]
    private string _rankNameKey;

    [Token(Token = "0x17001F03")]
    public DuelRewardIconTemplate IconTemplate
    {
      [Token(Token = "0x600E401"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (DuelRewardIconTemplate) null;
      }
    }

    [Token(Token = "0x17001F04")]
    public ReqLeagueMatchReward.Response RewardData
    {
      [Token(Token = "0x600E402"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (ReqLeagueMatchReward.Response) null;
      }
    }

    [Token(Token = "0x17001F05")]
    public string RankIconKey
    {
      [Token(Token = "0x600E403"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F06")]
    public string RankNameKey
    {
      [Token(Token = "0x600E404"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600E405")]
    [Address(RVA = "0xAB8F40", Offset = "0xAB7D40", VA = "0x10AB8F40")]
    public void Initialize(SerializeValueList _valueList, DuelRewardIconTemplate iconTemplate)
    {
    }

    [Token(Token = "0x600E406")]
    [Address(RVA = "0xAB8E00", Offset = "0xAB7C00", VA = "0x10AB8E00")]
    private void InitializeData()
    {
    }

    [Token(Token = "0x600E407")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public LeagueMatchRewardReceiveModel()
    {
    }
  }
}
