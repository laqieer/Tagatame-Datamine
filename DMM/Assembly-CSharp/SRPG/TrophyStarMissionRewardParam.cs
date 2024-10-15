// Decompiled with JetBrains decompiler
// Type: SRPG.TrophyStarMissionRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001DA7")]
  public class TrophyStarMissionRewardParam
  {
    [Token(Token = "0x400761C")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x400761D")]
    [FieldOffset(Offset = "0xC")]
    private TrophyStarMissionRewardParam.Data[] mRewards;

    [Token(Token = "0x17001055")]
    public string Iname
    {
      [Token(Token = "0x6007954"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001056")]
    public List<TrophyStarMissionRewardParam.Data> RewardList
    {
      [Token(Token = "0x6007955"), Address(RVA = "0x3B10E0", Offset = "0x3AFEE0", VA = "0x103B10E0")] get
      {
        return (List<TrophyStarMissionRewardParam.Data>) null;
      }
    }

    [Token(Token = "0x6007956")]
    [Address(RVA = "0x3B0D90", Offset = "0x3AFB90", VA = "0x103B0D90")]
    public void Deserialize(JSON_TrophyStarMissionRewardParam json)
    {
    }

    [Token(Token = "0x6007957")]
    [Address(RVA = "0x3B0C20", Offset = "0x3AFA20", VA = "0x103B0C20")]
    public static void Deserialize(
      JSON_TrophyStarMissionRewardParam[] json,
      ref Dictionary<string, TrophyStarMissionRewardParam> dict)
    {
    }

    [Token(Token = "0x6007958")]
    [Address(RVA = "0x3B0F10", Offset = "0x3AFD10", VA = "0x103B0F10")]
    public static TrophyStarMissionRewardParam GetParam(string key)
    {
      return (TrophyStarMissionRewardParam) null;
    }

    [Token(Token = "0x6007959")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public TrophyStarMissionRewardParam()
    {
    }

    [Token(Token = "0x2001DA8")]
    public class Data
    {
      [Token(Token = "0x400761E")]
      [FieldOffset(Offset = "0x8")]
      public int ItemType;
      [Token(Token = "0x400761F")]
      [FieldOffset(Offset = "0xC")]
      public string ItemIname;
      [Token(Token = "0x4007620")]
      [FieldOffset(Offset = "0x10")]
      public int ItemNum;

      [Token(Token = "0x600795A")]
      [Address(RVA = "0x31AF60", Offset = "0x319D60", VA = "0x1031AF60")]
      public void Deserialize(JSON_TrophyStarMissionRewardParam.Data json)
      {
      }

      [Token(Token = "0x600795B")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Data()
      {
      }
    }
  }
}
