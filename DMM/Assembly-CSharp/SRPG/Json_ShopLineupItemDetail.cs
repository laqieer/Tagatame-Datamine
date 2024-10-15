// Decompiled with JetBrains decompiler
// Type: SRPG.Json_ShopLineupItemDetail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002AA4")]
  [Serializable]
  public class Json_ShopLineupItemDetail
  {
    [Token(Token = "0x400CFDE")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x400CFDF")]
    [FieldOffset(Offset = "0xC")]
    public string itype;

    [Token(Token = "0x600C2B7")]
    [Address(RVA = "0x8A63F0", Offset = "0x8A51F0", VA = "0x108A63F0")]
    public EShopItemType GetShopItemTypeWithIType() => new EShopItemType();

    [Token(Token = "0x600C2B8")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_ShopLineupItemDetail()
    {
    }
  }
}
