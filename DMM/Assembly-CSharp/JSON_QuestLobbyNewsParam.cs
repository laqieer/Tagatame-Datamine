// Decompiled with JetBrains decompiler
// Type: JSON_QuestLobbyNewsParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
[Token(Token = "0x200027B")]
[MessagePackObject(true)]
[Serializable]
public class JSON_QuestLobbyNewsParam
{
  [Token(Token = "0x4000A6C")]
  [FieldOffset(Offset = "0x8")]
  public int category;
  [Token(Token = "0x4000A6D")]
  [FieldOffset(Offset = "0xC")]
  public string begin_at;
  [Token(Token = "0x4000A6E")]
  [FieldOffset(Offset = "0x10")]
  public string end_at;
  [Token(Token = "0x4000A6F")]
  [FieldOffset(Offset = "0x14")]
  public int show_type;

  [Token(Token = "0x6000D5A")]
  [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
  public JSON_QuestLobbyNewsParam()
  {
  }
}
