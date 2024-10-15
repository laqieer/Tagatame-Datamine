// Decompiled with JetBrains decompiler
// Type: SRPG.DuelRewardIconTemplate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002338")]
  [AddComponentMenu("UI/Duel/DuelRewardIconTemplate")]
  public class DuelRewardIconTemplate : MonoBehaviour
  {
    [Token(Token = "0x4009D97")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mTemplate_Unit;
    [Token(Token = "0x4009D98")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mTemplate_Item;
    [Token(Token = "0x4009D99")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mTemplate_Card;
    [Token(Token = "0x4009D9A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mTemplate_Artifact;
    [Token(Token = "0x4009D9B")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject mTemplate_Award;
    [Token(Token = "0x4009D9C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mTemplate_Gold;
    [Token(Token = "0x4009D9D")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject mTemplate_Coin;
    [Token(Token = "0x4009D9E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject mTemplate_EventCoin;
    [Token(Token = "0x4009D9F")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GameObject mTemplate_Bonus;
    [Token(Token = "0x4009DA0")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject mTemplate_Win;
    [Token(Token = "0x4009DA1")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject mTemplate_OpenEffect;
    [Token(Token = "0x4009DA2")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject mTemplate_TotalBonus;

    [Token(Token = "0x60097A0")]
    [Address(RVA = "0x5A0F40", Offset = "0x59FD40", VA = "0x105A0F40")]
    private void Awake()
    {
    }

    [Token(Token = "0x60097A1")]
    [Address(RVA = "0x5A1190", Offset = "0x59FF90", VA = "0x105A1190")]
    public GameObject CreateInstance(
      RaidRewardType reward_type,
      string reward_iname,
      Transform parent,
      bool is_bonus_reward = false,
      DUEL_WIN_BONUS_TYPE type = DUEL_WIN_BONUS_TYPE.ChainWin,
      bool is_win = false,
      bool is_btl_result = false)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x60097A2")]
    [Address(RVA = "0x5A1020", Offset = "0x59FE20", VA = "0x105A1020")]
    public GameObject CreateInstance(
      RewardIcon.eType reward_type,
      string reward_iname,
      Transform parent,
      bool is_win)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x60097A3")]
    [Address(RVA = "0x5A1310", Offset = "0x5A0110", VA = "0x105A1310")]
    private GameObject Create(
      GameObject template,
      Transform parent,
      bool is_bonus_reward,
      DUEL_WIN_BONUS_TYPE type,
      bool is_win,
      bool is_btl_result)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x60097A4")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public DuelRewardIconTemplate()
    {
    }
  }
}
