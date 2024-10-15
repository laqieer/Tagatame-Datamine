// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardSellRarityList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002246")]
  [AddComponentMenu("UI/ConceptCardSellRarityList")]
  public class ConceptCardSellRarityList : MonoBehaviour
  {
    [Token(Token = "0x4009818")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Image RarityObj;
    [Token(Token = "0x4009819")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject ConceptCardObj;
    [Token(Token = "0x400981A")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private RectTransform ParentObj;

    [Token(Token = "0x600920B")]
    [Address(RVA = "0x5565D0", Offset = "0x5553D0", VA = "0x105565D0")]
    public void Init(MultiConceptCard card)
    {
    }

    [Token(Token = "0x600920C")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ConceptCardSellRarityList()
    {
    }
  }
}
