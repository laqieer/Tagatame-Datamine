// Decompiled with JetBrains decompiler
// Type: SRPG.CombatPowerQuestListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20021AF")]
  [AddComponentMenu("UI/CombatPowerQuestListItem")]
  public class CombatPowerQuestListItem : MonoBehaviour
  {
    [Token(Token = "0x4009386")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject QuestCampaignItem;
    [Token(Token = "0x4009387")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject QuestState;
    [Token(Token = "0x4009388")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject QuestLimitGroup;
    [Token(Token = "0x4009389")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject LockObj;
    [Token(Token = "0x400938A")]
    [FieldOffset(Offset = "0x1C")]
    private GameObject mGoQuestCampaignItem;
    [Token(Token = "0x400938B")]
    [FieldOffset(Offset = "0x20")]
    private QuestParam mQuestParam;
    [Token(Token = "0x400938C")]
    [FieldOffset(Offset = "0x24")]
    private QuestCampaignList mQuestCampaignList;

    [Token(Token = "0x17001403")]
    public QuestCampaignList GetQuestCampaignList
    {
      [Token(Token = "0x6008DD2"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (QuestCampaignList) null;
      }
    }

    [Token(Token = "0x6008DD3")]
    [Address(RVA = "0x512DC0", Offset = "0x511BC0", VA = "0x10512DC0")]
    private void Start()
    {
    }

    [Token(Token = "0x6008DD4")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CombatPowerQuestListItem()
    {
    }
  }
}
