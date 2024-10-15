// Decompiled with JetBrains decompiler
// Type: SRPG.ShopTimeOutItemInfoArray
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001125")]
  [Serializable]
  public class ShopTimeOutItemInfoArray
  {
    [Token(Token = "0x4003E47")]
    [FieldOffset(Offset = "0x8")]
    public ShopTimeOutItemInfo[] Infos;

    [Token(Token = "0x600488A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ShopTimeOutItemInfoArray()
    {
    }

    [Token(Token = "0x600488B")]
    [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
    public ShopTimeOutItemInfoArray(ShopTimeOutItemInfo[] infos)
    {
    }
  }
}
