// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardExtraRaritySelectedMaterialView
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
  [Token(Token = "0x20021D1")]
  [FlowNode.Pin(1, "確認画面への受け渡し情報をセット", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "確認画面を開く", FlowNode.PinTypes.Output, 100)]
  public class ConceptCardExtraRaritySelectedMaterialView : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400946A")]
    private const int PIN_IN_CONFIRM = 1;
    [Token(Token = "0x400946B")]
    private const int PIN_OUT_CONFIRM = 100;
    [Token(Token = "0x400946C")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ConceptCardIcon[] SelectedConceptCards;
    [Token(Token = "0x400946D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Button ConfirmButton;
    [Token(Token = "0x400946E")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject CostViewRoot;
    [Token(Token = "0x400946F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text CostText;
    [Token(Token = "0x4009470")]
    [FieldOffset(Offset = "0x1C")]
    private int mCost;
    [Token(Token = "0x4009471")]
    public const int SELECTED_MAX = 10;

    [Token(Token = "0x6008EC4")]
    [Address(RVA = "0x531FA0", Offset = "0x530DA0", VA = "0x10531FA0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008EC5")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Start()
    {
    }

    [Token(Token = "0x6008EC6")]
    [Address(RVA = "0x532250", Offset = "0x531050", VA = "0x10532250")]
    public void Refresh(List<ConceptCardData> cards)
    {
    }

    [Token(Token = "0x6008EC7")]
    [Address(RVA = "0x532140", Offset = "0x530F40", VA = "0x10532140")]
    private void RefreshIcons(List<ConceptCardData> cards)
    {
    }

    [Token(Token = "0x6008EC8")]
    [Address(RVA = "0x5325C0", Offset = "0x5313C0", VA = "0x105325C0")]
    private void SetSelectData()
    {
    }

    [Token(Token = "0x6008EC9")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ConceptCardExtraRaritySelectedMaterialView()
    {
    }
  }
}
