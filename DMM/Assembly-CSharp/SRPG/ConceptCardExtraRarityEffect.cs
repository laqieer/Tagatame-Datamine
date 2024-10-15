// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardExtraRarityEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A65")]
  [MessagePackObject(true)]
  [Serializable]
  public class ConceptCardExtraRarityEffect
  {
    [Token(Token = "0x4006163")]
    [FieldOffset(Offset = "0x8")]
    private string mCndsIname;
    [Token(Token = "0x4006164")]
    [FieldOffset(Offset = "0xC")]
    private string mAbilityIname;
    [Token(Token = "0x4006165")]
    [FieldOffset(Offset = "0x10")]
    private string mAbilityInameLvMax;

    [Token(Token = "0x17000BE1")]
    [IgnoreMember]
    public string CndsIname
    {
      [Token(Token = "0x6006C7F"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000BE2")]
    [IgnoreMember]
    public string AbilityIname
    {
      [Token(Token = "0x6006C80"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000BE3")]
    [IgnoreMember]
    public string AbilityInameLvMax
    {
      [Token(Token = "0x6006C81"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6006C82")]
    [Address(RVA = "0x3550B0", Offset = "0x353EB0", VA = "0x103550B0")]
    public bool Deserialize(JSON_ConceptCardExtraRarityEffect _json) => new bool();

    [Token(Token = "0x6006C83")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ConceptCardExtraRarityEffect()
    {
    }
  }
}
