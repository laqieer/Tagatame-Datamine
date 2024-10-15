// Decompiled with JetBrains decompiler
// Type: SRPG.ScoreChallengeParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C19")]
  public class ScoreChallengeParam
  {
    [Token(Token = "0x4006CD4")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x4006CD5")]
    [FieldOffset(Offset = "0xC")]
    private bool mIsValid;
    [Token(Token = "0x4006CD6")]
    [FieldOffset(Offset = "0x10")]
    private DateTime mExitAt;
    [Token(Token = "0x4006CD7")]
    [FieldOffset(Offset = "0x18")]
    private bool mIsPortTopRankingHidden;

    [Token(Token = "0x17000E82")]
    public string Iname
    {
      [Token(Token = "0x60073BE"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E83")]
    public bool IsValid
    {
      [Token(Token = "0x60073BF"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000E84")]
    public DateTime ExitAt
    {
      [Token(Token = "0x60073C0"), Address(RVA = "0x31CBE0", Offset = "0x31B9E0", VA = "0x1031CBE0")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17000E85")]
    public bool IsPortTopRankingHidden
    {
      [Token(Token = "0x60073C1"), Address(RVA = "0x3057E0", Offset = "0x3045E0", VA = "0x103057E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60073C2")]
    [Address(RVA = "0x38E7B0", Offset = "0x38D5B0", VA = "0x1038E7B0")]
    public void Deserialize(JSON_ScoreChallengeParam json)
    {
    }

    [Token(Token = "0x60073C3")]
    [Address(RVA = "0x38E890", Offset = "0x38D690", VA = "0x1038E890")]
    public static void Deserialize(
      ref ParamDictionary<string, ScoreChallengeParam> ref_params,
      JSON_ScoreChallengeParam[] jsons)
    {
    }

    [Token(Token = "0x60073C4")]
    [Address(RVA = "0x38EB60", Offset = "0x38D960", VA = "0x1038EB60")]
    public static ScoreChallengeParam GetScoreChallengeParamFromId(string area_id)
    {
      return (ScoreChallengeParam) null;
    }

    [Token(Token = "0x60073C5")]
    [Address(RVA = "0x38EAA0", Offset = "0x38D8A0", VA = "0x1038EAA0")]
    public static DateTime GetExitAtFromId(string area_id) => new DateTime();

    [Token(Token = "0x60073C6")]
    [Address(RVA = "0x38EDC0", Offset = "0x38DBC0", VA = "0x1038EDC0")]
    public static bool IsRankingPeriodFromChapter(ChapterParam chapter) => new bool();

    [Token(Token = "0x60073C7")]
    [Address(RVA = "0x38EC50", Offset = "0x38DA50", VA = "0x1038EC50")]
    public static bool IsOpenScoreChallengeFromChapter(ChapterParam chapter) => new bool();

    [Token(Token = "0x60073C8")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ScoreChallengeParam()
    {
    }
  }
}
