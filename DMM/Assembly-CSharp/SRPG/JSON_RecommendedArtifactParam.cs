// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_RecommendedArtifactParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CA1")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_RecommendedArtifactParam
  {
    [Token(Token = "0x400707F")]
    [FieldOffset(Offset = "0x8")]
    public string unit_iname;
    [Token(Token = "0x4007080")]
    [FieldOffset(Offset = "0xC")]
    public string job_iname;
    [Token(Token = "0x4007081")]
    [FieldOffset(Offset = "0x10")]
    public string arti1_iname;
    [Token(Token = "0x4007082")]
    [FieldOffset(Offset = "0x14")]
    public string arti2_iname;
    [Token(Token = "0x4007083")]
    [FieldOffset(Offset = "0x18")]
    public string arti3_iname;

    [Token(Token = "0x60075F4")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_RecommendedArtifactParam()
    {
    }
  }
}
