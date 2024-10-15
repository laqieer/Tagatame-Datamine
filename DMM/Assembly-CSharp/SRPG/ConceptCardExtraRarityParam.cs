// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardExtraRarityParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A66")]
  [MessagePackObject(true)]
  [Serializable]
  public class ConceptCardExtraRarityParam
  {
    [Token(Token = "0x4006166")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x4006167")]
    [FieldOffset(Offset = "0xC")]
    private List<ConceptCardExtraRarityEffect> mEffects;

    [Token(Token = "0x17000BE4")]
    [IgnoreMember]
    public string Iname
    {
      [Token(Token = "0x6006C84"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000BE5")]
    [IgnoreMember]
    public List<ConceptCardExtraRarityEffect> Effects
    {
      [Token(Token = "0x6006C85"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<ConceptCardExtraRarityEffect>) null;
      }
    }

    [Token(Token = "0x6006C86")]
    [Address(RVA = "0x3553A0", Offset = "0x3541A0", VA = "0x103553A0")]
    public bool Deserialize(JSON_ConceptCardExtraRarityParam _json) => new bool();

    [Token(Token = "0x6006C87")]
    [Address(RVA = "0x355100", Offset = "0x353F00", VA = "0x10355100")]
    public static void Deserialize(
      ref Dictionary<string, ConceptCardExtraRarityParam> dictionary,
      JSON_ConceptCardExtraRarityParam[] json)
    {
    }

    [Token(Token = "0x6006C88")]
    [Address(RVA = "0x355500", Offset = "0x354300", VA = "0x10355500")]
    public IEnumerable<ConceptCardExtraRarityEffect> GetEnableEffects()
    {
      return (IEnumerable<ConceptCardExtraRarityEffect>) null;
    }

    [Token(Token = "0x6006C89")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ConceptCardExtraRarityParam()
    {
    }
  }
}
