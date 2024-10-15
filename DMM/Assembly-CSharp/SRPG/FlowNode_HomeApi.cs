// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_HomeApi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001403")]
  [FlowNode.Pin(21, "Failed", FlowNode.PinTypes.Output, 21)]
  [FlowNode.Pin(20, "Success", FlowNode.PinTypes.Output, 20)]
  [FlowNode.Pin(100, "Start", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("System/HomeApi", 32741)]
  [AddComponentMenu("")]
  public class FlowNode_HomeApi : FlowNode_Network
  {
    [Token(Token = "0x60053B5")]
    [Address(RVA = "0x1283CB0", Offset = "0x1282AB0", VA = "0x11283CB0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60053B6")]
    [Address(RVA = "0x12824D0", Offset = "0x12812D0", VA = "0x112824D0")]
    private void _Success()
    {
    }

    [Token(Token = "0x60053B7")]
    [Address(RVA = "0x1284CB0", Offset = "0x1283AB0", VA = "0x11284CB0")]
    private void _Failed()
    {
    }

    [Token(Token = "0x60053B8")]
    [Address(RVA = "0x12841E0", Offset = "0x1282FE0", VA = "0x112841E0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60053B9")]
    [Address(RVA = "0x1283780", Offset = "0x1282580", VA = "0x11283780")]
    private void NotifyMasteryReward(int master_unit_num)
    {
    }

    [Token(Token = "0x60053BA")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_HomeApi()
    {
    }

    [Token(Token = "0x2001404")]
    public class JSON_HomeApiResponse
    {
      [Token(Token = "0x4004A12")]
      [FieldOffset(Offset = "0x8")]
      public FlowNode_HomeApi.JSON_HomeApiResponse.Player player;
      [Token(Token = "0x4004A13")]
      [FieldOffset(Offset = "0xC")]
      public LoginNewsInfo.JSON_PubInfo pubinfo;
      [Token(Token = "0x4004A14")]
      [FieldOffset(Offset = "0x10")]
      public JSON_PlayerCoinBuyUseBonusState[] bonus_stats;
      [Token(Token = "0x4004A15")]
      [FieldOffset(Offset = "0x14")]
      public JSON_PlayerCoinBuyUseBonusRewardState[] bonus_rewards;
      [Token(Token = "0x4004A16")]
      [FieldOffset(Offset = "0x18")]
      public Json_AutoRepeatQuestData auto_repeat;
      [Token(Token = "0x4004A17")]
      [FieldOffset(Offset = "0x1C")]
      public JSON_PartyOverWrite[] party_decks;
      [Token(Token = "0x4004A18")]
      [FieldOffset(Offset = "0x20")]
      public int gvg_rate;
      [Token(Token = "0x4004A19")]
      [FieldOffset(Offset = "0x24")]
      public int gvg_league_disp;
      [Token(Token = "0x4004A1A")]
      [FieldOffset(Offset = "0x28")]
      public int worldraid_last_boss_status;
      [Token(Token = "0x4004A1B")]
      [FieldOffset(Offset = "0x2C")]
      public Json_HotDealInfo[] hot_deals;
      [Token(Token = "0x4004A1C")]
      [FieldOffset(Offset = "0x30")]
      public int adventure_status;
      [Token(Token = "0x4004A1D")]
      [FieldOffset(Offset = "0x34")]
      public int is_guild_master_delegated;
      [Token(Token = "0x4004A1E")]
      [FieldOffset(Offset = "0x38")]
      public int is_new_pubinfo;
      [Token(Token = "0x4004A1F")]
      [FieldOffset(Offset = "0x3C")]
      public int mastery_rank;
      [Token(Token = "0x4004A20")]
      [FieldOffset(Offset = "0x40")]
      public int is_mastery_not_rewarded;
      [Token(Token = "0x4004A21")]
      [FieldOffset(Offset = "0x44")]
      public int is_worldraid_reward;
      [Token(Token = "0x4004A22")]
      [FieldOffset(Offset = "0x48")]
      public int door_master_unit_num;
      [Token(Token = "0x4004A23")]
      [FieldOffset(Offset = "0x4C")]
      public int is_pending;
      [Token(Token = "0x4004A24")]
      [FieldOffset(Offset = "0x50")]
      public int is_leaguematch_not_complete;
      [Token(Token = "0x4004A25")]
      [FieldOffset(Offset = "0x54")]
      public int leaguematch_matching_period;
      [Token(Token = "0x4004A26")]
      [FieldOffset(Offset = "0x58")]
      public JSON_ArtifactStoneEffectHomeParam stone_on_hold;

      [Token(Token = "0x60053BB")]
      [Address(RVA = "0x1289250", Offset = "0x1288050", VA = "0x11289250")]
      public JSON_HomeApiResponse()
      {
      }

      [Token(Token = "0x2001405")]
      public class Player
      {
        [Token(Token = "0x4004A27")]
        [FieldOffset(Offset = "0x8")]
        public int areamail_enabled;
        [Token(Token = "0x4004A28")]
        [FieldOffset(Offset = "0xC")]
        public int present_granted;
        [Token(Token = "0x4004A29")]
        [FieldOffset(Offset = "0x10")]
        public int multi_inv;
        [Token(Token = "0x4004A2A")]
        [FieldOffset(Offset = "0x14")]
        public int charge_bonus;
        [Token(Token = "0x4004A2B")]
        [FieldOffset(Offset = "0x18")]
        public int colo_reward;
        [Token(Token = "0x4004A2C")]
        [FieldOffset(Offset = "0x1C")]
        public int duel_reward;
        [Token(Token = "0x4004A2D")]
        [FieldOffset(Offset = "0x20")]
        public int applied_member_num;
        [Token(Token = "0x4004A2E")]
        [FieldOffset(Offset = "0x24")]
        public int drawcard_enabled;
        [Token(Token = "0x4004A2F")]
        [FieldOffset(Offset = "0x28")]
        public int gvg_reward;
        [Token(Token = "0x4004A30")]
        [FieldOffset(Offset = "0x2C")]
        public int guild_role_reward_status;

        [Token(Token = "0x60053BC")]
        [Address(RVA = "0x1289270", Offset = "0x1288070", VA = "0x11289270")]
        public Player()
        {
        }
      }
    }
  }
}
