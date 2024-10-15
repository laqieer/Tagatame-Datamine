// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardNotSaleCheck
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200223C")]
  [AddComponentMenu("UI/ConceptCardNotSaleCheck")]
  public class ConceptCardNotSaleCheck : MonoBehaviour
  {
    [Token(Token = "0x40097C1")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mCardObjectTemplate;
    [Token(Token = "0x40097C2")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private RectTransform mCardObjectParent;

    [Token(Token = "0x60091C4")]
    [Address(RVA = "0x550950", Offset = "0x54F750", VA = "0x10550950")]
    private void Start()
    {
    }

    [Token(Token = "0x60091C5")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ConceptCardNotSaleCheck()
    {
    }
  }
}
