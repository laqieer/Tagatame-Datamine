// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardTrustWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002251")]
  [AddComponentMenu("UI/ConceptCardTrustWindow")]
  [FlowNode.Pin(12, "トラスト報酬なし", FlowNode.PinTypes.Output, 12)]
  [FlowNode.Pin(13, "念装詳細を表示", FlowNode.PinTypes.Output, 13)]
  [FlowNode.Pin(11, "武具詳細を表示", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(10, "アイテム詳細を表示", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(0, "詳細表示", FlowNode.PinTypes.Input, 0)]
  public class ConceptCardTrustWindow : ConceptCardDetailBase, IFlowInterface
  {
    [Token(Token = "0x4009843")]
    private const int PIN_SHOW_DETAIL = 0;
    [Token(Token = "0x4009844")]
    private const int PIN_DETAIL_ITEM = 10;
    [Token(Token = "0x4009845")]
    private const int PIN_DETAIL_ARIFACT = 11;
    [Token(Token = "0x4009846")]
    private const int PIN_DETAIL_NON = 12;
    [Token(Token = "0x4009847")]
    private const int PIN_DETAIL_CONCEPT_CARD = 13;
    [Token(Token = "0x4009848")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mConceptCardPrefab;
    [Token(Token = "0x4009849")]
    [FieldOffset(Offset = "0x14")]
    private ConceptCardEquipDetail mConceptCardEquipDetail;

    [Token(Token = "0x6009245")]
    [Address(RVA = "0x559070", Offset = "0x557E70", VA = "0x10559070", Slot = "8")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009246")]
    [Address(RVA = "0x559390", Offset = "0x558190", VA = "0x10559390")]
    public void ShowDetail()
    {
    }

    [Token(Token = "0x6009247")]
    [Address(RVA = "0x559240", Offset = "0x558040", VA = "0x10559240")]
    public bool SetItem(ConceptCardTrustRewardItemParam reward_item) => new bool();

    [Token(Token = "0x6009248")]
    [Address(RVA = "0x559090", Offset = "0x557E90", VA = "0x10559090")]
    public bool SetArtifact(ConceptCardTrustRewardItemParam reward_item) => new bool();

    [Token(Token = "0x6009249")]
    [Address(RVA = "0x559150", Offset = "0x557F50", VA = "0x10559150")]
    public bool SetConceptCard(ConceptCardTrustRewardItemParam reward_item) => new bool();

    [Token(Token = "0x600924A")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public ConceptCardTrustWindow()
    {
    }
  }
}
