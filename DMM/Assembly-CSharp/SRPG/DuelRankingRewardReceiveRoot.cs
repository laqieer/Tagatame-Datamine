// Decompiled with JetBrains decompiler
// Type: SRPG.DuelRankingRewardReceiveRoot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002326")]
  [FlowNode.Pin(140, "シーズン報酬なし", FlowNode.PinTypes.Output, 140)]
  [FlowNode.Pin(10, "デイリー報酬チェック", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(20, "シーズン報酬チェック", FlowNode.PinTypes.Input, 20)]
  [FlowNode.Pin(110, "デイリー報酬あり", FlowNode.PinTypes.Output, 110)]
  [FlowNode.Pin(120, "シーズン報酬あり", FlowNode.PinTypes.Output, 120)]
  [FlowNode.Pin(130, "デイリー報酬なし", FlowNode.PinTypes.Output, 130)]
  [AddComponentMenu("UI/Duel/DuelRankingRewardReceiveRoot")]
  public class DuelRankingRewardReceiveRoot : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4009CFA")]
    private const int PIN_INPUT_CHECK_DAILY_REWARD = 10;
    [Token(Token = "0x4009CFB")]
    private const int PIN_INPUT_CHECK_SEASON_REWARD = 20;
    [Token(Token = "0x4009CFC")]
    private const int PIN_OUTPUT_DAILY_REWARD_YES = 110;
    [Token(Token = "0x4009CFD")]
    private const int PIN_OUTPUT_SEASON_REWARD_YES = 120;
    [Token(Token = "0x4009CFE")]
    private const int PIN_OUTPUT_DAILY_REWARD_NO = 130;
    [Token(Token = "0x4009CFF")]
    private const int PIN_OUTPUT_SEASON_REWARD_NO = 140;
    [Token(Token = "0x4009D00")]
    [FieldOffset(Offset = "0x0")]
    private static List<JSON_DuelDailyRankingRewardData> mDailyRankingRewards;
    [Token(Token = "0x4009D01")]
    [FieldOffset(Offset = "0x4")]
    private static List<JSON_DuelSeasonRankingRewardData> mSeasonRankingRewards;

    [Token(Token = "0x1700152F")]
    private static bool IsExist_DailyRankingReward
    {
      [Token(Token = "0x6009736"), Address(RVA = "0x59B7D0", Offset = "0x59A5D0", VA = "0x1059B7D0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001530")]
    private static bool IsExist_SeasonRankingReward
    {
      [Token(Token = "0x6009737"), Address(RVA = "0x59B990", Offset = "0x59A790", VA = "0x1059B990")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6009738")]
    [Address(RVA = "0x59B630", Offset = "0x59A430", VA = "0x1059B630")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6009739")]
    [Address(RVA = "0x59B460", Offset = "0x59A260", VA = "0x1059B460", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600973A")]
    [Address(RVA = "0x59B4B0", Offset = "0x59A2B0", VA = "0x1059B4B0")]
    private void CheckDailyReward()
    {
    }

    [Token(Token = "0x600973B")]
    [Address(RVA = "0x59B4E0", Offset = "0x59A2E0", VA = "0x1059B4E0")]
    private void CheckSeasonReward()
    {
    }

    [Token(Token = "0x600973C")]
    [Address(RVA = "0x59B690", Offset = "0x59A490", VA = "0x1059B690")]
    public static void SetReward(
      JSON_DuelDailyRankingRewardData daily_reward,
      JSON_DuelSeasonRankingRewardData season_rewards)
    {
    }

    [Token(Token = "0x600973D")]
    [Address(RVA = "0x59B510", Offset = "0x59A310", VA = "0x1059B510")]
    public static JSON_DuelDailyRankingRewardData GetAndRemove_DailyRankingReward()
    {
      return (JSON_DuelDailyRankingRewardData) null;
    }

    [Token(Token = "0x600973E")]
    [Address(RVA = "0x59B5A0", Offset = "0x59A3A0", VA = "0x1059B5A0")]
    public static JSON_DuelSeasonRankingRewardData GetAndRemove_SeasonRankingReward()
    {
      return (JSON_DuelSeasonRankingRewardData) null;
    }

    [Token(Token = "0x600973F")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public DuelRankingRewardReceiveRoot()
    {
    }
  }
}
