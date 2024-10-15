// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_InitPlayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BDC")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_InitPlayer
  {
    [Token(Token = "0x4006BBC")]
    [FieldOffset(Offset = "0x8")]
    public int gold;
    [Token(Token = "0x4006BBD")]
    [FieldOffset(Offset = "0xC")]
    public int coin;
    [Token(Token = "0x4006BBE")]
    [FieldOffset(Offset = "0x10")]
    public int ap;
    [Token(Token = "0x4006BBF")]
    [FieldOffset(Offset = "0x14")]
    public int exp;

    [Token(Token = "0x6007303")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_InitPlayer()
    {
    }
  }
}
