// Decompiled with JetBrains decompiler
// Type: SRPG.BadgeViewUnitData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002969")]
  public class BadgeViewUnitData
  {
    [Token(Token = "0x400C791")]
    [FieldOffset(Offset = "0x8")]
    private long _uniqueID;
    [Token(Token = "0x400C792")]
    [FieldOffset(Offset = "0x10")]
    private string _piece;
    [Token(Token = "0x400C793")]
    [FieldOffset(Offset = "0x14")]
    private JobData[] _jobs;
    [Token(Token = "0x400C794")]
    [FieldOffset(Offset = "0x18")]
    private long[] _cards;
    [Token(Token = "0x400C795")]
    [FieldOffset(Offset = "0x1C")]
    private long[] _crystals;
    [Token(Token = "0x400C796")]
    [FieldOffset(Offset = "0x20")]
    private long _mainSlotCrystal;

    [Token(Token = "0x1700196E")]
    public long UniqueID
    {
      [Token(Token = "0x600BB57"), Address(RVA = "0x305C20", Offset = "0x304A20", VA = "0x10305C20")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x1700196F")]
    public string Piece
    {
      [Token(Token = "0x600BB58"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001970")]
    public JobData[] Jobs
    {
      [Token(Token = "0x600BB59"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (JobData[]) null;
      }
    }

    [Token(Token = "0x17001971")]
    public long[] ConceptCards
    {
      [Token(Token = "0x600BB5A"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (long[]) null;
      }
    }

    [Token(Token = "0x17001972")]
    public long[] Crystals
    {
      [Token(Token = "0x600BB5B"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (long[]) null;
      }
    }

    [Token(Token = "0x600BB5C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public BadgeViewUnitData()
    {
    }

    [Token(Token = "0x600BB5D")]
    [Address(RVA = "0x82A9E0", Offset = "0x8297E0", VA = "0x1082A9E0")]
    public BadgeViewUnitData(UnitData unit_data)
    {
    }

    [Token(Token = "0x600BB5E")]
    [Address(RVA = "0x82A760", Offset = "0x829560", VA = "0x1082A760")]
    public bool IsEquipArtifact(long iid) => new bool();

    [Token(Token = "0x600BB5F")]
    [Address(RVA = "0x82A820", Offset = "0x829620", VA = "0x1082A820")]
    public bool IsEquipConceptCard(long iid) => new bool();

    [Token(Token = "0x600BB60")]
    [Address(RVA = "0x82A920", Offset = "0x829720", VA = "0x1082A920")]
    public bool IsEquipCrystal(long iid) => new bool();

    [Token(Token = "0x600BB61")]
    [Address(RVA = "0x82A8E0", Offset = "0x8296E0", VA = "0x1082A8E0")]
    public bool IsEquipCrystalMainSlot(long iid) => new bool();
  }
}
