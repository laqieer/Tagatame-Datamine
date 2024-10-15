// Decompiled with JetBrains decompiler
// Type: SRPG.ArtifactDetailAbilityContent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FF4")]
  [AddComponentMenu("UI/ArtifactDetailAbilityContent")]
  public class ArtifactDetailAbilityContent : MonoBehaviour
  {
    [Token(Token = "0x4008803")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mDeriveAbilityObject;
    [Token(Token = "0x4008804")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ArtifactDetailAbilityItem mBaseAbilityItem;
    [Token(Token = "0x4008805")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mDeriveParent;
    [Token(Token = "0x4008806")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ArtifactDetailAbilityItem mDeriveTemplate;
    [Token(Token = "0x4008807")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject mInspratinoSkillParent;
    [Token(Token = "0x4008808")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mInspratinoSkillContent;
    [Token(Token = "0x4008809")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject mInspratinoSkillNoSet;
    [Token(Token = "0x400880A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject mStoneEffecrParent;
    [Token(Token = "0x400880B")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x400880C")]
    [FieldOffset(Offset = "0x30")]
    private List<ArtifactDetailAbilityItem> mAbilityItems;
    [Token(Token = "0x400880D")]
    [FieldOffset(Offset = "0x34")]
    private ArtifactDetailWindow.ETabAbility mEContentType;

    [Token(Token = "0x170012E0")]
    public ArtifactDetailWindow.ETabAbility ContentTabType
    {
      [Token(Token = "0x60083ED"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return new ArtifactDetailWindow.ETabAbility();
      }
    }

    [Token(Token = "0x60083EE")]
    [Address(RVA = "0x4489B0", Offset = "0x4477B0", VA = "0x104489B0")]
    private void SetActiveByType(ArtifactDetailWindow.ETabAbility type)
    {
    }

    [Token(Token = "0x170012E1")]
    public bool IsExistEnableAbility
    {
      [Token(Token = "0x60083EF"), Address(RVA = "0x448AC0", Offset = "0x4478C0", VA = "0x10448AC0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60083F0")]
    [Address(RVA = "0x4484C0", Offset = "0x4472C0", VA = "0x104484C0")]
    public void Init(ViewAbilityData view_ability_data)
    {
    }

    [Token(Token = "0x60083F1")]
    [Address(RVA = "0x448260", Offset = "0x447060", VA = "0x10448260")]
    private void CreateBaseAbilityContent(
      ViewAbilityData view_ability_data,
      bool has_derive_ability)
    {
    }

    [Token(Token = "0x60083F2")]
    [Address(RVA = "0x4482D0", Offset = "0x4470D0", VA = "0x104482D0")]
    private int CreateDeriveAbilityContents(ViewAbilityData view_data) => new int();

    [Token(Token = "0x60083F3")]
    [Address(RVA = "0x448090", Offset = "0x446E90", VA = "0x10448090")]
    private void BindData(
      GameObject target,
      AbilityParam ability_data,
      AbilityDeriveParam ability_derive_param)
    {
    }

    [Token(Token = "0x60083F4")]
    [Address(RVA = "0x4486B0", Offset = "0x4474B0", VA = "0x104486B0")]
    public void Init(InspirationSkillData inspration_skill)
    {
    }

    [Token(Token = "0x60083F5")]
    [Address(RVA = "0x448880", Offset = "0x447680", VA = "0x10448880")]
    public void Init(ArtifactStoneEffectParam stone_effect)
    {
    }

    [Token(Token = "0x60083F6")]
    [Address(RVA = "0x448A50", Offset = "0x447850", VA = "0x10448A50")]
    public ArtifactDetailAbilityContent()
    {
    }
  }
}
