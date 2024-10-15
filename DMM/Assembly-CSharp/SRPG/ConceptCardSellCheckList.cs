// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardSellCheckList
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
  [Token(Token = "0x2002245")]
  [FlowNode.Pin(1, "表示設定", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("UI/ConceptCardSellCheckList")]
  public class ConceptCardSellCheckList : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400980E")]
    private const int PIN_SETUP = 1;
    [Token(Token = "0x400980F")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mCardObjectTemplate;
    [Token(Token = "0x4009810")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private RectTransform mCardObjectParent;
    [Token(Token = "0x4009811")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ScrollRect mScrollRect;
    [Token(Token = "0x4009812")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text TextSellZeny;
    [Token(Token = "0x4009813")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text TextSellCoin;
    [Token(Token = "0x4009814")]
    [FieldOffset(Offset = "0x20")]
    private MultiConceptCard mSelectedMaterials;
    [Token(Token = "0x4009815")]
    [FieldOffset(Offset = "0x24")]
    private List<ConceptCardData> mSelectedCardDatas;
    [Token(Token = "0x4009816")]
    [FieldOffset(Offset = "0x28")]
    private List<GameObject> ListObj;
    [Token(Token = "0x4009817")]
    [FieldOffset(Offset = "0x2C")]
    private ConceptCardManager mCCManager;

    [Token(Token = "0x1700148C")]
    private ConceptCardManager CCManager
    {
      [Token(Token = "0x6009204"), Address(RVA = "0x556510", Offset = "0x555310", VA = "0x10556510")] get
      {
        return (ConceptCardManager) null;
      }
    }

    [Token(Token = "0x6009205")]
    [Address(RVA = "0x555AF0", Offset = "0x5548F0", VA = "0x10555AF0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009206")]
    [Address(RVA = "0x555B10", Offset = "0x554910", VA = "0x10555B10")]
    public void Init()
    {
    }

    [Token(Token = "0x6009207")]
    [Address(RVA = "0x555B80", Offset = "0x554980", VA = "0x10555B80")]
    private void RefreshList()
    {
    }

    [Token(Token = "0x6009208")]
    [Address(RVA = "0x556380", Offset = "0x555180", VA = "0x10556380")]
    private void RefreshTextSellZeny()
    {
    }

    [Token(Token = "0x6009209")]
    [Address(RVA = "0x5562E0", Offset = "0x5550E0", VA = "0x105562E0")]
    private void RefreshTextSellCoin()
    {
    }

    [Token(Token = "0x600920A")]
    [Address(RVA = "0x556420", Offset = "0x555220", VA = "0x10556420")]
    public ConceptCardSellCheckList()
    {
    }
  }
}
