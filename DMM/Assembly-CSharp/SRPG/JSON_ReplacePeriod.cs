// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_ReplacePeriod
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200266E")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_ReplacePeriod
  {
    [Token(Token = "0x400B39C")]
    [FieldOffset(Offset = "0x8")]
    public string sprite_name;
    [Token(Token = "0x400B39D")]
    [FieldOffset(Offset = "0xC")]
    public string begin_at;
    [Token(Token = "0x400B39E")]
    [FieldOffset(Offset = "0x10")]
    public string end_at;

    [Token(Token = "0x600AB99")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_ReplacePeriod()
    {
    }
  }
}
