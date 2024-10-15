// Decompiled with JetBrains decompiler
// Type: SRPG.InvalidSkillContentNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002651")]
  [FlowNode.Pin(3, "詳細", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(2, "スキルOFF", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "スキルON", FlowNode.PinTypes.Input, 1)]
  public class InvalidSkillContentNode : ContentNode, IFlowInterface
  {
    [Token(Token = "0x400B322")]
    public const int INPUT_SKILL_ON = 1;
    [Token(Token = "0x400B323")]
    public const int INPUT_SKILL_OFF = 2;
    [Token(Token = "0x400B324")]
    public const int INPUT_DETAIL_OPEN = 3;
    [Token(Token = "0x400B325")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text mSkillNameText;
    [Token(Token = "0x400B326")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject mMask;
    [Token(Token = "0x400B327")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Toggle mSkillOnToggle;
    [Token(Token = "0x400B328")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private Toggle mSkillOffToggle;
    [Token(Token = "0x400B329")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject mSkillIconsRoot;
    [Token(Token = "0x400B32A")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private Button mDetailBtn;
    [Token(Token = "0x400B32B")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private RawImage mJobIcon;
    [Token(Token = "0x400B32C")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private ConceptCardIcon mConceptCardIcon;
    [Token(Token = "0x400B32D")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private ArtifactIcon mArtifactIcon;
    [Token(Token = "0x400B32E")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private GameObject mLockIcon;
    [Token(Token = "0x400B32F")]
    [FieldOffset(Offset = "0x58")]
    private bool mIsInvalidSkill;
    [Token(Token = "0x400B330")]
    [FieldOffset(Offset = "0x5C")]
    private InvalidSkillParam mInvalidSkillParam;

    [Token(Token = "0x600AB16")]
    [Address(RVA = "0x6E3E70", Offset = "0x6E2C70", VA = "0x106E3E70", Slot = "18")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AB17")]
    [Address(RVA = "0x6E4670", Offset = "0x6E3470", VA = "0x106E4670")]
    public void Setup(InvalidSkillParam invalidSkillParam)
    {
    }

    [Token(Token = "0x600AB18")]
    [Address(RVA = "0x6E4400", Offset = "0x6E3200", VA = "0x106E4400")]
    public void SetupMasterAbility(InvalidSkillParam invalidSkillParam)
    {
    }

    [Token(Token = "0x600AB19")]
    [Address(RVA = "0x6E4190", Offset = "0x6E2F90", VA = "0x106E4190")]
    private void SetToggleBtn(string skill_iname)
    {
    }

    [Token(Token = "0x600AB1A")]
    [Address(RVA = "0x6E4100", Offset = "0x6E2F00", VA = "0x106E4100")]
    private void SetActiveIcon(EInvalidSkillType _type)
    {
    }

    [Token(Token = "0x600AB1B")]
    [Address(RVA = "0x6E3F80", Offset = "0x6E2D80", VA = "0x106E3F80")]
    private void OnSelectSkillBtn(bool is_invalid_skill)
    {
    }

    [Token(Token = "0x600AB1C")]
    [Address(RVA = "0x6E48E0", Offset = "0x6E36E0", VA = "0x106E48E0")]
    private void SkillDetailOpen()
    {
    }

    [Token(Token = "0x600AB1D")]
    [Address(RVA = "0x4180F0", Offset = "0x416EF0", VA = "0x104180F0")]
    public InvalidSkillContentNode()
    {
    }
  }
}
