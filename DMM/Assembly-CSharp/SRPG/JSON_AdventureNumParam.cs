// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_AdventureNumParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001980")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_AdventureNumParam
  {
    [Token(Token = "0x4005CE4")]
    [FieldOffset(Offset = "0x8")]
    public int adv_num;
    [Token(Token = "0x4005CE5")]
    [FieldOffset(Offset = "0xC")]
    public JSON_AdventureNumParam.AdvCond[] adv_conds;

    [Token(Token = "0x60067FB")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_AdventureNumParam()
    {
    }

    [Token(Token = "0x2001981")]
    [MessagePackObject(true)]
    [Serializable]
    public class AdvCond
    {
      [Token(Token = "0x4005CE6")]
      [FieldOffset(Offset = "0x8")]
      public int adv_add;
      [Token(Token = "0x4005CE7")]
      [FieldOffset(Offset = "0xC")]
      public int clear_num;

      [Token(Token = "0x60067FC")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public AdvCond()
      {
      }
    }
  }
}
