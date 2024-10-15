// Decompiled with JetBrains decompiler
// Type: SRPG.GiftTypes
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001040")]
  public enum GiftTypes : long
  {
    [Token(Token = "0x40039E7")] Item = 1,
    [Token(Token = "0x40039E8")] Gold = 2,
    [Token(Token = "0x40039E9")] Coin = 4,
    [Token(Token = "0x40039EA")] ArenaCoin = 8,
    [Token(Token = "0x40039EB")] MultiCoin = 16, // 0x0000000000000010
    [Token(Token = "0x40039EC")] KakeraCoin = 32, // 0x0000000000000020
    [Token(Token = "0x40039ED")] Artifact = 64, // 0x0000000000000040
    [Token(Token = "0x40039EE")] Unit = 128, // 0x0000000000000080
    [Token(Token = "0x40039EF")] SelectUnitItem = 256, // 0x0000000000000100
    [Token(Token = "0x40039F0")] SelectItem = 512, // 0x0000000000000200
    [Token(Token = "0x40039F1")] SelectArtifactItem = 1024, // 0x0000000000000400
    [Token(Token = "0x40039F2")] Award = 2048, // 0x0000000000000800
    [Token(Token = "0x40039F3")] ConceptCard = 4096, // 0x0000000000001000
    [Token(Token = "0x40039F4")] SelectConceptCardItem = 8192, // 0x0000000000002000
    [Token(Token = "0x40039F6")] SelectSummonTickets = 9984, // 0x0000000000002700
    [Token(Token = "0x40039F7")] IgnoreReceiveAll = 10112, // 0x0000000000002780
    [Token(Token = "0x40039F5")] Crystal = 16384, // 0x0000000000004000
  }
}
