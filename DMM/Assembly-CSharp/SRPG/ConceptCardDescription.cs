// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardDescription
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20021DE")]
  [FlowNode.Pin(1, "変更前のスキルを表示", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "変更前のスキルを非表示", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(11, "リーダースキル詳細表示", FlowNode.PinTypes.Input, 11)]
  [AddComponentMenu("UI/ConceptCardDescription")]
  public class ConceptCardDescription : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x40094AE")]
    public const int INPUT_ENABLE_BASE_SKILL = 1;
    [Token(Token = "0x40094AF")]
    public const int INPUT_DIABLE_BASE_SKILL = 2;
    [Token(Token = "0x40094B0")]
    public const int INPUT_OPEN_LEADER_SKILL_DETAIL = 11;
    [Token(Token = "0x40094B1")]
    private const string SVB_OBJ_ENHANCEMENT = "enhancement";
    [Token(Token = "0x40094B2")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private string PREFAB_PATH_BONUS_WINDOW;
    [Token(Token = "0x40094B3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public ConceptCardDetailLevel Level;
    [Token(Token = "0x40094B4")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public ConceptCardDetailStatus Status;
    [Token(Token = "0x40094B5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public ConceptCardDetailSkin SkinPrefab;
    [Token(Token = "0x40094B6")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject AbilityTemplate;
    [Token(Token = "0x40094B7")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mCardAbilityDescriptionPrefab;
    [Token(Token = "0x40094B8")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private ConceptCardDetailGetUnit GetUnit;
    [Token(Token = "0x40094B9")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Selectable m_ShowBaseToggle;
    [Token(Token = "0x40094BA")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GameObject LeaderSkillInfo;
    [Token(Token = "0x40094BB")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject LeaderSkillLock;
    [Token(Token = "0x40094BC")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject Prefab_LeaderSkillDetail;
    [Token(Token = "0x40094BD")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private SRPG_Button LeaderSkillDetailButton;
    [Token(Token = "0x40094BE")]
    [FieldOffset(Offset = "0x3C")]
    private GameObject mAbilityDetailParent;
    [Token(Token = "0x40094BF")]
    [FieldOffset(Offset = "0x40")]
    private GameObject mCardAbilityDescription;
    [Token(Token = "0x40094C0")]
    [FieldOffset(Offset = "0x44")]
    private List<ConceptCardDetailSkin> Skin;
    [Token(Token = "0x40094C1")]
    [FieldOffset(Offset = "0x48")]
    private List<AbilityDeriveList> m_AbilityDeriveList;
    [Token(Token = "0x40094C2")]
    [FieldOffset(Offset = "0x4C")]
    private ConceptCardData mConceptCardData;
    [Token(Token = "0x40094C3")]
    [FieldOffset(Offset = "0x50")]
    private UnitData m_UnitData;
    [Token(Token = "0x40094C4")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private Button OpenBonusButton;
    [Token(Token = "0x40094C5")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject GroupIconsParent;
    [Token(Token = "0x40094C6")]
    [FieldOffset(Offset = "0x5C")]
    private GameObject mBonusWindow;
    [Token(Token = "0x40094C7")]
    [FieldOffset(Offset = "0x60")]
    private Canvas abilityCanvas;
    [Token(Token = "0x40094C8")]
    [FieldOffset(Offset = "0x64")]
    private Canvas bonusCanvas;
    [Token(Token = "0x40094C9")]
    [FieldOffset(Offset = "0x68")]
    private GameObject mLeaderSkillDetail;
    [Token(Token = "0x40094CA")]
    [FieldOffset(Offset = "0x0")]
    private static ConceptCardDescription _instance;
    [Token(Token = "0x40094CB")]
    [FieldOffset(Offset = "0x6C")]
    private bool mIsEnhance;
    [Token(Token = "0x40094CC")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private GameObject DecreaseEffectObject;
    [Token(Token = "0x40094CD")]
    [FieldOffset(Offset = "0x74")]
    [SerializeField]
    private Text DecreaseEffectText;
    [Token(Token = "0x40094CE")]
    [FieldOffset(Offset = "0x78")]
    private bool mEnableDecreaseEffectObject;
    [Token(Token = "0x40094CF")]
    [FieldOffset(Offset = "0x7C")]
    [SerializeField]
    private ConceptCardDetailExtraRarity ExtraRarity;
    [Token(Token = "0x40094D0")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private GameObject SubReflectionRateParent;
    [Token(Token = "0x40094D1")]
    [FieldOffset(Offset = "0x84")]
    [SerializeField]
    private Text SubReflectionRateText;
    [Token(Token = "0x40094D2")]
    [FieldOffset(Offset = "0x88")]
    private ConceptCardDescription.ConceptCardEnhanceInfo mEnhanceInfo;

    [Token(Token = "0x1700142C")]
    public static bool IsEnhance
    {
      [Token(Token = "0x6008EF6"), Address(RVA = "0x525A30", Offset = "0x524830", VA = "0x10525A30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700142D")]
    public static ConceptCardDescription.ConceptCardEnhanceInfo EnhanceInfo
    {
      [Token(Token = "0x6008EF7"), Address(RVA = "0x5259A0", Offset = "0x5247A0", VA = "0x105259A0")] get
      {
        return (ConceptCardDescription.ConceptCardEnhanceInfo) null;
      }
    }

    [Token(Token = "0x6008EF8")]
    [Address(RVA = "0x5236D0", Offset = "0x5224D0", VA = "0x105236D0")]
    private void Awake()
    {
    }

    [Token(Token = "0x6008EF9")]
    [Address(RVA = "0x523690", Offset = "0x522490", VA = "0x10523690", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008EFA")]
    [Address(RVA = "0x5257A0", Offset = "0x5245A0", VA = "0x105257A0")]
    private void SwitchBaseSkillEnable(bool enable)
    {
    }

    [Token(Token = "0x6008EFB")]
    [Address(RVA = "0x524950", Offset = "0x523750", VA = "0x10524950")]
    public void SetConceptCardData(
      ConceptCardData data,
      GameObject ability_detail_parent,
      bool bEnhance,
      bool is_first_get_unit = false,
      UnitData unitData = null,
      bool enableDecreaseEffectObject = false,
      bool isExtra = false)
    {
    }

    [Token(Token = "0x6008EFC")]
    [Address(RVA = "0x525740", Offset = "0x524540", VA = "0x10525740")]
    public void SetTextColor(Color _color)
    {
    }

    [Token(Token = "0x6008EFD")]
    [Address(RVA = "0x525340", Offset = "0x524140", VA = "0x10525340")]
    public void SetSubReflectionRateText(int addExp, int addAwakeLv)
    {
    }

    [Token(Token = "0x6008EFE")]
    [Address(RVA = "0x523D60", Offset = "0x522B60", VA = "0x10523D60")]
    private bool IsShowingEnhanceList() => new bool();

    [Token(Token = "0x6008EFF")]
    [Address(RVA = "0x524430", Offset = "0x523230", VA = "0x10524430")]
    private void OpenLeaderSkillDetail(SRPG_Button button)
    {
    }

    [Token(Token = "0x6008F00")]
    [Address(RVA = "0x5245E0", Offset = "0x5233E0", VA = "0x105245E0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6008F01")]
    [Address(RVA = "0x524570", Offset = "0x523370", VA = "0x10524570")]
    public void Refresh(ConceptCardDetailBase concept)
    {
    }

    [Token(Token = "0x6008F02")]
    [Address(RVA = "0x5252D0", Offset = "0x5240D0", VA = "0x105252D0")]
    public void SetParam(ConceptCardDetailBase concept, ConceptCardData data)
    {
    }

    [Token(Token = "0x6008F03")]
    [Address(RVA = "0x525250", Offset = "0x524050", VA = "0x10525250")]
    public void SetParam(
      ConceptCardDetailBase concept,
      ConceptCardData data,
      int addExp,
      int addTrust,
      int addAwakeLv,
      bool isExtra = false)
    {
    }

    [Token(Token = "0x6008F04")]
    [Address(RVA = "0x5237F0", Offset = "0x5225F0", VA = "0x105237F0")]
    public void CreatePrefab(GameObject ability_detail_parent)
    {
    }

    [Token(Token = "0x6008F05")]
    [Address(RVA = "0x523B30", Offset = "0x522930", VA = "0x10523B30")]
    public void CreateSkinPrefab()
    {
    }

    [Token(Token = "0x6008F06")]
    [Address(RVA = "0x523810", Offset = "0x522610", VA = "0x10523810")]
    public void CreateSkillPrefab(GameObject ability_detail_parent)
    {
    }

    [Token(Token = "0x6008F07")]
    [Address(RVA = "0x523710", Offset = "0x522510", VA = "0x10523710")]
    private AbilityDeriveList CreateAbilityListItem() => (AbilityDeriveList) null;

    [Token(Token = "0x6008F08")]
    [Address(RVA = "0x524110", Offset = "0x522F10", VA = "0x10524110")]
    public void OnClickOpenBonusButton()
    {
    }

    [Token(Token = "0x6008F09")]
    [Address(RVA = "0x5243C0", Offset = "0x5231C0", VA = "0x105243C0")]
    private IEnumerator OpenBonusWindow(ConceptCardData concept_card) => (IEnumerator) null;

    [Token(Token = "0x6008F0A")]
    [Address(RVA = "0x524190", Offset = "0x522F90", VA = "0x10524190")]
    private void OnDestoryBonusWindow(GameObject obj)
    {
    }

    [Token(Token = "0x6008F0B")]
    [Address(RVA = "0x523F10", Offset = "0x522D10", VA = "0x10523F10")]
    public void OnClickDetail(ConceptCardSkillDatailData data)
    {
    }

    [Token(Token = "0x6008F0C")]
    [Address(RVA = "0x524230", Offset = "0x523030", VA = "0x10524230")]
    private void OnDestroyAbilityDescription(GameObject go)
    {
    }

    [Token(Token = "0x6008F0D")]
    [Address(RVA = "0x5242D0", Offset = "0x5230D0", VA = "0x105242D0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6008F0E")]
    [Address(RVA = "0x5258D0", Offset = "0x5246D0", VA = "0x105258D0")]
    public ConceptCardDescription()
    {
    }

    [Token(Token = "0x20021DF")]
    public class ConceptCardEnhanceInfo
    {
      [Token(Token = "0x40094D3")]
      [FieldOffset(Offset = "0x8")]
      private ConceptCardData target;
      [Token(Token = "0x40094D4")]
      [FieldOffset(Offset = "0xC")]
      private int add_exp;
      [Token(Token = "0x40094D5")]
      [FieldOffset(Offset = "0x10")]
      private int add_trust;
      [Token(Token = "0x40094D6")]
      [FieldOffset(Offset = "0x14")]
      private int add_awake_lv;
      [Token(Token = "0x40094D7")]
      [FieldOffset(Offset = "0x18")]
      private int predict_lv;
      [Token(Token = "0x40094D8")]
      [FieldOffset(Offset = "0x1C")]
      private int predict_awake;

      [Token(Token = "0x1700142E")]
      public ConceptCardData Target
      {
        [Token(Token = "0x6008F0F"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return (ConceptCardData) null;
        }
      }

      [Token(Token = "0x1700142F")]
      public int addExp
      {
        [Token(Token = "0x6008F10"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17001430")]
      public int addTrust
      {
        [Token(Token = "0x6008F11"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17001431")]
      public int addAwakeLv
      {
        [Token(Token = "0x6008F12"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17001432")]
      public int predictLv
      {
        [Token(Token = "0x6008F13"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17001433")]
      public int predictAwake
      {
        [Token(Token = "0x6008F14"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x6008F15")]
      [Address(RVA = "0x52E170", Offset = "0x52CF70", VA = "0x1052E170")]
      public ConceptCardEnhanceInfo(
        ConceptCardData _concept_card,
        int _add_exp,
        int _add_trust,
        int _add_awake_lv)
      {
      }

      [Token(Token = "0x6008F16")]
      [Address(RVA = "0x52E130", Offset = "0x52CF30", VA = "0x1052E130")]
      public void Clear()
      {
      }
    }
  }
}
