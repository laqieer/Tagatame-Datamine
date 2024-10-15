// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardTrustMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200224F")]
  [AddComponentMenu("UI/ConceptCardTrustMaster")]
  public class ConceptCardTrustMaster : MonoBehaviour
  {
    [Token(Token = "0x4009839")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private RawImage mCardImage;
    [Token(Token = "0x400983A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private RawImage mCardImageAdd;

    [Token(Token = "0x600923E")]
    [Address(RVA = "0x558F60", Offset = "0x557D60", VA = "0x10558F60")]
    public void SetData(ConceptCardData data)
    {
    }

    [Token(Token = "0x600923F")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ConceptCardTrustMaster()
    {
    }
  }
}
