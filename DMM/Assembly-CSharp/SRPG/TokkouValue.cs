// Decompiled with JetBrains decompiler
// Type: SRPG.TokkouValue
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E82")]
  [MessagePackObject(true)]
  [Serializable]
  public class TokkouValue
  {
    [Token(Token = "0x4007E97")]
    [FieldOffset(Offset = "0x8")]
    public string tag;
    [Token(Token = "0x4007E98")]
    [FieldOffset(Offset = "0xC")]
    public short value;

    [Token(Token = "0x6007D22")]
    [Address(RVA = "0x3F0DA0", Offset = "0x3EFBA0", VA = "0x103F0DA0")]
    public TokkouValue Clone() => (TokkouValue) null;

    [Token(Token = "0x6007D23")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public TokkouValue()
    {
    }
  }
}
