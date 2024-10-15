// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_RecipeParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C9E")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_RecipeParam
  {
    [Token(Token = "0x400706E")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x400706F")]
    [FieldOffset(Offset = "0xC")]
    public int cost;
    [Token(Token = "0x4007070")]
    [FieldOffset(Offset = "0x10")]
    public string mat1;
    [Token(Token = "0x4007071")]
    [FieldOffset(Offset = "0x14")]
    public string mat2;
    [Token(Token = "0x4007072")]
    [FieldOffset(Offset = "0x18")]
    public string mat3;
    [Token(Token = "0x4007073")]
    [FieldOffset(Offset = "0x1C")]
    public string mat4;
    [Token(Token = "0x4007074")]
    [FieldOffset(Offset = "0x20")]
    public string mat5;
    [Token(Token = "0x4007075")]
    [FieldOffset(Offset = "0x24")]
    public int num1;
    [Token(Token = "0x4007076")]
    [FieldOffset(Offset = "0x28")]
    public int num2;
    [Token(Token = "0x4007077")]
    [FieldOffset(Offset = "0x2C")]
    public int num3;
    [Token(Token = "0x4007078")]
    [FieldOffset(Offset = "0x30")]
    public int num4;
    [Token(Token = "0x4007079")]
    [FieldOffset(Offset = "0x34")]
    public int num5;

    [Token(Token = "0x60075F0")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_RecipeParam()
    {
    }
  }
}
