// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_PointQuestGuildData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002817")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_PointQuestGuildData
  {
    [Token(Token = "0x400BF0C")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x400BF0D")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x400BF0E")]
    [FieldOffset(Offset = "0x10")]
    public int rank;

    [Token(Token = "0x600B50E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_PointQuestGuildData()
    {
    }
  }
}
