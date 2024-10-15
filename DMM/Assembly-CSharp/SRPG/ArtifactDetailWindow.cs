// Decompiled with JetBrains decompiler
// Type: SRPG.ArtifactDetailWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FF6")]
  [AddComponentMenu("UI/ArtifactDetailWindow")]
  [FlowNode.Pin(12, "武輝石スキルタブ選択", FlowNode.PinTypes.Input, 12)]
  [FlowNode.Pin(100, "アビリティ詳細画面の表示", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(10, "武具Abilityタブ選択", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(2, "武具ステータスタブ選択", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(11, "開眼スキルタブ選択", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(1, "武具詳細タブ選択", FlowNode.PinTypes.Input, 1)]
  public class ArtifactDetailWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008818")]
    private const int PIN_IN_SELECT_WEAPON_DETAIL = 1;
    [Token(Token = "0x4008819")]
    private const int PIN_IN_SELECT_ARTIFACT_STATUS = 2;
    [Token(Token = "0x400881A")]
    private const int PIN_IN_SELECT_WEAPON_ABILITY = 10;
    [Token(Token = "0x400881B")]
    private const int PIN_IN_SELECT_INSPIRATION_SKILL = 11;
    [Token(Token = "0x400881C")]
    private const int PIN_IN_SELECT_ARTIFACT_STONE = 12;
    [Token(Token = "0x400881D")]
    private const int PIN_OUT_ABILITY_DETAIL = 100;
    [Token(Token = "0x400881E")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mAbilityContentTemplate;
    [Token(Token = "0x400881F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mAbilityEmptyTextObject;
    [Token(Token = "0x4008820")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Toggle mHideDisplayAbilityToggle;
    [Token(Token = "0x4008821")]
    [FieldOffset(Offset = "0x18")]
    [HeaderBar("▼セット効果確認用のボタン")]
    [SerializeField]
    private Button mSetEffectsButton;
    [Token(Token = "0x4008822")]
    [FieldOffset(Offset = "0x1C")]
    [HeaderBar("▼左側TAB：Info/Status")]
    [SerializeField]
    private GameObject mTabArtifactInfoParent;
    [Token(Token = "0x4008823")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mTabArtifactStatusParent;
    [Token(Token = "0x4008824")]
    [FieldOffset(Offset = "0x24")]
    [HeaderBar("▼⇒側TABObject：Insp/Stone")]
    [SerializeField]
    private GameObject mTabInsprationSkillParent;
    [Token(Token = "0x4008825")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject mTabStoneEffectParent;
    [Token(Token = "0x4008826")]
    [FieldOffset(Offset = "0x2C")]
    [HeaderBar("▼左側TAB：Info/Status")]
    public StatusList Status;
    [Token(Token = "0x4008827")]
    [FieldOffset(Offset = "0x30")]
    private ArtifactDetailWindow.ETabParam mETabParam;
    [Token(Token = "0x4008828")]
    [FieldOffset(Offset = "0x34")]
    private ArtifactDetailWindow.ETabAbility mETabAbility;
    [Token(Token = "0x4008829")]
    [FieldOffset(Offset = "0x38")]
    private ArtifactParam mCurrentArtifactParam;
    [Token(Token = "0x400882A")]
    [FieldOffset(Offset = "0x3C")]
    private ArtifactData mCurrentArtifactData;
    [Token(Token = "0x400882B")]
    [FieldOffset(Offset = "0x40")]
    private UnitData mCurrentUnit;
    [Token(Token = "0x400882C")]
    [FieldOffset(Offset = "0x44")]
    private JobData mCurrentJob;
    [Token(Token = "0x400882D")]
    [FieldOffset(Offset = "0x48")]
    private ArtifactTypes mCurrentEquipSlot;
    [Token(Token = "0x400882E")]
    [FieldOffset(Offset = "0x4C")]
    private Dictionary<string, ViewAbilityData> mViewAbilities;
    [Token(Token = "0x400882F")]
    [FieldOffset(Offset = "0x50")]
    private List<ArtifactDetailAbilityContent> mAbilityContents;
    [Token(Token = "0x4008830")]
    [FieldOffset(Offset = "0x0")]
    private static ArtifactParam s_ArtifactParam;
    [Token(Token = "0x4008831")]
    [FieldOffset(Offset = "0x4")]
    private static ArtifactData s_ArtifactData;

    [Token(Token = "0x6008401")]
    [Address(RVA = "0x44A8B0", Offset = "0x4496B0", VA = "0x1044A8B0")]
    public static void SetArtifactParam(ArtifactParam artifactParam)
    {
    }

    [Token(Token = "0x6008402")]
    [Address(RVA = "0x44A860", Offset = "0x449660", VA = "0x1044A860")]
    public static void SetArtifactData(ArtifactData artifactData)
    {
    }

    [Token(Token = "0x170012E4")]
    private bool IsNeedCheck
    {
      [Token(Token = "0x6008403"), Address(RVA = "0x44AE90", Offset = "0x449C90", VA = "0x1044AE90")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6008404")]
    [Address(RVA = "0x448F80", Offset = "0x447D80", VA = "0x10448F80", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008405")]
    [Address(RVA = "0x44A530", Offset = "0x449330", VA = "0x1044A530")]
    private void RefreshView()
    {
    }

    [Token(Token = "0x6008406")]
    [Address(RVA = "0x44A8F0", Offset = "0x4496F0", VA = "0x1044A8F0")]
    private void Start()
    {
    }

    [Token(Token = "0x6008407")]
    [Address(RVA = "0x449E00", Offset = "0x448C00", VA = "0x10449E00")]
    private void InitWeaponAbility()
    {
    }

    [Token(Token = "0x6008408")]
    [Address(RVA = "0x449730", Offset = "0x448530", VA = "0x10449730")]
    private void InitArtifactStatus()
    {
    }

    [Token(Token = "0x6008409")]
    [Address(RVA = "0x449920", Offset = "0x448720", VA = "0x10449920")]
    private void InitInsprationSkillData()
    {
    }

    [Token(Token = "0x600840A")]
    [Address(RVA = "0x449B90", Offset = "0x448990", VA = "0x10449B90")]
    private void InitStoneEffectData()
    {
    }

    [Token(Token = "0x600840B")]
    [Address(RVA = "0x4491B0", Offset = "0x447FB0", VA = "0x104491B0")]
    private ArtifactDetailAbilityContent CreateInstance() => (ArtifactDetailAbilityContent) null;

    [Token(Token = "0x600840C")]
    [Address(RVA = "0x4492D0", Offset = "0x4480D0", VA = "0x104492D0")]
    private Dictionary<string, ViewAbilityData> CreateViewData(
      List<AbilityParam> artifact_all_abilities,
      List<AbilityData> weapon_abilities,
      List<AbilityDeriveParam> derive_params)
    {
      return (Dictionary<string, ViewAbilityData>) null;
    }

    [Token(Token = "0x600840D")]
    [Address(RVA = "0x449040", Offset = "0x447E40", VA = "0x10449040")]
    private void ChangeDisplayBaseAbility(bool is_display)
    {
    }

    [Token(Token = "0x600840E")]
    [Address(RVA = "0x44A710", Offset = "0x449510", VA = "0x1044A710")]
    private void Reposition()
    {
    }

    [Token(Token = "0x600840F")]
    [Address(RVA = "0x44A4A0", Offset = "0x4492A0", VA = "0x1044A4A0")]
    public void OpenAbilityDetail()
    {
    }

    [Token(Token = "0x6008410")]
    [Address(RVA = "0x44A400", Offset = "0x449200", VA = "0x1044A400")]
    public void OnChangeDisplayBaseAbility()
    {
    }

    [Token(Token = "0x6008411")]
    [Address(RVA = "0x44A430", Offset = "0x449230", VA = "0x1044A430")]
    public void OnCheckJobButton()
    {
    }

    [Token(Token = "0x6008412")]
    [Address(RVA = "0x44A4C0", Offset = "0x4492C0", VA = "0x1044A4C0")]
    private void RefreshParamTab()
    {
    }

    [Token(Token = "0x6008413")]
    [Address(RVA = "0x44AE20", Offset = "0x449C20", VA = "0x1044AE20")]
    public ArtifactDetailWindow()
    {
    }

    [Token(Token = "0x2001FF7")]
    private enum ETabParam
    {
      [Token(Token = "0x4008833")] INFO,
      [Token(Token = "0x4008834")] STATUS,
    }

    [Token(Token = "0x2001FF8")]
    public enum ETabAbility
    {
      [Token(Token = "0x4008836")] WEAPON_ABILITY,
      [Token(Token = "0x4008837")] INSPIRATION_SKILL,
      [Token(Token = "0x4008838")] STONE_EFFECT,
    }
  }
}
