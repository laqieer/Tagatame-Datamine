// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRoleBonusRewardInfoListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200252C")]
  [AddComponentMenu("UI/Guild/GuildRoleBonusRewardInfoListItem")]
  public class GuildRoleBonusRewardInfoListItem : MonoBehaviour
  {
    [Token(Token = "0x400AA32")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    [Header("報酬条件施設レベルテキスト")]
    private Text CondtionsText;
    [Token(Token = "0x400AA33")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    [Header("報酬アイコンの親")]
    private Transform ListItemRoot;
    [Token(Token = "0x400AA34")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    [Header("報酬アイコン")]
    private GameObject ListItemTemplate;

    [Token(Token = "0x600A3B1")]
    [Address(RVA = "0x65C740", Offset = "0x65B540", VA = "0x1065C740")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A3B2")]
    [Address(RVA = "0x65CD20", Offset = "0x65BB20", VA = "0x1065CD20")]
    public void Setup(int facility_lv, GuildRoleBonusRewardParam param)
    {
    }

    [Token(Token = "0x600A3B3")]
    [Address(RVA = "0x65C790", Offset = "0x65B590", VA = "0x1065C790")]
    private void Refresh(int facility_lv, GuildRoleBonusRewardParam param)
    {
    }

    [Token(Token = "0x600A3B4")]
    [Address(RVA = "0x65C9B0", Offset = "0x65B7B0", VA = "0x1065C9B0")]
    private void SetRewardIcon(GuildRoleBonusReward reward, RewardListItem listitem)
    {
    }

    [Token(Token = "0x600A3B5")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GuildRoleBonusRewardInfoListItem()
    {
    }
  }
}
