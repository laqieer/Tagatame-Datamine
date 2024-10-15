// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardRarityCheck
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200223D")]
  [AddComponentMenu("UI/ConceptCardRarityCheck")]
  public class ConceptCardRarityCheck : MonoBehaviour
  {
    [Token(Token = "0x40097C3")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mCardObjectTemplate;
    [Token(Token = "0x40097C4")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private RectTransform mCardObjectParent;
    [Token(Token = "0x40097C5")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private LText mLText;
    [Token(Token = "0x40097C6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mButtonEnhance;
    [Token(Token = "0x40097C7")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject mButtonSell;

    [Token(Token = "0x60091C6")]
    [Address(RVA = "0x550C70", Offset = "0x54FA70", VA = "0x10550C70")]
    private void Start()
    {
    }

    [Token(Token = "0x60091C7")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ConceptCardRarityCheck()
    {
    }
  }
}
