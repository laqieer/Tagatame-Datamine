// Decompiled with JetBrains decompiler
// Type: SRPG.Json_TrophyPlayerData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FF5")]
  [MessagePackObject(true)]
  public class Json_TrophyPlayerData
  {
    [Token(Token = "0x40038B4")]
    [FieldOffset(Offset = "0x8")]
    public int exp;
    [Token(Token = "0x40038B5")]
    [FieldOffset(Offset = "0xC")]
    public int gold;
    [Token(Token = "0x40038B6")]
    [FieldOffset(Offset = "0x10")]
    public Json_Coin coin;
    [Token(Token = "0x40038B7")]
    [FieldOffset(Offset = "0x14")]
    public Json_Stamina stamina;

    [Token(Token = "0x6004259")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_TrophyPlayerData()
    {
    }
  }
}
