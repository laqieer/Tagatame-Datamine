// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_AdventureCostParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001977")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_AdventureCostParam
  {
    [Token(Token = "0x4005CCD")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4005CCE")]
    [FieldOffset(Offset = "0xC")]
    public int ap_num;
    [Token(Token = "0x4005CCF")]
    [FieldOffset(Offset = "0x10")]
    public JSON_AdventureCostParam.Cost[] costs;

    [Token(Token = "0x60067DF")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_AdventureCostParam()
    {
    }

    [Token(Token = "0x2001978")]
    [MessagePackObject(true)]
    [Serializable]
    public class Cost
    {
      [Token(Token = "0x4005CD0")]
      [FieldOffset(Offset = "0x8")]
      public string item_iname;
      [Token(Token = "0x4005CD1")]
      [FieldOffset(Offset = "0xC")]
      public int item_num;

      [Token(Token = "0x60067E0")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Cost()
      {
      }
    }
  }
}
