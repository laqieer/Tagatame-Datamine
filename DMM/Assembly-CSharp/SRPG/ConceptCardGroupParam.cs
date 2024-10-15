// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardGroupParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A6B")]
  public class ConceptCardGroupParam
  {
    [Token(Token = "0x6006C96")]
    [Address(RVA = "0x3555F0", Offset = "0x3543F0", VA = "0x103555F0")]
    public static bool Deserialize(
      JSON_ConceptCardGroup[] json_groups,
      Dictionary<string, ConceptCardParam> concept_card_params,
      ref Dictionary<string, List<ConceptCardParam>> ref_params)
    {
      return new bool();
    }

    [Token(Token = "0x6006C97")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ConceptCardGroupParam()
    {
    }
  }
}
