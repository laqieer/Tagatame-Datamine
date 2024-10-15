// Decompiled with JetBrains decompiler
// Type: SRPG.StringIsResourcePath
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001149")]
  public class StringIsResourcePath : PropertyAttribute
  {
    [Token(Token = "0x4003ED4")]
    [FieldOffset(Offset = "0xC")]
    public System.Type ResourceType;
    [Token(Token = "0x4003ED5")]
    [FieldOffset(Offset = "0x10")]
    public string ParentDirectory;
    [Token(Token = "0x4003ED6")]
    [FieldOffset(Offset = "0x14")]
    public string EmptyLabel;

    [Token(Token = "0x60049E8")]
    [Address(RVA = "0x1207F70", Offset = "0x1206D70", VA = "0x11207F70")]
    public StringIsResourcePath(System.Type type)
    {
    }

    [Token(Token = "0x60049E9")]
    [Address(RVA = "0x1207F30", Offset = "0x1206D30", VA = "0x11207F30")]
    public StringIsResourcePath(System.Type type, string dir)
    {
    }

    [Token(Token = "0x60049EA")]
    [Address(RVA = "0x1207FB0", Offset = "0x1206DB0", VA = "0x11207FB0")]
    public StringIsResourcePath(System.Type type, string dir, string empty_label)
    {
    }
  }
}
