// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_JobSetParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E11")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_JobSetParam
  {
    [Token(Token = "0x4007A23")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4007A24")]
    [FieldOffset(Offset = "0xC")]
    public string job;
    [Token(Token = "0x4007A25")]
    [FieldOffset(Offset = "0x10")]
    public int lrare;
    [Token(Token = "0x4007A26")]
    [FieldOffset(Offset = "0x14")]
    public int lplus;
    [Token(Token = "0x4007A27")]
    [FieldOffset(Offset = "0x18")]
    public string ljob1;
    [Token(Token = "0x4007A28")]
    [FieldOffset(Offset = "0x1C")]
    public int llv1;
    [Token(Token = "0x4007A29")]
    [FieldOffset(Offset = "0x20")]
    public string ljob2;
    [Token(Token = "0x4007A2A")]
    [FieldOffset(Offset = "0x24")]
    public int llv2;
    [Token(Token = "0x4007A2B")]
    [FieldOffset(Offset = "0x28")]
    public string ljob3;
    [Token(Token = "0x4007A2C")]
    [FieldOffset(Offset = "0x2C")]
    public int llv3;
    [Token(Token = "0x4007A2D")]
    [FieldOffset(Offset = "0x30")]
    public string cjob;
    [Token(Token = "0x4007A2E")]
    [FieldOffset(Offset = "0x34")]
    public string target_unit;
    [Token(Token = "0x4007A2F")]
    [FieldOffset(Offset = "0x38")]
    public int joblv_opened;

    [Token(Token = "0x6007B75")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_JobSetParam()
    {
    }
  }
}
