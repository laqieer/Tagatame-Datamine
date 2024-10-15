// Decompiled with JetBrains decompiler
// Type: SRPG.Json_GuerrillaShopPeriod
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200102D")]
  [MessagePackObject(true)]
  [Serializable]
  public class Json_GuerrillaShopPeriod
  {
    [Token(Token = "0x400398D")]
    [FieldOffset(Offset = "0x8")]
    public long time_start;
    [Token(Token = "0x400398E")]
    [FieldOffset(Offset = "0x10")]
    public long time_end;

    [Token(Token = "0x17000611")]
    public bool IsEmpty
    {
      [Token(Token = "0x6004292"), Address(RVA = "0x11DDAE0", Offset = "0x11DC8E0", VA = "0x111DDAE0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004293")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_GuerrillaShopPeriod()
    {
    }
  }
}
