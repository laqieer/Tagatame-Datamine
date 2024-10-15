// Decompiled with JetBrains decompiler
// Type: SRPG.MultiConceptCard
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002236")]
  public class MultiConceptCard
  {
    [Token(Token = "0x40097AA")]
    [FieldOffset(Offset = "0x8")]
    private List<OLong> mMultiSelectedUniqueID;

    [Token(Token = "0x60091A1")]
    [Address(RVA = "0x5600A0", Offset = "0x55EEA0", VA = "0x105600A0")]
    public void Clone(MultiConceptCard mbase)
    {
    }

    [Token(Token = "0x60091A2")]
    [Address(RVA = "0x560120", Offset = "0x55EF20", VA = "0x10560120")]
    public bool Contains(long uniqueID) => new bool();

    [Token(Token = "0x60091A3")]
    [Address(RVA = "0x5609E0", Offset = "0x55F7E0", VA = "0x105609E0")]
    public void SetArray(ConceptCardData[] array)
    {
    }

    [Token(Token = "0x60091A4")]
    [Address(RVA = "0x55FFB0", Offset = "0x55EDB0", VA = "0x1055FFB0")]
    public void Add(ConceptCardData ccd)
    {
    }

    [Token(Token = "0x60091A5")]
    [Address(RVA = "0x5608B0", Offset = "0x55F6B0", VA = "0x105608B0")]
    public void Remove(ConceptCardData ccd)
    {
    }

    [Token(Token = "0x60091A6")]
    [Address(RVA = "0x560960", Offset = "0x55F760", VA = "0x10560960")]
    public void Remove(long uniqueID)
    {
    }

    [Token(Token = "0x60091A7")]
    [Address(RVA = "0x560840", Offset = "0x55F640", VA = "0x10560840")]
    public bool IsSelected(ConceptCardData ccd) => new bool();

    [Token(Token = "0x60091A8")]
    [Address(RVA = "0x560060", Offset = "0x55EE60", VA = "0x10560060")]
    public void Clear()
    {
    }

    [Token(Token = "0x17001480")]
    public int Count
    {
      [Token(Token = "0x60091A9"), Address(RVA = "0x560B70", Offset = "0x55F970", VA = "0x10560B70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60091AA")]
    [Address(RVA = "0x5601A0", Offset = "0x55EFA0", VA = "0x105601A0")]
    public void Flip(ConceptCardData ccd)
    {
    }

    [Token(Token = "0x60091AB")]
    [Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")]
    public List<OLong> GetIDList() => (List<OLong>) null;

    [Token(Token = "0x60091AC")]
    [Address(RVA = "0x560370", Offset = "0x55F170", VA = "0x10560370")]
    public List<ConceptCardData> GetList() => (List<ConceptCardData>) null;

    [Token(Token = "0x60091AD")]
    [Address(RVA = "0x560610", Offset = "0x55F410", VA = "0x10560610")]
    public List<long> GetUniqueIDs() => (List<long>) null;

    [Token(Token = "0x60091AE")]
    [Address(RVA = "0x560230", Offset = "0x55F030", VA = "0x10560230")]
    public ConceptCardData GetItem(int index) => (ConceptCardData) null;

    [Token(Token = "0x60091AF")]
    [Address(RVA = "0x560B00", Offset = "0x55F900", VA = "0x10560B00")]
    public MultiConceptCard()
    {
    }
  }
}
