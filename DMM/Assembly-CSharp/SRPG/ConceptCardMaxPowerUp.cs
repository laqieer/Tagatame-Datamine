// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardMaxPowerUp
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200223A")]
  [FlowNode.Pin(101, "表示コンテンツなし", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(100, "全ページ表示終了", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("UI/ConceptCardMaxPowerUp")]
  [FlowNode.Pin(0, "タップ入力", FlowNode.PinTypes.Input, 0)]
  public class ConceptCardMaxPowerUp : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x40097B0")]
    private const int PIN_PAGE_NEXT = 0;
    [Token(Token = "0x40097B1")]
    private const int PIN_FINISHED = 100;
    [Token(Token = "0x40097B2")]
    private const int PIN_NO_CONTENTS = 101;
    [Token(Token = "0x40097B3")]
    private const string mGroupMaxAbilityResultPrefabPath = "UI/ConceptCardMaxPowerUpVisionAbility";
    [Token(Token = "0x40097B4")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Transform resultRoot;
    [Token(Token = "0x40097B5")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ConceptCardTrustMaster conceptCardTrustMaster;
    [Token(Token = "0x40097B6")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject[] limitTextImages;
    [Token(Token = "0x40097B7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject[] limitExTextImages;
    [Token(Token = "0x40097B8")]
    [FieldOffset(Offset = "0x1C")]
    private int prevAwakeCount;
    [Token(Token = "0x40097B9")]
    [FieldOffset(Offset = "0x20")]
    private ConceptCardData currentCardData;
    [Token(Token = "0x40097BA")]
    [FieldOffset(Offset = "0x24")]
    private SkillPowerUpResult skillPowerUpResult;
    [Token(Token = "0x40097BB")]
    [FieldOffset(Offset = "0x28")]
    private AbilityPowerUpResult abilityPowerUpResult;
    [Token(Token = "0x40097BC")]
    [FieldOffset(Offset = "0x2C")]
    private bool isEnd;

    [Token(Token = "0x17001482")]
    public Transform ResultRoot
    {
      [Token(Token = "0x60091B6"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x60091B7")]
    [Address(RVA = "0x550540", Offset = "0x54F340", VA = "0x10550540")]
    public void SetData(
      SkillPowerUpResult inSkillPowerUpResult,
      ConceptCardData inCurrentCardData,
      int inPrevAwakeCount,
      int inPrevLevel)
    {
    }

    [Token(Token = "0x60091B8")]
    [Address(RVA = "0x5501D0", Offset = "0x54EFD0", VA = "0x105501D0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x60091B9")]
    [Address(RVA = "0x5501F0", Offset = "0x54EFF0", VA = "0x105501F0")]
    private void CheckPages()
    {
    }

    [Token(Token = "0x60091BA")]
    [Address(RVA = "0x5503F0", Offset = "0x54F1F0", VA = "0x105503F0")]
    private bool HasAbilityPowerUp() => new bool();

    [Token(Token = "0x60091BB")]
    [Address(RVA = "0x550380", Offset = "0x54F180", VA = "0x10550380")]
    private IEnumerator CreateAbilityResultCroutine() => (IEnumerator) null;

    [Token(Token = "0x60091BC")]
    [Address(RVA = "0x550870", Offset = "0x54F670", VA = "0x10550870")]
    private void SetLimitImage(bool is_extra_rarity)
    {
    }

    [Token(Token = "0x60091BD")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ConceptCardMaxPowerUp()
    {
    }
  }
}
