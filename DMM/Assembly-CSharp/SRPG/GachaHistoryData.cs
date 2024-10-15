// Decompiled with JetBrains decompiler
// Type: SRPG.GachaHistoryData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200242C")]
  public class GachaHistoryData
  {
    [Token(Token = "0x400A3E0")]
    [FieldOffset(Offset = "0x8")]
    public GachaDropData.Type type;
    [Token(Token = "0x400A3E1")]
    [FieldOffset(Offset = "0xC")]
    public UnitParam unit;
    [Token(Token = "0x400A3E2")]
    [FieldOffset(Offset = "0x10")]
    public ItemParam item;
    [Token(Token = "0x400A3E3")]
    [FieldOffset(Offset = "0x14")]
    public ArtifactParam artifact;
    [Token(Token = "0x400A3E4")]
    [FieldOffset(Offset = "0x18")]
    public ConceptCardParam conceptcard;
    [Token(Token = "0x400A3E5")]
    [FieldOffset(Offset = "0x1C")]
    public CrystalParam crystal;
    [Token(Token = "0x400A3E6")]
    [FieldOffset(Offset = "0x20")]
    public int num;
    [Token(Token = "0x400A3E7")]
    [FieldOffset(Offset = "0x24")]
    public bool isConvert;
    [Token(Token = "0x400A3E8")]
    [FieldOffset(Offset = "0x25")]
    public bool isNew;
    [Token(Token = "0x400A3E9")]
    [FieldOffset(Offset = "0x28")]
    public int rarity;
    [Token(Token = "0x400A3EA")]
    [FieldOffset(Offset = "0x2C")]
    public bool isDisassembly;
    [Token(Token = "0x400A3EB")]
    [FieldOffset(Offset = "0x30")]
    public int rank;

    [Token(Token = "0x6009DC3")]
    [Address(RVA = "0x601C40", Offset = "0x600A40", VA = "0x10601C40")]
    public void Init()
    {
    }

    [Token(Token = "0x6009DC4")]
    [Address(RVA = "0x601810", Offset = "0x600610", VA = "0x10601810")]
    public bool Deserialize(Json_GachaHistoryItem json) => new bool();

    [Token(Token = "0x6009DC5")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GachaHistoryData()
    {
    }
  }
}
