// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptLimitUpItemParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A7E")]
  [MessagePackObject(true)]
  public class ConceptLimitUpItemParam
  {
    [Token(Token = "0x4006200")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4006201")]
    [FieldOffset(Offset = "0xC")]
    public int num;

    [Token(Token = "0x6006CDB")]
    [Address(RVA = "0x357050", Offset = "0x355E50", VA = "0x10357050")]
    public static bool Desirialize(
      JSON_ConceptLimitUpItem[] jsons,
      Dictionary<string, ConceptCardParam> concept_card_params,
      Dictionary<string, List<ConceptCardParam>> concept_card_groups)
    {
      return new bool();
    }

    [Token(Token = "0x6006CDC")]
    [Address(RVA = "0x356FE0", Offset = "0x355DE0", VA = "0x10356FE0")]
    private static void AddParamList(ConceptCardParam add_param, List<ConceptCardParam> add_list)
    {
    }

    [Token(Token = "0x6006CDD")]
    [Address(RVA = "0x357670", Offset = "0x356470", VA = "0x10357670")]
    private static void RemoveParamList(
      ConceptCardParam remove_param,
      List<ConceptCardParam> remove_list)
    {
    }

    [Token(Token = "0x6006CDE")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ConceptLimitUpItemParam()
    {
    }
  }
}
