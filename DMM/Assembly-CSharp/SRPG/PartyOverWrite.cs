// Decompiled with JetBrains decompiler
// Type: SRPG.PartyOverWrite
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002E1F")]
  public class PartyOverWrite
  {
    [Token(Token = "0x400E5EE")]
    [FieldOffset(Offset = "0x8")]
    private eOverWritePartyType mPatryType;
    [Token(Token = "0x400E5EF")]
    [FieldOffset(Offset = "0xC")]
    private UnitOverWriteData[] mOverWriteDatas;
    [Token(Token = "0x400E5F0")]
    [FieldOffset(Offset = "0x10")]
    public int mPartyNo;

    [Token(Token = "0x17001CCD")]
    public eOverWritePartyType PatryType
    {
      [Token(Token = "0x600D993"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new eOverWritePartyType();
      }
    }

    [Token(Token = "0x17001CCE")]
    public UnitOverWriteData[] Units
    {
      [Token(Token = "0x600D994"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (UnitOverWriteData[]) null;
      }
    }

    [Token(Token = "0x17001CCF")]
    public int PartyNo
    {
      [Token(Token = "0x600D995"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600D996")]
    [Address(RVA = "0xA4CBE0", Offset = "0xA4B9E0", VA = "0x10A4CBE0")]
    public void Deserialize(JSON_PartyOverWrite json)
    {
    }

    [Token(Token = "0x600D997")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public PartyOverWrite()
    {
    }
  }
}
