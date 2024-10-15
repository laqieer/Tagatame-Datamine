// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_SortArtifactCondParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D48")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_SortArtifactCondParam
  {
    [Token(Token = "0x400731D")]
    [FieldOffset(Offset = "0x8")]
    public string cnds_iname;
    [Token(Token = "0x400731E")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x400731F")]
    [FieldOffset(Offset = "0x10")]
    public int sort_type;
    [Token(Token = "0x4007320")]
    [FieldOffset(Offset = "0x14")]
    public int param_type;
    [Token(Token = "0x4007321")]
    [FieldOffset(Offset = "0x18")]
    public string tag_name;

    [Token(Token = "0x60077F4")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_SortArtifactCondParam()
    {
    }
  }
}
