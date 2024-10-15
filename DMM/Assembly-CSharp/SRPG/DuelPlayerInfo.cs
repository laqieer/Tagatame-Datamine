// Decompiled with JetBrains decompiler
// Type: SRPG.DuelPlayerInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002321")]
  [AddComponentMenu("UI/Duel/DuelPlayerInfo")]
  [FlowNode.Pin(100, "閉じる", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(10, "初期化", FlowNode.PinTypes.Input, 10)]
  public class DuelPlayerInfo : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4009CD3")]
    private const int PIN_INPUT_INIT = 10;
    [Token(Token = "0x4009CD4")]
    private const int PIN_OUTPUT_CLOSE = 100;
    [Token(Token = "0x4009CD5")]
    private const string DUEL_SVB_KEY_LEADER = "leader";
    [Token(Token = "0x4009CD6")]
    private const string DUEL_SVB_KEY_UNIT_BG = "unit_bg";
    [Token(Token = "0x4009CD7")]
    [FieldOffset(Offset = "0xC")]
    private readonly int LEADER_SKILL_IMAGE_ARRAY_INDEX_UNIT;
    [Token(Token = "0x4009CD8")]
    [FieldOffset(Offset = "0x10")]
    private readonly int LEADER_SKILL_IMAGE_ARRAY_INDEX_CARD;
    [Token(Token = "0x4009CD9")]
    [FieldOffset(Offset = "0x14")]
    private readonly int UNIT_BG_IMAGE_ARRAY_INDEX_LEADER;
    [Token(Token = "0x4009CDA")]
    [FieldOffset(Offset = "0x18")]
    private readonly int UNIT_BG_IMAGE_ARRAY_INDEX_NOT_LEADER;
    [Token(Token = "0x4009CDB")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text mPlayerName;
    [Token(Token = "0x4009CDC")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mPlayerRankingRoot;
    [Token(Token = "0x4009CDD")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Text mPlayerRanking;
    [Token(Token = "0x4009CDE")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text mLeaderSkillName;
    [Token(Token = "0x4009CDF")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Text mLeaderSkillDesc;
    [Token(Token = "0x4009CE0")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject mUnitIconTemplate;
    [Token(Token = "0x4009CE1")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private ImageArray mLeaderSkillBg;
    [Token(Token = "0x4009CE2")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject mTitleEnemy;

    [Token(Token = "0x6009725")]
    [Address(RVA = "0x599C50", Offset = "0x598A50", VA = "0x10599C50", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009726")]
    [Address(RVA = "0x59A1D0", Offset = "0x598FD0", VA = "0x1059A1D0")]
    private void Init()
    {
    }

    [Token(Token = "0x6009727")]
    [Address(RVA = "0x599C70", Offset = "0x598A70", VA = "0x10599C70")]
    private void CreateUnitIcon()
    {
    }

    [Token(Token = "0x6009728")]
    [Address(RVA = "0x59A4F0", Offset = "0x5992F0", VA = "0x1059A4F0")]
    private void SetupConceptCard(GameObject obj, ConceptCardData card_data)
    {
    }

    [Token(Token = "0x6009729")]
    [Address(RVA = "0x59A580", Offset = "0x599380", VA = "0x1059A580")]
    public DuelPlayerInfo()
    {
    }
  }
}
