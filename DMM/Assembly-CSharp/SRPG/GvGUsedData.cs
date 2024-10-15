// Decompiled with JetBrains decompiler
// Type: SRPG.GvGUsedData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20025C5")]
  public class GvGUsedData
  {
    [Token(Token = "0x400AF43")]
    [FieldOffset(Offset = "0x8")]
    public List<int> Artifacts;
    [Token(Token = "0x400AF44")]
    [FieldOffset(Offset = "0xC")]
    public List<int> Cards;
    [Token(Token = "0x400AF45")]
    [FieldOffset(Offset = "0x10")]
    public List<int> Runes;
    [Token(Token = "0x400AF46")]
    [FieldOffset(Offset = "0x14")]
    public List<long> Crystals;

    [Token(Token = "0x600A7CB")]
    [Address(RVA = "0x6C3130", Offset = "0x6C1F30", VA = "0x106C3130")]
    public void Deserialize(int[] artifacts, int[] cards, int[] runes, long[] crystals)
    {
    }

    [Token(Token = "0x600A7CC")]
    [Address(RVA = "0x6C3810", Offset = "0x6C2610", VA = "0x106C3810")]
    public void RemoveUnitUsedItems(eOverWritePartyType type, UnitData[] units)
    {
    }

    [Token(Token = "0x600A7CD")]
    [Address(RVA = "0x6C35B0", Offset = "0x6C23B0", VA = "0x106C35B0")]
    public bool IsUnitUsedItems(UnitData unit) => new bool();

    [Token(Token = "0x600A7CE")]
    [Address(RVA = "0x6C3470", Offset = "0x6C2270", VA = "0x106C3470")]
    public bool IsArtifactUsed(long id) => new bool();

    [Token(Token = "0x600A7CF")]
    [Address(RVA = "0x6C34C0", Offset = "0x6C22C0", VA = "0x106C34C0")]
    public bool IsConceptCardUsed(long id) => new bool();

    [Token(Token = "0x600A7D0")]
    [Address(RVA = "0x6C3560", Offset = "0x6C2360", VA = "0x106C3560")]
    public bool IsRuneUsed(long id) => new bool();

    [Token(Token = "0x600A7D1")]
    [Address(RVA = "0x6C3510", Offset = "0x6C2310", VA = "0x106C3510")]
    public bool IsCrystalUsed(long id) => new bool();

    [Token(Token = "0x600A7D2")]
    [Address(RVA = "0x6C2960", Offset = "0x6C1760", VA = "0x106C2960")]
    public static string CreateUsedItemsStr(JSON_GvGUsedItems[] items) => (string) null;

    [Token(Token = "0x600A7D3")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GvGUsedData()
    {
    }
  }
}
