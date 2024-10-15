// Decompiled with JetBrains decompiler
// Type: SRPG.Json_TrophyConceptCard
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FF2")]
  [MessagePackObject(true)]
  public class Json_TrophyConceptCard
  {
    [Token(Token = "0x40038AE")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40038AF")]
    [FieldOffset(Offset = "0xC")]
    public string unit;

    [Token(Token = "0x6004256")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_TrophyConceptCard()
    {
    }
  }
}
