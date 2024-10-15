// Decompiled with JetBrains decompiler
// Type: SRPG.Json_DifferenceUpdatePlayerForConceptCard
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E87")]
  [MessagePackObject(true)]
  [Serializable]
  public class Json_DifferenceUpdatePlayerForConceptCard : Json_DifferenceUpdatePlayer
  {
    [Token(Token = "0x4002C9A")]
    [FieldOffset(Offset = "0x28")]
    public JSON_ConceptCard concept_card;

    [Token(Token = "0x6003C37")]
    [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
    public Json_DifferenceUpdatePlayerForConceptCard()
    {
    }
  }
}
