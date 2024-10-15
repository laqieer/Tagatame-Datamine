// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardDetailSkin
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20021F5")]
  [AddComponentMenu("UI/ConceptCardDetailSkin")]
  public class ConceptCardDetailSkin : ConceptCardDetailBase
  {
    [Token(Token = "0x400958F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text mCardNextSkinDesc;
    [Token(Token = "0x4009590")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private RawImage mCardSkinIcon;
    [Token(Token = "0x4009591")]
    [FieldOffset(Offset = "0x18")]
    private ConceptCardEquipEffect mConceptCardEquipEffect;

    [Token(Token = "0x6008FA0")]
    [Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")]
    public void SetEquipEffect(ConceptCardEquipEffect effect)
    {
    }

    [Token(Token = "0x6008FA1")]
    [Address(RVA = "0x52A4A0", Offset = "0x5292A0", VA = "0x1052A4A0", Slot = "7")]
    public override void Refresh()
    {
    }

    [Token(Token = "0x6008FA2")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ConceptCardDetailSkin()
    {
    }
  }
}
