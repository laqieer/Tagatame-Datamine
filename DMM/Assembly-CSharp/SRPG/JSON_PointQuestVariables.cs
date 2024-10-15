// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_PointQuestVariables
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C0C")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_PointQuestVariables
  {
    [Token(Token = "0x4006CA8")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x4006CA9")]
    [FieldOffset(Offset = "0xC")]
    public int constant;
    [Token(Token = "0x4006CAA")]
    [FieldOffset(Offset = "0x10")]
    public int coefficient;
    [Token(Token = "0x4006CAB")]
    [FieldOffset(Offset = "0x14")]
    public int min;
    [Token(Token = "0x4006CAC")]
    [FieldOffset(Offset = "0x18")]
    public int max;
    [Token(Token = "0x4006CAD")]
    [FieldOffset(Offset = "0x1C")]
    public int[] element;

    [Token(Token = "0x600738D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_PointQuestVariables()
    {
    }
  }
}
