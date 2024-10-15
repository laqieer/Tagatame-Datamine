// Decompiled with JetBrains decompiler
// Type: SRPG.ArtifactSetList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002033")]
  [FlowNode.Pin(100, "アビリティ詳細が開く", FlowNode.PinTypes.Output, 0)]
  [AddComponentMenu("UI/ArtifactSetList")]
  public class ArtifactSetList : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x40089B3")]
    private const int OUTPUT_ABILITY_DETAIL_OPEN = 100;
    [Token(Token = "0x40089B4")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    [HeaderBar("▼セット効果のリストの親")]
    private RectTransform m_SetListRoot;
    [Token(Token = "0x40089B5")]
    [FieldOffset(Offset = "0x10")]
    [HeaderBar("▼セット効果のアイテムのテンプレート")]
    [SerializeField]
    private GameObject m_SetListItemTemplate;
    [Token(Token = "0x40089B6")]
    [FieldOffset(Offset = "0x14")]
    private ArtifactParam m_ArtifactParam;
    [Token(Token = "0x40089B7")]
    [FieldOffset(Offset = "0x0")]
    private static ArtifactParam s_SelectedArtifactParam;

    [Token(Token = "0x6008548")]
    [Address(RVA = "0x460570", Offset = "0x45F370", VA = "0x10460570")]
    public static void SetSelectedArtifactParam(ArtifactParam artifactParam)
    {
    }

    [Token(Token = "0x6008549")]
    [Address(RVA = "0x4605B0", Offset = "0x45F3B0", VA = "0x104605B0")]
    private void Start()
    {
    }

    [Token(Token = "0x600854A")]
    [Address(RVA = "0x460360", Offset = "0x45F160", VA = "0x10460360")]
    private void CreateListItem(
      List<SkillAbilityDeriveData> skillAbilityDeriveData)
    {
    }

    [Token(Token = "0x600854B")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600854C")]
    [Address(RVA = "0x460550", Offset = "0x45F350", VA = "0x10460550")]
    public void OnAbilityDetailOpen(GameObject go)
    {
    }

    [Token(Token = "0x600854D")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ArtifactSetList()
    {
    }
  }
}
