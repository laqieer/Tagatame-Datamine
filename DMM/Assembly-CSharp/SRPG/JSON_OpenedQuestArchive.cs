// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_OpenedQuestArchive
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20010BA")]
  [Serializable]
  public class JSON_OpenedQuestArchive
  {
    [Token(Token = "0x4003C09")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4003C0A")]
    [FieldOffset(Offset = "0x10")]
    public long begin_at;
    [Token(Token = "0x4003C0B")]
    [FieldOffset(Offset = "0x18")]
    public long end_at;

    [Token(Token = "0x60046D4")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_OpenedQuestArchive()
    {
    }
  }
}
