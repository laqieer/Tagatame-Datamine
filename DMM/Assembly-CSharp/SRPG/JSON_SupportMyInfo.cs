// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_SupportMyInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200103E")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_SupportMyInfo
  {
    [Token(Token = "0x40039DB")]
    [FieldOffset(Offset = "0x8")]
    public int score;
    [Token(Token = "0x40039DC")]
    [FieldOffset(Offset = "0xC")]
    public int rank;
    [Token(Token = "0x40039DD")]
    [FieldOffset(Offset = "0x10")]
    public Json_Unit unit;

    [Token(Token = "0x60042B0")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_SupportMyInfo()
    {
    }
  }
}
