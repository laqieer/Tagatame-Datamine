// Decompiled with JetBrains decompiler
// Type: SRPG.Models.ConceptCardExtraRarityMixConfirmModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003313")]
  public class ConceptCardExtraRarityMixConfirmModel
  {
    [Token(Token = "0x400F0CB")]
    [FieldOffset(Offset = "0x8")]
    private ConceptCardData _cardData;

    [Token(Token = "0x17001D8F")]
    public ConceptCardData cardData
    {
      [Token(Token = "0x600E0C7"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (ConceptCardData) null;
      }
    }

    [Token(Token = "0x600E0C8")]
    [Address(RVA = "0xAAAC00", Offset = "0xAA9A00", VA = "0x10AAAC00")]
    public void Initialize(ConceptCardData card)
    {
    }

    [Token(Token = "0x600E0C9")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ConceptCardExtraRarityMixConfirmModel()
    {
    }
  }
}
