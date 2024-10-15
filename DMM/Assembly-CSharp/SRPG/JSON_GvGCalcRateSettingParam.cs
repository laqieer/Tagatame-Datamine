// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GvGCalcRateSettingParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B69")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_GvGCalcRateSettingParam : JSON_GvGMasterParam
  {
    [Token(Token = "0x400687B")]
    [FieldOffset(Offset = "0x8")]
    public int enum1;
    [Token(Token = "0x400687C")]
    [FieldOffset(Offset = "0xC")]
    public int enum2;
    [Token(Token = "0x400687D")]
    [FieldOffset(Offset = "0x10")]
    public int enum3;
    [Token(Token = "0x400687E")]
    [FieldOffset(Offset = "0x14")]
    public int enum4;

    [Token(Token = "0x600711D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_GvGCalcRateSettingParam()
    {
    }
  }
}
