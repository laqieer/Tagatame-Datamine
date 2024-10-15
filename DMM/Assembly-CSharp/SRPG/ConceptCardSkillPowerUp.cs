// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardSkillPowerUp
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002247")]
  [AddComponentMenu("UI/ConceptCardSkillPowerUp")]
  [FlowNode.Pin(101, "表示コンテンツなし", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(0, "タップ入力", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(100, "全ページ表示終了", FlowNode.PinTypes.Output, 100)]
  public class ConceptCardSkillPowerUp : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400981B")]
    private const int PIN_PAGE_NEXT = 0;
    [Token(Token = "0x400981C")]
    private const int PIN_FINISHED = 100;
    [Token(Token = "0x400981D")]
    private const int PIN_NO_CONTENTS = 101;
    [Token(Token = "0x400981E")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Transform resultRoot;
    [Token(Token = "0x400981F")]
    [FieldOffset(Offset = "0x10")]
    private SkillPowerUpResult skillPowerUpResult;

    [Token(Token = "0x1700148D")]
    public Transform ResultRoot
    {
      [Token(Token = "0x600920D"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x600920E")]
    [Address(RVA = "0x556930", Offset = "0x555730", VA = "0x10556930")]
    public void SetData(
      SkillPowerUpResult inSkillPowerUpResult,
      ConceptCardData currentCardData,
      int prevAwakeCount,
      int prevLevel)
    {
    }

    [Token(Token = "0x600920F")]
    [Address(RVA = "0x556890", Offset = "0x555690", VA = "0x10556890", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009210")]
    [Address(RVA = "0x5568E0", Offset = "0x5556E0", VA = "0x105568E0")]
    private void CheckPages()
    {
    }

    [Token(Token = "0x6009211")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ConceptCardSkillPowerUp()
    {
    }
  }
}
